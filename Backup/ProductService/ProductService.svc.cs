using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ProductService : IProductService
    {
        /// <summary>
        /// Gets All list of products
        /// </summary>
        /// <returns></returns>
        public List<ProductDTO> GetProducts()
        {

            return ProductDAL.Instance.GetProducts();
        }

        /// <summary>
        /// Get List of products starting with searchName
        /// </summary>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        public List<ProductDTO> SearchProduct(string searchName)
        {
            return ProductDAL.Instance.Search(searchName);
        }

        /// <summary>
        /// Gets the product given product id
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        public ProductDTO GetProduct(int id)
        {
            return ProductDAL.Instance.GetProductDTOById(id);

        }


        /// <summary>
        /// Adds new product.
        /// </summary>
        public bool AddProduct(string name, string manufacturer, decimal cost, int type, int subtype)
        {
            var newProd = new Product(0, name, manufacturer, cost, type, subtype);

            ProductDAL.Instance.Add(newProd);

            return true;
        }
        /// <summary>
        /// Edits the product.
        /// </summary>
        /// <param name="id">The id of product to be modified</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="type">The type.</param>
        /// <param name="subtype">The subtype.</param>
        /// <returns></returns>
        public ProductDTO EditProduct(int id, string name, string manufacturer, decimal cost, int type, int subtype)
        {
            return ProductDAL.Instance.Edit(id, name, manufacturer, cost, type, subtype);
        }

        /// <summary>
        /// Deletes the specified product given id.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns></returns>
        public bool Delete(int productId)
        {
            return ProductDAL.Instance.Delete(productId);

        }

        /// <summary>
        /// Gets list of product type/category
        /// </summary>
        /// <returns></returns>
        public List<ProductType> GetProductType()
        {
            return ProductDAL.Instance.GetProductTypes();
        }

        /// <summary>
        /// Gets list of product sub-type/sub-categories give a product type/category
        /// </summary>
        /// <param name="productType">product type</param>
        /// <returns></returns>
        public List<ProductSubType> GetProductSubType(int productType)
        {
            return ProductDAL.Instance.GetProductSubTypes(productType);
        }
     
    }
}
