using Item.Access;
using System.Collections.Generic;
using System.ServiceModel;
using ItemBE;
namespace MARKY_VSERVICE
{
    /// <summary>
    /// Marky's Dummy Service
    /// </summary>
    /// <seealso cref="MARKY_VSERVICE.IItemService" />
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ItemService : IItemService
    {
        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="type">The type.</param>
        /// <param name="subtype">The subtype.</param>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        public bool AddItem(string name, string manufacturer, int type, int subtype, decimal cost)
        {
            return ItemManager.Instance.AddItem(name, manufacturer, type, subtype, cost);
        }

        ///// <summary>
        ///// Gets the item.
        ///// </summary>
        ///// <param name="id">The identifier.</param>
        ///// <returns></returns>
        public ItemInfo GetItem(int id)
        {
            return ItemManager.Instance.GetItem(id);
        }

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
        public bool UpdateItem(int id, string name, string manufacturer, int type, int subtype, decimal cost)
        {
            return ItemManager.Instance.UpdateItem(id, name, manufacturer, type, subtype, cost);
        }

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteItem(int id)
        {
            return ItemManager.Instance.DeleteItem(id);
        }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <returns></returns>
        public List<ItemInfo> GetItemList(string searchName)
        {
            return ItemManager.Instance.GetItemList(searchName);
        }
    }
}
