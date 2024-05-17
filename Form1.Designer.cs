namespace SchoolManagementSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_log_username = new System.Windows.Forms.TextBox();
            this.text_log_pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.but_log_login = new System.Windows.Forms.Button();
            this.check_login = new System.Windows.Forms.CheckBox();
            this.but_log_singup = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 461);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SchoolManagementSystem.Properties.Resources._1701104993404;
            this.pictureBox1.Location = new System.Drawing.Point(30, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(44, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "School Management System";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.label1.Location = new System.Drawing.Point(493, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(681, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(22, 24);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.label3.Location = new System.Drawing.Point(364, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "UserName:";
            // 
            // text_log_username
            // 
            this.text_log_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_log_username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_log_username.Location = new System.Drawing.Point(368, 137);
            this.text_log_username.Multiline = true;
            this.text_log_username.Name = "text_log_username";
            this.text_log_username.Size = new System.Drawing.Size(310, 36);
            this.text_log_username.TabIndex = 1;
            // 
            // text_log_pass
            // 
            this.text_log_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.text_log_pass.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_log_pass.Location = new System.Drawing.Point(368, 220);
            this.text_log_pass.Multiline = true;
            this.text_log_pass.Name = "text_log_pass";
            this.text_log_pass.PasswordChar = '*';
            this.text_log_pass.Size = new System.Drawing.Size(310, 36);
            this.text_log_pass.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.label4.Location = new System.Drawing.Point(364, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password:";
            // 
            // but_log_login
            // 
            this.but_log_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_log_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_login.FlatAppearance.BorderSize = 5;
            this.but_log_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_log_login.ForeColor = System.Drawing.Color.White;
            this.but_log_login.Location = new System.Drawing.Point(368, 332);
            this.but_log_login.Name = "but_log_login";
            this.but_log_login.Size = new System.Drawing.Size(310, 41);
            this.but_log_login.TabIndex = 4;
            this.but_log_login.Text = "LOGIN";
            this.but_log_login.UseVisualStyleBackColor = false;
            this.but_log_login.Click += new System.EventHandler(this.but_log_login_Click);
            // 
            // check_login
            // 
            this.check_login.AutoSize = true;
            this.check_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.check_login.Location = new System.Drawing.Point(552, 262);
            this.check_login.Name = "check_login";
            this.check_login.Size = new System.Drawing.Size(126, 21);
            this.check_login.TabIndex = 3;
            this.check_login.Text = "Show password";
            this.check_login.UseVisualStyleBackColor = true;
            this.check_login.CheckedChanged += new System.EventHandler(this.check_login_CheckedChanged);
            // 
            // but_log_singup
            // 
            this.but_log_singup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_singup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.but_log_singup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_singup.FlatAppearance.BorderSize = 0;
            this.but_log_singup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_singup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(136)))));
            this.but_log_singup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_log_singup.ForeColor = System.Drawing.Color.White;
            this.but_log_singup.Location = new System.Drawing.Point(368, 393);
            this.but_log_singup.Name = "but_log_singup";
            this.but_log_singup.Size = new System.Drawing.Size(310, 41);
            this.but_log_singup.TabIndex = 5;
            this.but_log_singup.Text = "SING UP";
            this.but_log_singup.UseVisualStyleBackColor = false;
            this.but_log_singup.Click += new System.EventHandler(this.but_log_singup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 461);
            this.Controls.Add(this.but_log_singup);
            this.Controls.Add(this.check_login);
            this.Controls.Add(this.but_log_login);
            this.Controls.Add(this.text_log_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_log_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_log_pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button but_log_login;
        private System.Windows.Forms.CheckBox check_login;
        private System.Windows.Forms.Button but_log_singup;
        private System.Windows.Forms.TextBox text_log_username;
    }
}

