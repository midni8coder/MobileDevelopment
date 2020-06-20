using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestApp.Data.GuestApp
{
    public class BaseData
    {
        protected SqlCommand _command;
        protected SqlConnection _connection;
        public BaseData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            _connection = new SqlConnection(connectionString);
            _command = new SqlCommand(); // Create a object of SqlCommand class
            _command.Connection = _connection;
        }
    }
}
