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
    public partial class Marks : Form
    {

       


        public Marks()
        {
            InitializeComponent();





        }
        
        void clear()
        {
           // textid_std_mraks.Clear();
            textname_std_mraks.Clear();
            textQuran_std_mraks.Clear();
            islamic_std_mraks.Clear();
            arbic_std_mraks.Clear();
            english_std_mraks.Clear();
            history_std_mraks.Clear();
            maths_std_mraks.Clear();
            scines_std_mraks.Clear();
            textsearch_marks.Clear();
            textBox_avg.Clear();
            text_total.Clear();

  


        }
        void fill_dgv(DataGridView dgv)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            String sql = "select * from Marks";
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

            private void pictureback_Click(object sender, EventArgs e)
        {
            Mainform mn = new Mainform();
            mn.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button_add_marks_Click(object sender, EventArgs e)
        {
            if (textQuran_std_mraks.Text == "" || islamic_std_mraks.Text == "" || arbic_std_mraks.Text == "" || english_std_mraks.Text == "" || history_std_mraks.Text == "" || maths_std_mraks.Text == "" || scines_std_mraks.Text == "" || text_total.Text == "" || textBox_avg.Text=="")
            {
                MessageBox.Show("please fill all feild");
            }
            else
            {


                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                String sql = "INSERT INTO  Marks(ID,Student_Name,Class,Quran,Isalmic,Arbic,English,History,Maths,Scines,Total,Avg) Values(@1,@2,@3,@4,@5,@6,@7,@8,@9,@10,@11,@12)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id.Text));
                cmd.Parameters.AddWithValue("@2", textname_std_mraks.Text);
                cmd.Parameters.AddWithValue("@3", combo_class_std_mraks.Text);
                cmd.Parameters.AddWithValue("@4", Convert.ToInt16(textQuran_std_mraks.Text));
                cmd.Parameters.AddWithValue("@5", Convert.ToInt16(islamic_std_mraks.Text));
                cmd.Parameters.AddWithValue("@6", Convert.ToInt16(arbic_std_mraks.Text));
                cmd.Parameters.AddWithValue("@7", Convert.ToInt16(english_std_mraks.Text));
                cmd.Parameters.AddWithValue("@8", Convert.ToInt16(history_std_mraks.Text));
                cmd.Parameters.AddWithValue("@9", Convert.ToInt16(maths_std_mraks.Text));
                cmd.Parameters.AddWithValue("@10", Convert.ToInt16(scines_std_mraks.Text));
                cmd.Parameters.AddWithValue("@11", Convert.ToInt16(text_total.Text));
                cmd.Parameters.AddWithValue("@12", Convert.ToInt16(textBox_avg.Text));









                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Insert Marks is done");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error to insert Marks", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1_marks);
                    clear();

                }
            }
        }

        private void Marks_Load(object sender, EventArgs e)
        {
            fill_dgv(dgv1_marks);

            SqlConnection con = new SqlConnection(@"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True");
            SqlDataAdapter sda;
            DataTable dt = new DataTable();
            

            sda = new SqlDataAdapter("SELECT * FROM Student ", con);
            sda.Fill(dt);
            combo_id.DataSource = dt;
            combo_id.DisplayMember = "ID";
            combo_id.ValueMember = "ID";

        }

        private void button_update_marks_Click(object sender, EventArgs e)
        {
            if (textQuran_std_mraks.Text == "" || islamic_std_mraks.Text == "" || arbic_std_mraks.Text == "" || english_std_mraks.Text == "" || history_std_mraks.Text == "" || maths_std_mraks.Text == "" || scines_std_mraks.Text == "" || text_total.Text == "")
            {
                MessageBox.Show("please fill all feild");
            }
            else
            {
                String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
                SqlConnection con = new SqlConnection(conString);
                string sql = "UPDATE Marks SET Student_Name=@2,Class=@3,Quran=@4,Isalmic=@5,Arbic=@6,English=@7 ,History=@8,Maths=@9 ,Scines=@10,Total=@11 ,Avg=@12  WHERE ID=@1  ";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id.Text));
                cmd.Parameters.AddWithValue("@2", textname_std_mraks.Text);
                cmd.Parameters.AddWithValue("@3", combo_class_std_mraks.Text);
                cmd.Parameters.AddWithValue("@4", Convert.ToInt16(textQuran_std_mraks.Text));
                cmd.Parameters.AddWithValue("@5", Convert.ToInt16(islamic_std_mraks.Text));
                cmd.Parameters.AddWithValue("@6", Convert.ToInt16(arbic_std_mraks.Text));
                cmd.Parameters.AddWithValue("@7", Convert.ToInt16(english_std_mraks.Text));
                cmd.Parameters.AddWithValue("@8", Convert.ToInt16(history_std_mraks.Text));
                cmd.Parameters.AddWithValue("@9", Convert.ToInt16(maths_std_mraks.Text));
                cmd.Parameters.AddWithValue("@10", Convert.ToInt16(scines_std_mraks.Text));
                cmd.Parameters.AddWithValue("@11", Convert.ToInt16(text_total.Text));
                cmd.Parameters.AddWithValue("@12", Convert.ToInt16(textBox_avg.Text));


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("update succsufilly");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "Error to update Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    fill_dgv(dgv1_marks);
                    clear();
                }
            }
        }

        private void button_delete_marks_Click(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "Delete from Marks where ID=@1 ";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(combo_id.Text));


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delte is done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex +"Error delete Marks","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                fill_dgv(dgv1_marks);
            }
        }

        private void textsearch_marks_TextChanged(object sender, EventArgs e)
        {
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * FROM Marks WHERE Student_Name LIKE '%" + textsearch_marks.Text + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@1", textsearch_marks.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                sda.Fill(dt);
                dgv1_marks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"has error in Search data","Search",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void Marks_Click(object sender, EventArgs e)
        {
            
        }

        private void dgv1_marks_Click(object sender, EventArgs e)
        {
            combo_id.Text = dgv1_marks.CurrentRow.Cells[0].Value.ToString();
            textname_std_mraks.Text = dgv1_marks.CurrentRow.Cells[1].Value.ToString();
            combo_class_std_mraks.Text = dgv1_marks.CurrentRow.Cells[2].Value.ToString();
            textQuran_std_mraks.Text = dgv1_marks.CurrentRow.Cells[3].Value.ToString();
            islamic_std_mraks.Text = dgv1_marks.CurrentRow.Cells[4].Value.ToString();
            arbic_std_mraks.Text = dgv1_marks.CurrentRow.Cells[5].Value.ToString();
            english_std_mraks.Text = dgv1_marks.CurrentRow.Cells[6].Value.ToString();
            history_std_mraks.Text = dgv1_marks.CurrentRow.Cells[7].Value.ToString();
            maths_std_mraks.Text = dgv1_marks.CurrentRow.Cells[8].Value.ToString();
            scines_std_mraks.Text = dgv1_marks.CurrentRow.Cells[9].Value.ToString();
            text_total.Text = dgv1_marks.CurrentRow.Cells[10].Value.ToString();
            text_total.Text = dgv1_marks.CurrentRow.Cells[10].Value.ToString();
            textBox_avg.Text = dgv1_marks.CurrentRow.Cells[11].Value.ToString();
        }

        private void dgv1_marks_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
                   
        }

        private void dgv1_marks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.RowIndex % 2==0)
            {
                e.CellStyle.BackColor = Color.SkyBlue;
            }
        }

        private void dgv1_marks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textid_std_mraks_TextChanged(object sender, EventArgs e)
        {/*
            String conString = @"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True";
            SqlConnection con = new SqlConnection(conString);
            string sql = "SELECT * FROM Student WHERE ID LIKE @1";
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@1", Convert.ToInt32(textid_std_mraks.Text));
            try
            {
                con.Open();
                // datareder تستخدم مع الاتصال بقاعدة البيانات   في وقت الاتصال
                //dataAdapter تستخدم لجلب البيانات لاعندك وتعمل بدون اتصال
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {    
                    textname_std_mraks.Text = sdr["Name"].ToString();
                    combo_class_std_mraks.Text = sdr["Class"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            } */
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = HUAWEI;  Initial Catalog =school; Integrated Security = True");
            SqlDataAdapter sda;
           
            DataTable dt2 = new DataTable();



            try
            {
              
                
              
                
                 sda = new SqlDataAdapter("SELECT * FROM Student WHERE ID = '"+Convert.ToInt32 ( combo_id.Text)+"' ",con);
               dt2.Clear();
                sda.Fill(dt2);
                textname_std_mraks.Text = dt2.Rows[0]["Name"].ToString();
                combo_class_std_mraks.Text = dt2.Rows[0]["Class"].ToString();



            }
            catch (Exception ex)
            {
                return;
            }
           

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void text_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
          
            
        }

        private void text_total_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button_cal_Click(object sender, EventArgs e)
        {
            if (textQuran_std_mraks.Text == "" || islamic_std_mraks.Text == "" || arbic_std_mraks.Text == "" || english_std_mraks.Text == "" || history_std_mraks.Text == "" || maths_std_mraks.Text == "" || scines_std_mraks.Text == "" )
            {
                MessageBox.Show("please fill all feild");
            }
            else
            {
                int total, avg;
                int qu = Convert.ToInt16(textQuran_std_mraks.Text);
                int isl = Convert.ToInt16(islamic_std_mraks.Text);
                int arb = Convert.ToInt16(arbic_std_mraks.Text);
                int en = Convert.ToInt16(english_std_mraks.Text);
                int hs = Convert.ToInt16(history_std_mraks.Text);
                int mt = Convert.ToInt16(maths_std_mraks.Text);
                int sc = Convert.ToInt16(scines_std_mraks.Text);
                total = qu + isl + arb + en + hs + mt + sc;

                text_total.Text = total.ToString();
                avg = total / 7;
                textBox_avg.Text = avg.ToString();
            }
        }
    }
}
