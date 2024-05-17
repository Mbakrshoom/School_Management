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
    public partial class teacher : Form
    {
        public teacher()
        {
            InitializeComponent();
        }
        void clear()
        {
            textid_tech.Clear();
            textname_tech.Clear();
            textphone_tech.Clear();
            
            textsalary_tech.Clear();
            textaddress_tech.Clear();



        }
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Teacher";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);

            DataSet sd = new DataSet();
            DataTable dt = new DataTable();


            try
            {
                con.Open();
                sda.Fill(sd);
                // dt = sd.Tables[0];
                dgv.DataSource = sd.Tables[0];


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                clear();
            }


        }

        private void button_add_tech_Click(object sender, EventArgs e)
        {
            if (textaddress_tech.Text == "" || textname_tech.Text == "" || comboGender_tech.Text == "" || combo_sub_teach.Text == "" || textphone_tech.Text == "" || textaddress_tech.Text == "" || textsalary_tech.Text == "")
            {
                MessageBox.Show("plaees fill all feild");
            }
            else
            {


                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO  Teacher(ID,Name,Gender,Subject,Phone,Address,Salary) Values(@1,@2,@3,@4,@5,@6,@7)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid_tech.Text));
                cmd.Parameters.AddWithValue("@2", textname_tech.Text);
                cmd.Parameters.AddWithValue("@3", comboGender_tech.Text);
                cmd.Parameters.AddWithValue("@4", combo_sub_teach.Text);

                cmd.Parameters.AddWithValue("@5", Convert.ToInt64(textphone_tech.Text));
                cmd.Parameters.AddWithValue("@6", textaddress_tech.Text);
                cmd.Parameters.AddWithValue("@7", Convert.ToInt64(textsalary_tech.Text));


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Add Teacher is succsefully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "has erroe in add teacher ", "Error_Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1teacher);
                    clear();

                }
            }
        }
        private void teacher_Load(object sender, EventArgs e)
        {
            fill_dgv(dgv1teacher);
        }

        private void button_update_tech_Click(object sender, EventArgs e)
        {
            if (textaddress_tech.Text == "" || textname_tech.Text == "" || comboGender_tech.Text == "" || combo_sub_teach.Text == "" || textphone_tech.Text == "" || textaddress_tech.Text == "" || textsalary_tech.Text == "")
            {
                MessageBox.Show("plaees fill all feild");
            }
            else
            {
                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                string sql = "Update Teacher set Name=@2,Gender=@3,Subject=@4,Phone=@5,Address=@6,Salary=@7 where ID=@1  ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid_tech.Text));
                cmd.Parameters.AddWithValue("@2", textname_tech.Text);
                cmd.Parameters.AddWithValue("@3", comboGender_tech.Text);
                cmd.Parameters.AddWithValue("@4", combo_sub_teach.Text);
                cmd.Parameters.AddWithValue("@5", Convert.ToInt64(textphone_tech.Text));
                cmd.Parameters.AddWithValue("@6", textaddress_tech.Text);
                cmd.Parameters.AddWithValue("@7", Convert.ToInt64(textsalary_tech.Text));
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update teacher is successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Has Erroe in update Teacher", "Teacher _update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1teacher);
                    clear();
                }
            }
        }

        private void button_delete_tech_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "Delete from Teacher where ID=@1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid_tech.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("delet teacher is successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"Has Error in Delete Teacher","Teacher Delete",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                fill_dgv(dgv1teacher);
                clear();
            }
        }

        private void textsearch_tech_TextChanged(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * FROM Teacher WHERE Name LIKE '%" + textsearch_tech.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", textsearch_tech.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
                dgv1teacher.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"Has Error in Search Teacher","Teacher Search",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void dgv1teacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv1teacher_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.SkyBlue;
            }
        
    }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv1teacher_Click(object sender, EventArgs e)
        {
            textid_tech.Text = dgv1teacher.CurrentRow.Cells[0].Value.ToString();
            textname_tech.Text = dgv1teacher.CurrentRow.Cells[1].Value.ToString();
            comboGender_tech.SelectedItem = dgv1teacher.CurrentRow.Cells[2].Value.ToString();
            combo_sub_teach.SelectedItem = dgv1teacher.CurrentRow.Cells[3].Value.ToString();
            textphone_tech.Text = dgv1teacher.CurrentRow.Cells[4].Value.ToString();
            textaddress_tech.Text = dgv1teacher.CurrentRow.Cells[5].Value.ToString();
            textsalary_tech.Text = dgv1teacher.CurrentRow.Cells[6].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            Mainform mn=new Mainform();
            mn.Show();
            this.Hide();
        }
    }
}
