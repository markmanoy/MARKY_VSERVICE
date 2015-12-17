using ItemBE;
using System.Collections.Generic;
using System.ServiceModel;
namespace MARKY_VSERVICE
{
    /// <summary>
    /// Interface for Item Service
    /// </summary>
    [ServiceContract]
    public interface IItemService
    {

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        [OperationContract]
        List<ItemInfo> GetItemList(string searchName);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]

        ItemInfo GetItem(int id);

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="type">The type.</param>
        /// <param name="subtype">The subtype.</param>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        [OperationContract]
        bool AddItem(string name, string manufacturer, int type, int subtype, decimal cost);

        /// <summary>
        /// Updates the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="type">The type.</param>
        /// <param name="subtype">The subtype.</param>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        [OperationContract]

        bool UpdateItem(int id, string name, string manufacturer, int type, int subtype, decimal cost);

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [OperationContract]

        bool DeleteItem(int id);
    }
}
