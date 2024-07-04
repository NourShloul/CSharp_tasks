using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TaskOnsite
{
    public partial class TaskOnsite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            Label7.Text = name;
            string email = Email.Text;
            Label8.Text = email;
            string id = Id.Text;
            Label9.Text = id;




            if (RadioOption1.Checked)
            {
                Label10.Text = RadioOption1.Text;
            }
            if (RadioOption2.Checked)
            {
                Label11.Text = RadioOption2.Text;

            }
            if (CheckBox1.Checked) { Label1.Text = CheckBox1.Text; }
            if (CheckBox2.Checked) { Label13.Text = CheckBox2.Text; }
            if (CheckBox3.Checked) { Label14.Text = CheckBox3.Text; }
        }

    }
}