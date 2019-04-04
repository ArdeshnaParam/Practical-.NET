using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        serviceCalc.WebService1 calc = new serviceCalc.WebService1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.add(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.sub(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.mult(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            lblResult.Text = calc.div(Convert.ToInt16(txtA.Text), Convert.ToInt16(txtB.Text)).ToString();
        }
    }
}