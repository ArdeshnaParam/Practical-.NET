using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MasterPages
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public Label LblHeader
        {
            get { return lblHeader; }
        }
        public Button BtnSearch
        {
            get { return btnSearch; }
        }
        public TextBox TxtSearch
        {
            get { return txtSearch; }
        }
    }
}