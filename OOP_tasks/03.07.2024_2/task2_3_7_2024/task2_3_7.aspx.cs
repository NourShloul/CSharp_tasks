using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task2_3_7_2024
{
    public partial class task2_3_7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double sum = num1 * num2;

            Label1.Text = sum.ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double sum = num1 + num2;

            Label1.Text = sum.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(TextBox1.Text);
            double num2 = Convert.ToDouble(TextBox2.Text);
            double sum = num1 - num2;

            Label1.Text = sum.ToString();

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}