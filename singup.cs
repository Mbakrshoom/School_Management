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
    public partial class singup : Form
    {
      
        public singup()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void singin_sing_Click(object sender, EventArgs e)
        {
            Form1 loginform1 = new Form1();
            loginform1.Show();
            this.Hide();
           
        }

        private void check_singup_CheckedChanged(object sender, EventArgs e)
        {
            text_sing_pass.PasswordChar = check_singup.Checked ? '\0' : '*';
        }

        private void text_sing_pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void but_sing_singup_Click(object sender, EventArgs e)
        {
            if (text_sing_username.Text == "" || text_sing_pass.Text == "")
            {
                MessageBox.Show("please fill all feild");
            }
            else
            {
                string constring = @"Data Source = HUAWEI; Initial Catalog = school; Integrated Security = True";
                SqlConnection con = new SqlConnection(constring);
                string sql = "select count(*) from users where UserName=@1 and Password=@2";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", text_sing_username.Text);
                cmd.Parameters.AddWithValue("@2", text_sing_pass.Text);
                try
                {
                    con.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("chose another username or password");
                    }

                    else
                    {
                        if (text_sing_username.Text == "" || text_sing_pass.Text == "")
                        {
                            MessageBox.Show("please fill all feild");
                        }
                        else
                        {
                            sql = "insert into users (UserName,Password) values (@1,@2)";
                            SqlCommand cmd2 = new SqlCommand(sql, con);
                            cmd2.Parameters.AddWithValue("@1", text_sing_username.Text);
                            cmd2.Parameters.AddWithValue("@2", text_sing_pass.Text);
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("sing up is sucssfully ");


                        }


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

