using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorConsumer
{
    public partial class Index : System.Web.UI.Page
    {
        //create an instance of an web services

        MyCalculator.CalService c1;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            c1 = new MyCalculator.CalService();
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            txtResult.Text=c1.Add(a,b).ToString();

        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            c1 = new MyCalculator.CalService();
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            txtResult.Text = c1.Sub(a, b).ToString();

        }

        protected void btnMul_Click(object sender, EventArgs e)
        {
            c1 = new MyCalculator.CalService();
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            txtResult.Text = c1.Mul(a, b).ToString();

        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {
            c1 = new MyCalculator.CalService();
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);

            txtResult.Text = c1.Div(a, b).ToString();

        }
    }
}