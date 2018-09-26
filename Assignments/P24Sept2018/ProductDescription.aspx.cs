using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Reflection.Emit;

namespace P24Sept2018
{
    public partial class ProductDescription : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           string IDParam= Request.QueryString["Id"];
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=ACULAP-119;Initial Catalog=IndividualAuth;Integrated Security=True";
                connection.Open();
                string sql = "select * from Products where Id ="+IDParam;
                SqlCommand mycommand = new SqlCommand(sql, connection);
               
                using (SqlDataReader myDataReader = mycommand.ExecuteReader())
                {
                   while(myDataReader.Read())
                   {
                        ProductName.Text = myDataReader["Name"].ToString();
                        ProductPrice.Text = myDataReader["Price"].ToString();
                        Description.Text = myDataReader["Description"].ToString();
                        Image1.ImageUrl= myDataReader["URL"].ToString();
                   }
                }
            }
        }
         

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}