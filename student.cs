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
    public partial class student : Form
    {
        public student()
        {
            InitializeComponent();
        }
        void clear()
        {
            textid.Clear();
            textname.Clear();
            textphone.Clear();
            textaddress.Clear();
           

            


        }
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Student";
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
            }


        }

        private void label9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textid.Text == "" || textname.Text == "" || comboGender.Text== "" || datetime.Text == "" || textphone.Text == "" || textaddress.Text == ""  || combo_class.Text == "")
            {
                MessageBox.Show("Plaees fill all field");
            }
            else
            {


                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO  Student(ID,Name,Gender,Date,Phone,Address,Class) Values(@1,@2,@3,@4,@5,@6,@7)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid.Text));
                cmd.Parameters.AddWithValue("@2", textname.Text);
                cmd.Parameters.AddWithValue("@3", comboGender.Text);
                cmd.Parameters.AddWithValue("@4", Convert.ToDateTime(datetime.Text));
                cmd.Parameters.AddWithValue("@5", Convert.ToInt64(textphone.Text));
                cmd.Parameters.AddWithValue("@6", textaddress.Text);
             
                cmd.Parameters.AddWithValue("@7", (combo_class.Text));



                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" insert is done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1student);
                    clear();

                }
            }
        }

        private void student_Load(object sender, EventArgs e)
        {
            fill_dgv(dgv1student);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textid.Text == "" || textname.Text == "" || comboGender.Text == "" || datetime.Text == "" || textphone.Text == "" || textaddress.Text == "" ||  combo_class.Text == "")
            {
                MessageBox.Show("Plaees fill all field");
            }
            else
            {
                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                string sql = "UPDATE Student SET Name=@2,Gender=@3,Date=@4,Phone=@5,Address=@6, Class=@7  WHERE ID=@1  ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid.Text));
                cmd.Parameters.AddWithValue("@2", textname.Text);
                cmd.Parameters.AddWithValue("@3", comboGender.Text);
                cmd.Parameters.AddWithValue("@4", Convert.ToDateTime(datetime.Text));
                cmd.Parameters.AddWithValue("@5", Convert.ToInt64(textphone.Text));
                cmd.Parameters.AddWithValue("@6", textaddress.Text);
              
                cmd.Parameters.AddWithValue("@7", combo_class.Text);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update is successfully", "update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1student);
                    clear();
                }
            }
        }

        private void dgv1student_Click(object sender, EventArgs e)
        {

            textid.Text = dgv1student.CurrentRow.Cells[0].Value.ToString();
            textname.Text = dgv1student.CurrentRow.Cells[1].Value.ToString();
            comboGender.Text = dgv1student.CurrentRow.Cells[2].Value.ToString();
            datetime.Text = dgv1student.CurrentRow.Cells[3].Value.ToString();
            textphone.Text = dgv1student.CurrentRow.Cells[4].Value.ToString();
            textaddress.Text = dgv1student.CurrentRow.Cells[5].Value.ToString();
            
            combo_class.Text = dgv1student.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "Delete from Student where ID=@1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete is successfully","Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                fill_dgv(dgv1student);
                clear();
            }
        }

        private void dgv1student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * FROM Student WHERE Name LIKE '%" + textsearch.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", textsearch.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
          
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
                dgv1student.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void dgv1student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1student_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
