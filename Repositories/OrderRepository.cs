using Dapper;
using Microsoft.Data.SqlClient;
using Models;
using System.Configuration;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private string Conn { get; set; }

        public OrderRepository()
        {
            Conn = ConfigurationManager.ConnectionStrings["StringConnection"].ConnectionString;
        }

        public bool Insert(Order order)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_ORDER (DESCRIPTION_ORDER, TABLE_ORDER, ITEM_ID) VALUES (@Desc, @Tb, @Id", new
                {
                    Desc = order.Description,
                    Tb = order.Table,
                    Id = order?.Item?.Id
                });
                status = true;
                db.Close();
            }
            return status;
        }
    }
}