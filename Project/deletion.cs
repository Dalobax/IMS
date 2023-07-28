using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class deletion
    {
        public void delete(object id, string proc, string param)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(proc, mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param, id);
               
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG("Data deleted successfully!!", "Success....", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
    }
}
