namespace archivingsystemshits
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignin = new System.Windows.Forms.Button();
            this.btnsignup2 = new System.Windows.Forms.Button();
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCreatepass = new System.Windows.Forms.TextBox();
            this.pnlbg = new System.Windows.Forms.Panel();
            this.checkboxSignup = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlbg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = Properties.Resources._2e4b0a5c_6a5d_4e8f_9f77_8bd7d660ab2b;
            this.pictureBox1.Location = new System.Drawing.Point(26, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1552, 981);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSignin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.Maroon;
            this.btnSignin.Location = new System.Drawing.Point(992, 309);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(282, 46);
            this.btnSignin.TabIndex = 1;
            this.btnSignin.Text = "Sign In ";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnsignup1_Click_1);
            // 
            // btnsignup2
            // 
            this.btnsignup2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsignup2.BackColor = System.Drawing.Color.Maroon;
            this.btnsignup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup2.ForeColor = System.Drawing.Color.White;
            this.btnsignup2.Location = new System.Drawing.Point(919, 791);
            this.btnsignup2.Name = "btnsignup2";
            this.btnsignup2.Size = new System.Drawing.Size(443, 49);
            this.btnsignup2.TabIndex = 2;
            this.btnsignup2.Text = "Sign Up";
            this.btnsignup2.UseVisualStyleBackColor = false;
            this.btnsignup2.Click += new System.EventHandler(this.btnsignup2_Click_1);
            // 
            // txtEnterName
            // 
            this.txtEnterName.Location = new System.Drawing.Point(924, 503);
            this.txtEnterName.Multiline = true;
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(420, 52);
            this.txtEnterName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(924, 593);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(420, 43);
            this.txtEmail.TabIndex = 4;
            // 
            // txtCreatepass
            // 
            this.txtCreatepass.Location = new System.Drawing.Point(924, 678);
            this.txtCreatepass.Multiline = true;
            this.txtCreatepass.Name = "txtCreatepass";
            this.txtCreatepass.Size = new System.Drawing.Size(420, 44);
            this.txtCreatepass.TabIndex = 5;
            // 
            // pnlbg
            // 
            this.pnlbg.BackColor = System.Drawing.Color.Transparent;
            this.pnlbg.Controls.Add(this.txtEmail);
            this.pnlbg.Controls.Add(this.txtCreatepass);
            this.pnlbg.Controls.Add(this.txtEnterName);
            this.pnlbg.Controls.Add(this.checkboxSignup);
            this.pnlbg.Controls.Add(this.btnSignin);
            this.pnlbg.Controls.Add(this.btnsignup2);
            this.pnlbg.Controls.Add(this.pictureBox1);
            this.pnlbg.Location = new System.Drawing.Point(-53, -138);
            this.pnlbg.Name = "pnlbg";
            this.pnlbg.Size = new System.Drawing.Size(1520, 1095);
            this.pnlbg.TabIndex = 7;
            this.pnlbg.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbg_Paint);
            // 
            // checkboxSignup
            // 
            this.checkboxSignup.AutoSize = true;
            this.checkboxSignup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkboxSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxSignup.Location = new System.Drawing.Point(924, 733);
            this.checkboxSignup.Name = "checkboxSignup";
            this.checkboxSignup.Size = new System.Drawing.Size(106, 17);
            this.checkboxSignup.TabIndex = 6;
            this.checkboxSignup.Text = "Remember Me";
            this.checkboxSignup.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 790);
            this.Controls.Add(this.pnlbg);
            this.Name = "SignUp";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlbg.ResumeLayout(false);
            this.pnlbg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSignin;
        private System.Windows.Forms.Button btnsignup2;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCreatepass;
        private System.Windows.Forms.Panel pnlbg;
        private System.Windows.Forms.CheckBox checkboxSignup;
    }
}

