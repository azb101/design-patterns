using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Live
{
    public class Products : DataAccessObject
    {
        private SqlDataReader reader;

        public Products(string connectionString) : base(connectionString)
        {
        }

        protected override void Process()
        {
            Console.WriteLine("Process Products");
            // read everything using data reader
        }

        protected override void Select()
        {
            Console.WriteLine("Select Products");
            // string query = "Select * from Products";
            //
            // var cmd = new SqlCommand(query);
            // cmd.Connection = sqlConnection;
            // reader = cmd.ExecuteReader();
        }
    }
}