using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            
            
                Application.Exit();
            

        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student sd=new student();
            sd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacher teacher = new teacher();
            teacher.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 loginform1 = new Form1();
            loginform1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Marks mr=new Marks();   
            mr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Fees fr=new Fees();
            fr.Show();
            this.Hide();
        }
    }
}
