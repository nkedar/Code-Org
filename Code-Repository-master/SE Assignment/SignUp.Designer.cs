﻿namespace SE_Assignment
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passSignUp = new System.Windows.Forms.TextBox();
            this.passConf = new System.Windows.Forms.TextBox();
            this.signUpConfirm = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.unameSignUp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secQueDrop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.secAnsBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(294, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Confirm password";
            this.label6.Click += new System.EventHandler(this.Label1_Click);
            // 
            // passSignUp
            // 
            this.passSignUp.Location = new System.Drawing.Point(439, 102);
            this.passSignUp.Name = "passSignUp";
            this.passSignUp.PasswordChar = '*';
            this.passSignUp.Size = new System.Drawing.Size(311, 20);
            this.passSignUp.TabIndex = 1;
            this.passSignUp.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // passConf
            // 
            this.passConf.Location = new System.Drawing.Point(439, 154);
            this.passConf.Name = "passConf";
            this.passConf.PasswordChar = '*';
            this.passConf.Size = new System.Drawing.Size(311, 20);
            this.passConf.TabIndex = 1;
            this.passConf.TextChanged += new System.EventHandler(this.TextBox6_TextChanged);
            // 
            // signUpConfirm
            // 
            this.signUpConfirm.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.signUpConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpConfirm.Location = new System.Drawing.Point(363, 361);
            this.signUpConfirm.Name = "signUpConfirm";
            this.signUpConfirm.Size = new System.Drawing.Size(172, 51);
            this.signUpConfirm.TabIndex = 2;
            this.signUpConfirm.Text = "Confirm";
            this.signUpConfirm.UseVisualStyleBackColor = true;
            this.signUpConfirm.Click += new System.EventHandler(this.Button1_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(567, 361);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(172, 51);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.BttnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(347, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            this.label7.Click += new System.EventHandler(this.Label1_Click);
            // 
            // unameSignUp
            // 
            this.unameSignUp.Location = new System.Drawing.Point(439, 50);
            this.unameSignUp.Name = "unameSignUp";
            this.unameSignUp.Size = new System.Drawing.Size(311, 20);
            this.unameSignUp.TabIndex = 1;
            this.unameSignUp.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 270);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // secQueDrop
            // 
            this.secQueDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secQueDrop.FormattingEnabled = true;
            this.secQueDrop.Items.AddRange(new object[] {
            "What is the name of your first pet?",
            "What was your mother\'s maiden name?",
            "In what country were you born?",
            "Who is the artist of your favorite song?"});
            this.secQueDrop.Location = new System.Drawing.Point(439, 207);
            this.secQueDrop.Name = "secQueDrop";
            this.secQueDrop.Size = new System.Drawing.Size(311, 21);
            this.secQueDrop.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Question";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // secAnsBox
            // 
            this.secAnsBox.Location = new System.Drawing.Point(439, 260);
            this.secAnsBox.Name = "secAnsBox";
            this.secAnsBox.Size = new System.Drawing.Size(311, 20);
            this.secAnsBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secAnsBox);
            this.Controls.Add(this.secQueDrop);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.signUpConfirm);
            this.Controls.Add(this.unameSignUp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.passConf);
            this.Controls.Add(this.passSignUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passSignUp;
        private System.Windows.Forms.TextBox passConf;
        private System.Windows.Forms.Button signUpConfirm;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox unameSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox secQueDrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox secAnsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
