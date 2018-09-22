using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P21Sept2018_RegistrationValidation
{
    public partial class RegistrationValidation : System.Web.UI.Page
    {
        public static List<dataStore> li = new List<dataStore>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        dataStore ds = new dataStore();
       
        protected void Submit_Click(object sender, EventArgs e)
        {
            ds.firstname = fname.Text;
            ds.lastname = lname.Text;
            ds.age = Convert.ToInt32(yourage.Text);
            ds.mobilenumber = Convert.ToDouble(mnum.Text);
            ds.dob = Convert.ToString(birthdate.Text);
            ds.gender = RadioButtonList1.Text;
            ds.country = DropDownList1.Text;

            li.Add(ds);

            Response.Redirect("~/displayData.aspx");

        }
    }
}