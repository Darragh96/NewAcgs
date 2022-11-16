using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ACGS
{
    public partial class Form2 : Form
    {

        //Sqlconnection con = new Sqlconnection("Data Source = ; Initial Catalog= ACGS; Integrated Security = True");
        //SqlCommand cmd;
        //SqlDataReader dr;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPass_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("select * from users where username=@username and userpass =@userpass", con);
            cmd.Parameters.AddWithValue("@username", txtName.Text);
            cmd.Parameters.AddWithValue("@userpass", txtPass.Text);

            con.Open();

            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                Hide();//this form
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Login Failure, Try Again!");
            }

            con.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
