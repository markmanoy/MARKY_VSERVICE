using Item.Access.SqlQuery;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Item.Access.DataAccess
{
    /// <summary>
    /// Item Accessor
    /// </summary>
    /// <seealso cref="Item.Access.DataAccess.IItemAccessor" />
    class ItemAccessor : IItemAccessor
    {
        /// <summary>
        /// The SQL Connection
        /// </summary>
        private SqlConnection _con;

        /// <summary>
        /// Creates the new database connection.
        /// </summary>
        private void CreateNewDbConnection()
        {
            _con = new SqlConnection("Data Source=MMANOY-T440P\\SQLEXPRESS;Initial Catalog=MARKY_20151212;Integrated Security=True");
        }

        /// <summary>
        /// Gets the equipment list.
        /// </summary>
        /// <returns></returns>
        public List<ItemBE.ItemInfo> GetItemList(string searchName)
        {
            SqlCommand cmd = new SqlCommand();
            CreateNewDbConnection();
            var itemList = new List<ItemBE.ItemInfo>();

            try
            {
                _con.Open();
                cmd = new SqlCommand(ItemQueries.Item_ThousandRecords_Select, _con);
                cmd.Parameters.AddWithValue("@Name", searchName);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());

                foreach (DataRow dr in dt.Rows)
                {
                    var item = new ItemBE.ItemInfo();

                    item.Id = Convert.ToInt32(Convert.ToString(dr["Id"]));
                    item.Name = Convert.ToString(dr["Name"]);
                    item.Manufacturer = Convert.ToString(dr["Manufacturer"]);
                    item.TypeId = Convert.ToInt32(dr["TypeId"]);
                    item.SubTypeId = Convert.ToInt32(dr["SubTypeId"]);
                    item.Cost = Convert.ToDecimal(dr["Cost"]);

                    itemList.Add(item);
                }
            }
            catch (Exception e)
            {
                var CompanyLogDatabaseException = e.Message;
            }
            finally
            {
                cmd.Dispose();
                _con.Close();
                _con.Dispose();
            }
            return itemList;
        }

        /// <summary>
        /// Inserts the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool InsertItem(ItemBE.ItemInfo item)
        {
            SqlCommand cmd = new SqlCommand();
            CreateNewDbConnection();
            bool added;

            try
            {
                _con.Open();

                cmd.Connection = _con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ItemQueries.Item_Create;

                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Manufacturer", item.Manufacturer);
                cmd.Parameters.AddWithValue("@Cost", item.Cost);
                cmd.Parameters.AddWithValue("@TypeId", item.TypeId);
                cmd.Parameters.AddWithValue("@SubTypeId", item.SubTypeId);
                added = (cmd.ExecuteNonQuery() > 0);
            }
            catch (Exception e)
            {
                var CompanyLogDatabaseException = e.Message;
                added = false;
            }
            finally
            {
                cmd.Dispose();
                _con.Close();
                _con.Dispose();
            }
            return added;
        }

        /// <summary>
        /// Updates the item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public bool UpdateItem(ItemBE.ItemInfo item)
        {
            SqlCommand cmd = new SqlCommand();
            CreateNewDbConnection();
            bool updated;

            try
            {
                _con.Open();
                cmd = new SqlCommand(ItemQueries.Item_Update, _con);
                cmd.Parameters.AddWithValue("@Id", item.Id);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@Manufacturer", item.Manufacturer);
                cmd.Parameters.AddWithValue("@Cost", item.Cost);
                cmd.Parameters.AddWithValue("@TypeId", item.TypeId);
                cmd.Parameters.AddWithValue("@SubTypeId", item.SubTypeId);

                updated = (cmd.ExecuteNonQuery() > 0);

            }
            catch (Exception e)
            {
                var CompanyLogDatabaseException = e.Message;
                updated = false;
            }
            finally
            {
                cmd.Dispose();
                _con.Close();
                _con.Dispose();
            }
            return updated;
        }

        /// <summary>
        /// Deletes the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public bool DeleteItem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            CreateNewDbConnection();
            bool deleted;

            try
            {
                _con.Open();
                cmd = new SqlCommand(ItemQueries.Item_Delete, _con);
                cmd.Parameters.AddWithValue("@Id", id);
                deleted = (cmd.ExecuteNonQuery() > 0);

            }
            catch (Exception e)
            {
                var CompanyLogDatabaseException = e.Message;
                deleted = false;
            }
            finally
            {
                cmd.Dispose();
                _con.Close();
                _con.Dispose();
            }
            return deleted;
        }

        /// <summary>
        /// Gets the item.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public ItemBE.ItemInfo GetItem(int id)
        {
            SqlCommand cmd = new SqlCommand();
            CreateNewDbConnection();
            var item = new ItemBE.ItemInfo();

            try
            {
                _con.Open();
                cmd = new SqlCommand(ItemQueries.Item_Detail_Select, _con);
                cmd.Parameters.AddWithValue("@Id", id);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                DataRow dr = dt.Rows[0];


                item.Id = Convert.ToInt32(Convert.ToString(dr["Id"]));
                item.Name = Convert.ToString(dr["Name"]);
                item.Manufacturer = Convert.ToString(dr["Manufacturer"]);
                item.TypeId = Convert.ToInt32(dr["TypeId"]);
                item.SubTypeId = Convert.ToInt32(dr["SubTypeId"]);
                item.Cost = Convert.ToDecimal(dr["Cost"]);
            }
            catch (Exception e)
            {
                var CompanyLogDatabaseException = e.Message;
            }
            finally
            {
                cmd.Dispose();
                _con.Close();
                _con.Dispose();
            }
            return item;
        }
    }
}
