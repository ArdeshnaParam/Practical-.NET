using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            String gender;
            if (rdoMale.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            String source = @"Data Source=mycomputer\sqlexpress;Initial Catalog=DBstudent;Integrated Security=True;Pooling=False";
            String select = "select count(*) from tblStudent;";
            SqlConnection conn=new SqlConnection(source);
            SqlCommand cmd=new SqlCommand(select,conn);
            conn.Open();
            int i=Convert.ToInt32(cmd.ExecuteScalar());
            int pkStudent=i+1;
            string insert="insert into tblStudent(pkStudent,fname,mname,lname,dob,Address,email,Father_name,Mother_name,Mobile_Number,Gender) values("+pkStudent+",'"+txtFirstName.Text+"','"+txtMiddleName.Text+"','"+txtLastName.Text+"','"+datepickDOB.Value.Date+"','"+txtAddress.Text+"','"+txtEmail.Text+"','"+txtFatherName.Text+"','"+txtMotherName.Text+"',"+txtMobNo.Text+",'"+gender+"')";
            cmd= new SqlCommand(insert,conn);
            int a= cmd.ExecuteNonQuery();
            MessageBox.Show("You are Done");
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
                openFileDialog1.Filter = "Jpg|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String imgPath;
                imgPath = @"F:\16ce043\StudentRegistrationForm"+ openFileDialog1.SafeFileName;
                imgStudent.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdoMale.Checked = true;
        }

    }
}
