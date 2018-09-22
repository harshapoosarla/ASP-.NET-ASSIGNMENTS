using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P21Sept2018_RegistrationValidation
{
    public partial class displayData : System.Web.UI.Page
    {
        TextBox td;
        int o = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < RegistrationValidation.li.Count; i++) {
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = RegistrationValidation.li[i].firstname;
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = RegistrationValidation.li[i].lastname;
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = Convert.ToString(RegistrationValidation.li[i].mobilenumber);
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = RegistrationValidation.li[i].dob;
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = RegistrationValidation.li[i].country;
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = Convert.ToString(RegistrationValidation.li[i].age);
                td = new TextBox();
                td.ID = o++.ToString();
                PlaceHolder1.Controls.Add(td);
                td.Text = RegistrationValidation.li[i].gender;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/RegistrationValidation");
        }
    }
}