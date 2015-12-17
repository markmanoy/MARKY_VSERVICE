using ItemBE;
using System.Collections.Generic;
namespace Item.Access.DataAccess
{
    /// <summary>
    /// Interface for Item Accessor
    /// </summary>
    public interface IItemAccessor
    {
        /// <summary>
        /// Inserts the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        bool InsertItem(ItemInfo item);

        /// <summary>
        /// Updates the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        bool UpdateItem(ItemInfo item);

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool DeleteItem(int id);

        /// <summary>
        /// Gets the item list.
        /// </summary>
        /// <param name="searchName">Name of the search.</param>
        /// <returns></returns>
        List<ItemInfo> GetItemList(string searchName);

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        ItemInfo GetItem(int id);
    }
}
