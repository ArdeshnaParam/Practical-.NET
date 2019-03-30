using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace MasterPages
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ((Site1)Master).BtnSearch.Click += new EventHandler(BtnSearch_Click);
            
        }

        void BtnSearch_Click(object sender, EventArgs e)
        {
            getData();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        void getData()
        {
            String source = @"Data Source=mycomputer\sqlexpress;Initial Catalog=DBstudent;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(source);
            String search = ((Site1)Master).TxtSearch.Text;
            String query = "select * from tblStudent where fname like '%"+search+"%'";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            grdStudent.DataSource = reader;
            grdStudent.DataBind();
            conn.Close();
        }

    }
}