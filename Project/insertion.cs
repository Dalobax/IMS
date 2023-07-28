using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class insertion
    {
        public void insertUser(string name, string username, string pass,string email, string phone, Int16 status )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertUsers", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd",pass);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@status", status);
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG(name+" added successfully!!", "Success....", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
        public void insertCat(string name, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertCategory", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG(name + " added successfully!!", "Success....", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
    }
}
