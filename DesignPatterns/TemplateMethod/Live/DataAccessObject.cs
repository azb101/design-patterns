using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Live
{
    public abstract class DataAccessObject
    {
        protected SqlConnection sqlConnection;
        protected string connectionString;
        protected dynamic data;

        public DataAccessObject(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }

        protected virtual void Connect()
        {
            Console.WriteLine("Connect");
            connectionString = "";

            // if (string.IsNullOrWhiteSpace(connectionString))
            //     throw new Exception("no connection specified");

            // sqlConnection = new SqlConnection(connectionString);
            // sqlConnection.Open();
        }

        protected virtual void Disconnect()
        {
            Console.WriteLine("DisConnect");
            // if (sqlConnection != null)
            // {
            //     if (sqlConnection.State != ConnectionState.Closed)
            //     {
            //         sqlConnection.Close();
            //         sqlConnection.Dispose();
            //     }
            // }
            //
            // if (data != null)
            //     data = null;
        }

        protected abstract void Select();

        protected abstract void Process();
    }
}