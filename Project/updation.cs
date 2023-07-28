using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    internal class updation
    {
        public void updateUser(int id, string name, string username, string pass, string email, string phone, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateUsers", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pwd", pass);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG(name + "Updated successfully!!", "Success....", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
        public void updateCat(int id, string name, Int16 status)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_updateCategory", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@isActive", status);
                cmd.Parameters.AddWithValue("@id", id);
                mainClass.con.Open();
                cmd.ExecuteNonQuery();
                mainClass.con.Close();
                mainClass.ShowMSG(name + " Updated successfully!!", "Success....", "Success");
            }
            catch (Exception ex)
            {
                mainClass.con.Close();
                mainClass.ShowMSG(ex.Message, "Error....", "Error");
            }

        }
    }
}
