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

namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void but_log_singup_Click(object sender, EventArgs e)
        {
            singup singup = new singup();
            singup.Show();
            this.Hide();
        }

        private void check_login_CheckedChanged(object sender, EventArgs e)
        {
            text_log_pass.PasswordChar = check_login.Checked ? '\0' : '*';
        }

        private void but_log_login_Click(object sender, EventArgs e)
        {






            string constring = @"Data Source = HUAWEI; Initial Catalog = school; Integrated Security = True";
            SqlConnection con = new SqlConnection(constring);
            string sql = "select count(*) from users where UserName=@1 and Password=@2";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", text_log_username.Text);
            cmd.Parameters.AddWithValue("@2", text_log_pass.Text);
            if(text_log_username.Text==""|| text_log_pass.Text=="")
            {
                MessageBox.Show("please fill all this feild");
            }
            else
            {

            
            try
            {
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    Mainform mn = new Mainform();
                    mn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("username or password invaldine");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            }


        }
    }
}
