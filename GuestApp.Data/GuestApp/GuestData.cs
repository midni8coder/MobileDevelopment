using GuestApp.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestApp.Data.GuestApp
{
    public class GuestData : BaseData
    {


        public DataSet GetGuestList(string QueryXML = null)
        {
            DataSet ds = new DataSet();
            try
            {
                //Data Layer
                //Pass the connection object to Command
                base._command.CommandType = CommandType.StoredProcedure; // We will use stored procedure.
                base._command.CommandText = "KHH_GET_PATIENTLIST"; //Stored Procedure Name
                //com.Parameters.Add("@Name", SqlDbType.NVarChar).Value = name;
                //com.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                //com.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;
                //com.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
                //com.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = base._command;
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                Logger.LogError("UserData > GetPatientsList ", ex);
            }
            finally
            {
                base._connection.Close();
            }
            return ds;
        }
    }
}
