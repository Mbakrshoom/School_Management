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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
           
        }
        void clear()
        {
            textname_std_fees.Clear();
            textfees.Clear();
            textsearch_fees.Clear();





        }
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Fees";
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {
            fill_dgv(dgv1_Fees);

            SqlConnection con = new SqlConnection(@"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True");
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
           
            sda = new SqlDataAdapter("SELECT * FROM Student ", con);
            sda.Fill(dt);
            combo_id_stud_fees.DataSource = dt;
            combo_id_stud_fees.DisplayMember = "ID";
            combo_id_stud_fees.ValueMember = "ID";


        }

        private void button_add_marks_Click(object sender, EventArgs e)
        {
            if (combo_id_stud_fees.Text == "" || textname_std_fees.Text == "" || datetime_fees.Text == "" || textfees.Text == "")
            {
                MessageBox.Show("Plaees fill all field");
            }
            else
            {


                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO  Fees(Id,name,date,fees) Values(@1,@2,@3,@4)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id_stud_fees.Text));
                cmd.Parameters.AddWithValue("@2", textname_std_fees.Text);
                cmd.Parameters.AddWithValue("@3", Convert.ToDateTime(datetime_fees.Text));
                cmd.Parameters.AddWithValue("@4", Convert.ToInt64(textfees.Text));



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
                    fill_dgv(dgv1_Fees);
                    clear();

                }
            }
        }

        private void button_update_marks_Click(object sender, EventArgs e)
        {
            if (combo_id_stud_fees.Text == "" || textname_std_fees.Text == "" || datetime_fees.Text == "" || textfees.Text == "")
            {
                MessageBox.Show("Plaees fill all field");
            }
            else
            {


                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                string sql = "UPDATE Fees SET name=@2, date=@3 , fees=@4 WHERE id=@1 ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id_stud_fees.Text));
                cmd.Parameters.AddWithValue("@2", textname_std_fees.Text);
                cmd.Parameters.AddWithValue("@3", Convert.ToDateTime(datetime_fees.Text));
                cmd.Parameters.AddWithValue("@4", Convert.ToInt64(textfees.Text));

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" update is done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1_Fees);
                    clear();

                }
            }
        }

        private void button_delete_marks_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "Delete from Fees where Id=@1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id_stud_fees.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delte is done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "Error delete fees", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                fill_dgv(dgv1_Fees);
            }
        }

        private void textsearch_fees_TextChanged(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * FROM Fees WHERE name LIKE '%" + textsearch_fees.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", textsearch_fees.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
                dgv1_Fees.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "has error in Search data", "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void combo_id_stud_fees_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True");
            SqlDataAdapter sda;
           
            DataTable dt2 = new DataTable();


            try
            {




                sda = new SqlDataAdapter("SELECT * FROM Student WHERE ID = '" + Convert.ToInt32(combo_id_stud_fees.Text) + "' ", con);
                dt2.Clear();
                sda.Fill(dt2);
                textname_std_fees.Text = dt2.Rows[0]["Name"].ToString();
               



            }
            catch
            {
               
            }
        }

        private void dgv1_Fees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_Fees_Click(object sender, EventArgs e)
        {
            combo_id_stud_fees.Text = dgv1_Fees.CurrentRow.Cells[0].Value.ToString();
            textname_std_fees.Text = dgv1_Fees.CurrentRow.Cells[1].Value.ToString();
            datetime_fees.Text = dgv1_Fees.CurrentRow.Cells[2].Value.ToString();
            textfees.Text = dgv1_Fees.CurrentRow.Cells[3].Value.ToString();
        }

        private void pictureback_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }

        private void dgv1_Fees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.SkyBlue;
            }
        }
    }

}