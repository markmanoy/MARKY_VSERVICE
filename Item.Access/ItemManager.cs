using Item.Access.DataAccess;
using ItemBE;
using System.Collections.Generic;
namespace Item.Access
{
    /// <summary>
    /// Item Manager
    /// </summary>
    public class ItemManager
    {

        /// <summary>
        /// Item Manager
        /// </summary>
        private static ItemManager _this = new ItemManager();

        /// <summary>
        /// Gets the instance of Item Manager
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static ItemManager Instance { get { return _this; } }

        /// <summary>
        /// The _item
        /// </summary>
        private readonly IItemAccessor _item;

        /// <summary>
        /// Prevents a default instance of the <see cref="ItemManager"/> class from being created.
        /// </summary>
        private ItemManager()
        {
            _item = new ItemAccessor();
        }

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        public List<ItemInfo> GetItemList(string searchName)
        {
            return _item.GetItemList(searchName);
        }

        public ItemInfo GetItem(int id)
        {
            return _item.GetItem(id);
        }

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="typeId">The type identifier.</param>
        /// <param name="subtype">The subtype.</param>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        public bool AddItem(string name, string manufacturer, int typeId, int subtype, decimal cost)
        {
            return _item.InsertItem(new ItemInfo
            {
                Name = name,
                Manufacturer = manufacturer,
                TypeId = typeId,
                SubTypeId = subtype,
                Cost = cost,
            });
        }

        /// <summary>
        /// Updates the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="manufacturer">The manufacturer.</param>
        /// <param name="typeId">The type identifier.</param>
        /// <param name="subtype">The subtype.</param>
        /// <param name="cost">The cost.</param>
        /// <returns></returns>
        public bool UpdateItem(int id, string name, string manufacturer, int typeId, int subtype, decimal cost)
        {
            return _item.InsertItem(new ItemInfo
            {
                Id = id,
                Name = name,
                Manufacturer = manufacturer,
                TypeId = typeId,
                SubTypeId = subtype,
                Cost = cost,
            });
        }

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteItem(int id)
        {
            return _item.DeleteItem(id);
        }

    }
}