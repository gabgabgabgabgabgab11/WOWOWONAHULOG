namespace archivingsystemshits
{
    partial class loginsignup
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnSignIn2 = new System.Windows.Forms.Button();
            this.txtEmailAdd = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkboxRememberme = new System.Windows.Forms.CheckBox();
            this.PNLlogin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PNLlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignIn
            // 
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.Maroon;
            this.btnSignIn.Location = new System.Drawing.Point(1308, 313);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(305, 66);
            this.btnSignIn.TabIndex = 1;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(1629, 313);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(285, 66);
            this.btnSignUp.TabIndex = 2;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // btnSignIn2
            // 
            this.btnSignIn2.BackColor = System.Drawing.Color.Maroon;
            this.btnSignIn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSignIn2.Location = new System.Drawing.Point(1308, 817);
            this.btnSignIn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn2.Name = "btnSignIn2";
            this.btnSignIn2.Size = new System.Drawing.Size(607, 66);
            this.btnSignIn2.TabIndex = 3;
            this.btnSignIn2.Text = "Sign In";
            this.btnSignIn2.UseVisualStyleBackColor = false;
            this.btnSignIn2.Click += new System.EventHandler(this.btnSignIn2_Click);
            // 
            // txtEmailAdd
            // 
            this.txtEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAdd.Location = new System.Drawing.Point(1308, 577);
            this.txtEmailAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailAdd.Multiline = true;
            this.txtEmailAdd.Name = "txtEmailAdd";
            this.txtEmailAdd.Size = new System.Drawing.Size(605, 67);
            this.txtEmailAdd.TabIndex = 4;
            this.txtEmailAdd.TextChanged += new System.EventHandler(this.txtEmailAdd_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(1308, 694);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(605, 67);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // checkboxRememberme
            // 
            this.checkboxRememberme.BackColor = System.Drawing.Color.White;
            this.checkboxRememberme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkboxRememberme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkboxRememberme.Location = new System.Drawing.Point(1307, 777);
            this.checkboxRememberme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkboxRememberme.Name = "checkboxRememberme";
            this.checkboxRememberme.Size = new System.Drawing.Size(196, 27);
            this.checkboxRememberme.TabIndex = 6;
            this.checkboxRememberme.Text = "Remember Me ";
            this.checkboxRememberme.UseVisualStyleBackColor = false;
            this.checkboxRememberme.CheckedChanged += new System.EventHandler(this.checkboxRememberme_CheckedChanged);
            // 
            // PNLlogin
            // 
            this.PNLlogin.BackColor = System.Drawing.Color.Transparent;
            this.PNLlogin.Controls.Add(this.checkboxRememberme);
            this.PNLlogin.Controls.Add(this.txtPassword);
            this.PNLlogin.Controls.Add(this.txtEmailAdd);
            this.PNLlogin.Controls.Add(this.btnSignIn2);
            this.PNLlogin.Controls.Add(this.btnSignUp);
            this.PNLlogin.Controls.Add(this.btnSignIn);
            this.PNLlogin.Controls.Add(this.pictureBox1);
            this.PNLlogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNLlogin.Location = new System.Drawing.Point(0, 0);
            this.PNLlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PNLlogin.Name = "PNLlogin";
            this.PNLlogin.Size = new System.Drawing.Size(1924, 1055);
            this.PNLlogin.TabIndex = 8;
            this.PNLlogin.Paint += new System.Windows.Forms.PaintEventHandler(this.PNLlogin_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::archivingsystemshits.Properties.Resources.Screenshot_2025_06_27_1608271;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1689, 1079);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2240, 1070);
            this.panel1.TabIndex = 9;
            // 
            // loginsignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.PNLlogin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginsignup";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "loginsignup";
            this.Load += new System.EventHandler(this.loginsignup_Load);
            this.PNLlogin.ResumeLayout(false);
            this.PNLlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnSignIn2;
        private System.Windows.Forms.TextBox txtEmailAdd;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkboxRememberme;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PNLlogin;
        private System.Windows.Forms.Panel panel1;
    }
}