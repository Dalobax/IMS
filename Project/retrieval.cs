using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class retrieval
    {
        public void showUsers(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null ) 
                { 
                   cmd = new SqlCommand("st_getUsersData", mainClass.con); 
                }
                else
                {
                   cmd = new SqlCommand("st_getUsersDataLIKE", mainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }
            
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                
            }
        }
        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catNameGV, DataGridViewColumn statGV, string data =null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategoriesData", mainClass.con);


                }
                else
                {


                    cmd = new SqlCommand("st_getCategoriesDataLIKE", mainClass.con);
                    cmd.Parameters.AddWithValue("@data",data);

                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception)
            {
                mainClass.ShowMSG("Unable to load categories data!", "Error", "Error");
            }
        }
        
        public void getCategoriesList(string proc, ComboBox cb, string displayMember, string valueMember)
        {
            try 
            {
                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select....");
                SqlCommand cmd = new SqlCommand("st_getCategoriesList", mainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt) ;
                cb.DataSource=dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
               
            }
            catch(Exception)
            {

            }
        }

        internal void getCategoriesList(string v1, TextBox categoryDD, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}
