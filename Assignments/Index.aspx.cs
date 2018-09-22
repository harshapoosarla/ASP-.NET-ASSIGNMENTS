using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignments
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        string firstname;
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            firstname = TextBox1.Text;
        }
        string lastname;
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            lastname = TextBox2.Text;
        }
        int age;
        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            age = Convert.ToInt32(TextBox3.Text);
        }
        double mobilenumber;
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            mobilenumber = Convert.ToDouble(TextBox4.Text);
        }
        DateTime dob;
        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            dob = Convert.ToDateTime(TextBox5);
        }
        DropDownList gender;
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = DropDownList1;
        }
        DropDownList country;
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            country = DropDownList2;
        }
        List<object> li = new List<object>();
        protected void Button1_Click(object sender, EventArgs e)
        {
            li.Add(firstname);
            li.Add(lastname);
            li.Add(age);
            li.Add(mobilenumber);
            li.Add(dob);
            li.Add(gender);
            li.Add(country);
        }
    }
}