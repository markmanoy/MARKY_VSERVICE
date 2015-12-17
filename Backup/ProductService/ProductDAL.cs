using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace ProductService
{
    //Mocked Product Data Access Layer.
    public class ProductDAL
    {
        #region Private variables and Methods
        private static List<Product> _statictList = null;
        private static List<ProductType> _staticType = null;
        private static List<ProductSubType> _staticSubType = null;

        private static ProductDAL _this = new ProductDAL();


        /// <summary>
        /// Gets the product by id.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns></returns>
        private Product GetProductById(int productId)
        {
            return _statictList.SingleOrDefault(s => s.ID == productId);

        }
        #endregion


        //Singleton Instance
        public static ProductDAL Instance { get { return _this; } }


        #region Initialization
        private ProductDAL()
        {
            InitiateList();

        }

        private void InitiateList()
        {

            if (_statictList == null)
            {
                DummyProductDataGenerator mock = new DummyProductDataGenerator();
                _statictList = mock.DummyProduct();
                _staticType = mock.DummyProductType();
                _staticSubType = mock.DummyProductSubType();
                mock = null;

            }


        }
        #endregion


        #region DAL Operations
        #region CRUD (Create,Update Delete)
        /// <summary>
        /// Add new Prodct
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            DummyProductDataGenerator mock = new DummyProductDataGenerator();
            product.ID = mock.GetNExtId(_statictList);
            _statictList.Add(product);
            mock = null;

        }

        /// <summary>
        /// Edit Product
        /// </summary>
        /// <param name="prodId">product Id</param>
        /// <param name="name"></param>
        /// <param name="manufacturer"></param>
        /// <param name="cost"></param>
        /// <param name="type"></param>
        /// <param name="subtype"></param>
        /// <returns></returns>
        public ProductDTO Edit(int prodId, string name, string manufacturer, decimal cost, int type, int subtype)
        {
            Product prod = _statictList.SingleOrDefault(s => s.ID == prodId);

            if (prod == null)
                throw new Exception("Product id doesn't exist");
            else
            {
                prod.Name = name;
                prod.Manufacturer = manufacturer;
                prod.Cost = cost;
                prod.TypeID = type;
                prod.SubTypeID = subtype;
            }



            return GetProductDTOById(prod.ID);
        }



        /// <summary>
        /// Deletes product given product id
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns></returns>
        public bool Delete(int productId)
        {
            var prod = this.GetProductById(productId);
            if (prod != null)
            {
                _statictList.Remove(prod);
                return true;
            }
            else
                return false;
        }
        #endregion

        #region Search and Select


        /// <summary>
        /// Search products by Name
        /// </summary>
        /// <param name="searchVal"></param>
        /// <returns></returns>
        public List<ProductDTO> Search(string searchVal)
        {
            var allProd = GetProducts();
            var retVal = from e in _statictList
                         join t in _staticType on e.TypeID equals t.TypeID
                         join st in _staticSubType on e.SubTypeID equals st.SubTypeID
                         where e.Name != null && e.Name.StartsWith(searchVal, StringComparison.InvariantCultureIgnoreCase)
                         select new ProductDTO()
                         {
                             ID = e.ID,
                             SubTypeID = e.SubTypeID,
                             Type = t.Type,
                             Cost = e.Cost,
                             Manufacturer = e.Manufacturer,
                             Name = e.Name,
                             SubType = st.SubType,
                             TypeID = e.TypeID


                         };

            return retVal.ToList();

            //return allProd.Where(s => s.Name.StartsWith(searchVal, StringComparison.InvariantCultureIgnoreCase)).ToList();

        }


        /// <summary>
        /// Gets all Products
        /// </summary>
        /// <returns></returns>
        public List<ProductDTO> GetProducts()
        {

            var retVal = from e in _statictList
                         join t in _staticType on e.TypeID equals t.TypeID
                         join st in _staticSubType on e.SubTypeID equals st.SubTypeID
                         select new ProductDTO()
                         {
                             ID = e.ID,
                             SubTypeID = e.SubTypeID,
                             Type = t.Type,
                             Cost = e.Cost,
                             Manufacturer = e.Manufacturer,
                             Name = e.Name,
                             SubType = st.SubType,
                             TypeID = e.TypeID


                         };

            return retVal.ToList();

        }




        /// <summary>
        /// Gets the product given product id
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns></returns>
        public ProductDTO GetProductDTOById(int productId)
        {
            var retVal = from e in _statictList
                         join t in _staticType on e.TypeID equals t.TypeID
                         join st in _staticSubType on e.SubTypeID equals st.SubTypeID
                         where e.ID == productId
                         select new ProductDTO()
                         {
                             ID = e.ID,
                             SubTypeID = e.SubTypeID,
                             Type = t.Type,
                             Cost = e.Cost,
                             Manufacturer = e.Manufacturer,
                             Name = e.Name,
                             SubType = st.SubType,
                             TypeID = e.TypeID


                         };

            return retVal.FirstOrDefault();

        }



        /// <summary>
        /// Gets the product types/categories.
        /// </summary>
        /// <returns></returns>
        public List<ProductType> GetProductTypes()
        {
            return _staticType;

        }


        /// <summary>
        /// Gets the product sub-types/sub-categories.
        /// </summary>
        /// <param name="productTypes">The product type/caegory.</param>
        /// <returns></returns>
        public List<ProductSubType> GetProductSubTypes(int productType)
        {
            return _staticSubType.Where(s => s.TypeId == productType).ToList();

        }
        #endregion

        #endregion

    }


    #region Data Contracts
    
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Manufacturer { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
        public int TypeID { get; set; }
        [DataMember]
        public int SubTypeID { get; set; }

        public Product()
        {}
        public Product(int id, string name, string manufacturer, decimal cost, int typeId, int subtypeid)
        {
            ID = id;
            Name = name;
            Manufacturer = manufacturer;
            Cost = cost;
            TypeID = typeId;
            SubTypeID = subtypeid;


        }
    }

    [DataContract]
    public class ProductType
    {
        [DataMember]
        public int TypeID { get; set; }
        [DataMember]
        public string Type { get; set; }

        public ProductType(int id, string type)
        {

            TypeID = id;
            Type = type;
        }
    }

    [DataContract]
    public class ProductSubType
    {
        [DataMember]
        public int SubTypeID { get; set; }
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public string SubType { get; set; }
        public ProductSubType(int id, int typeId,string subType)
        {

            SubTypeID = id;
            TypeId = typeId;
            SubType = subType;
        }

    }


    [DataContract]
    public class ProductDTO : Product
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string SubType { get; set; }

        
    }


    #endregion
}