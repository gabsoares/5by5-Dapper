using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class ItemRepository : IItemRepository
    {
        private string Conn { get; set; }
        public ItemRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public int Insert(Item item)
        {
            int itemId = 0;
            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                itemId = db.ExecuteScalar<int>(Item.INSERT, item);
                db.Close();
            }
            return itemId;
        }
    }
}