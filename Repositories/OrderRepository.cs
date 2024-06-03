using Dapper;
using Microsoft.Data.SqlClient;
using Models;

namespace Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private string Conn { get; set; }

        public OrderRepository()
        {
            Conn = "Data Source = 127.0.0.1; Initial Catalog=5by5-ProjAula4Andre; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True;";
        }

        public bool Insert(Order o)
        {
            var status = false;

            using (var db = new SqlConnection(Conn))
            {
                db.Open();
                db.Execute("INSERT INTO TB_ORDER (DESCRIPTION_ORDER, TABLE_ORDER) VALUES (@DESCRIPTION, @TABLE)", o);
                status = true;
                db.Close();
            }
            return status;
        }
    }
}