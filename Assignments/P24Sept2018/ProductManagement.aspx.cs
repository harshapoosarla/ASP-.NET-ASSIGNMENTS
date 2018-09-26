using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.ProductRepository;

namespace P24Sept2018
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Context.User.IsInRole("Products"))
            {
                Response.Redirect("Access.aspx");
            }
            
            ProductRepository productlist = new ProductRepository();
                productlist.GetProductList();
                Table DisplayTable = new Table();
            


            PlaceHolder1.Controls.Add(DisplayTable);
            
            for (int rowcount = 0; rowcount < ProductRepository.productslist.Count; rowcount++)
                {
                HyperLink preview = new HyperLink();
                HyperLink update = new HyperLink();
                HyperLink delete = new HyperLink();

                TableRow TabRow = new TableRow();
                    DisplayTable.Rows.Add(TabRow);
                    TableCell TabCell1 = new TableCell();
                    TabRow.Cells.Add(TabCell1);
                   
                    Label lbl1 = new Label();
                    lbl1.Width =200;

                    HyperLink hyper = new HyperLink();
                    hyper.Width = 200;
                    string ProdID = ProductRepository.productslist[rowcount].Id.ToString();
                    
                    TabCell1.Controls.Add(hyper);
                    TabCell1.Controls.Add(lbl1);
                    hyper.Text = ProductRepository.productslist[rowcount].Name;
                    hyper.NavigateUrl = "~/ProductDescription.aspx?ID=" + ProdID;
                   
                    lbl1.Text = Convert.ToString(ProductRepository.productslist[rowcount].Price);

                    preview.Text = "Preview";
                    preview.NavigateUrl = "~/ProductDescription.aspx ? ID = " + ProdID;
                preview.Width = 200;

                    update.Text = "Update";
                    update.NavigateUrl = "~/ProductDescription.aspx ? ID = " + ProdID;
                update.Width = 200;

                    delete.Text = "Delete";
                    delete.NavigateUrl = "~/ProductDescription.aspx ? ID = " + ProdID;
                delete.Width = 200;
                TabCell1.Controls.Add(preview);
                TabCell1.Controls.Add(update);
                TabCell1.Controls.Add(delete);
            }
        }
    }
}
