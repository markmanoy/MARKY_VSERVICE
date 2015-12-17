using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ProductService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IProductService
    {

        /// <summary>
        /// Gets All list of products
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<ProductDTO> GetProducts();

        /// <summary>
        /// Get List of products starting with searchName
        /// </summary>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        [OperationContract]
        List<ProductDTO> SearchProduct(string searchName);





        /// <summary>
        /// Gets the product given product id
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        [OperationContract]
        ProductDTO GetProduct(int id);

        /// <summary>
        /// Deletes the specified product given id.
        /// </summary>
        /// <param name="productId">The product id.</param>
        /// <returns></returns>
        [OperationContract]
        bool Delete(int productId);

        /// <summary>
        /// Adds the new product.
        /// </summary>
        [OperationContract]
        bool AddProduct(string name, string manufacturer, decimal cost, int type, int subtype);

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
        [OperationContract]
        ProductDTO EditProduct(int id, string name, string manufacturer, decimal cost, int type, int subtype);


        /// <summary>
        /// Gets list of product type/category
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        List<ProductType> GetProductType();


        /// <summary>
        /// Gets list of product sub-type/sub-categories give a product type/category
        /// </summary>
        /// <param name="productType">product type</param>
        /// <returns></returns>
        [OperationContract]
        List<ProductSubType> GetProductSubType(int productType);

    }


}
