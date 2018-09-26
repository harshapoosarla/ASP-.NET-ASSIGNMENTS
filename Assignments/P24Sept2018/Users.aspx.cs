using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.ProductRepository;

namespace P24Sept2018
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //if (!Context.User.IsInRole("Users"))
                //{
                //    Response.Redirect("Access.aspx");
                //}
                ProductRepository productlist = new ProductRepository();
                productlist.GetProductList();
                Table DisplayTable = new Table();
                PlaceHolder1.Controls.Add(DisplayTable);
                //int cellcount = 1;
                //int productcount = 0;
                for (int rowcount = 0; rowcount < ProductRepository.productslist.Count; rowcount++)
                {
                    TableRow TabRow = new TableRow();
                    DisplayTable.Rows.Add(TabRow);
                    
                    TableCell TabCell1 = new TableCell();
                    TabRow.Cells.Add(TabCell1);
                    Image img1 = new Image();
                    Label lbl1 = new Label();
                    HyperLink hyper = new HyperLink();
                    string ProdID = ProductRepository.productslist[rowcount].Id.ToString();
                    TabCell1.Controls.Add(img1);
                    TabCell1.Controls.Add(hyper);
                    TabCell1.Controls.Add(lbl1);
                    hyper.Text = ProductRepository.productslist[rowcount].Name;
                    hyper.NavigateUrl = "~/ProductDescription.aspx?ID=" + ProdID;
                    img1.ImageUrl = ProductRepository.productslist[rowcount].URL;
                    lbl1.Text = Convert.ToString(ProductRepository.productslist[rowcount].Price);
                }
            }
            else
            {
                string textdata = TextBox1.Text;
                string query = "select * from Products where Name Like '%"+ textdata +"%'";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = "Data Source=ACULAP-119;Initial Catalog=IndividualAuth;Integrated Security=True";
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                Table DisplayTable = new Table();
                PlaceHolder1.Controls.Add(DisplayTable);
                //int rowcount = 0;
                while (sqlDataReader.Read())
                {
                    TableRow TabRow = new TableRow();
                    DisplayTable.Rows.Add(TabRow);
                    TableCell TabCell1 = new TableCell();
                    TabRow.Cells.Add(TabCell1);
                    Image img1 = new Image();
                    Label lbl1 = new Label();
                    HyperLink hyper = new HyperLink();
                    string ProdID = sqlDataReader["Id"].ToString();
                    TabCell1.Controls.Add(img1);
                    TabCell1.Controls.Add(hyper);
                    TabCell1.Controls.Add(lbl1);
                    hyper.Text = sqlDataReader["Name"].ToString();
                    hyper.NavigateUrl = "~/ProductDescription.aspx?ID=" + ProdID;
                    img1.ImageUrl = sqlDataReader["URL"].ToString();
                    lbl1.Text = Convert.ToString(sqlDataReader["Price"]);
                }
            }   
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
//            using (SqlConnection connection = new SqlConnection())
//            {
//                connection.ConnectionString = @"Data Source=ACULAP-119;Initial Catalog=IndividualAuth;Integrated Security=True";
//                connection.Open();
//                string sql = "Select * from Products";
//                SqlCommand myCommand = new SqlCommand(sql, connection);
//                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
//                {
//                    while (myDataReader.Read())
//                    {

//                        //myDataReader.Read();
//                        Table DisplayTable = new Table();
//                        PlaceHolder1.Controls.Add(DisplayTable);
//                        int cellcount = 0;
//                        TableRow TabRow = new TableRow();
//                        DisplayTable.Rows.Add(TabRow);
//                        while (myDataReader.Read())
//                        {
//                            if (cellcount == 2)
//                            {
//                                TableRow TabRow1 = new TableRow();
//                                DisplayTable.Rows.Add(TabRow1);
//                                cellcount = 0;
//                            }
//                            TableCell TabCell = new TableCell();
//                            TabRow.Cells.Add(TabCell);
//                            Image im1 = new Image();
//                            Label lbl = new Label();
//                            //DisplayTable.
//                            TabCell.Controls.Add(im1);
//                            lbl.Text = myDataReader["Price"].ToString();
//                            im1.ImageUrl = myDataReader["URL"].ToString();


//                        }
//                        //{
//                        //    Label1.Text = myDataReader["Name"].ToString();
//                        //    Image1.ImageUrl = myDataReader["URL"].ToString();
//                        //    Label2.Text = myDataReader["Price"].ToString();
//                        //}
//                        //myDataReader.Read();
//                        //{
//                        //    Label3.Text = myDataReader["Name"].ToString();
//                        //    Image2.ImageUrl = myDataReader["URL"].ToString();
//                        //    Label4.Text = myDataReader["Price"].ToString();
//                        //}
//                        //myDataReader.Read();
//                        //{
//                        //    Label5.Text = myDataReader["Name"].ToString();
//                        //    Image3.ImageUrl = myDataReader["URL"].ToString();
//                        //    Label6.Text = myDataReader["Price"].ToString();
//                        //}
//                        //myDataReader.Read();
//                        //{
//                        //    Label6.Text = myDataReader["Name"].ToString();
//                        //    Image4.ImageUrl = myDataReader["URL"].ToString();
//                        //    Label7.Text = myDataReader["Price"].ToString();
//                        //}
//                    }
//                }
//            }
//        }
//    }
//}