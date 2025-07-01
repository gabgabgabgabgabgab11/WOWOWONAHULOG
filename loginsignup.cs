using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;



namespace archivingsystemshits
{
    public partial class loginsignup : Form
    {
        public loginsignup()
        {
            InitializeComponent(); // Always call first

            this.DoubleBuffered = true; // Smoother gradient

            // Set the login panel to transparent so form gradient shows through
            PNLlogin.BackColor = Color.Transparent;
            
        }

        // Draw the diagonal gradient on the whole form
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Call base for standard painting

            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0)
                return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                ColorTranslator.FromHtml("#F5F7FF"),
                ColorTranslator.FromHtml("#E7EBF9"),
                LinearGradientMode.ForwardDiagonal
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
        private string demoEmail = "admin";
        private string demoPassword = "password123";


        private void btnSignIn2_Click(object sender, EventArgs e)
        {
            string email = txtEmailAdd.Text.Trim();
            string pwd = txtPassword.Text;

            if (email == demoEmail && pwd == demoPassword)
            {
                // Hide login form
                this.Hide();

                // Create and show main form
                Form1 nextForm = new Form1();


                // Make sure app exits when Form1 is closed
                nextForm.FormClosed += (s, args) => Application.Exit();

                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkboxRememberme_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PNLlogin_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0)
                return;

            using (LinearGradientBrush brush = new LinearGradientBrush(
            rect,
            ColorTranslator.FromHtml("#F5F7FF"), // top-left (start)
           ColorTranslator.FromHtml("#E7EBF9"), // bottom-right (end)
           LinearGradientMode.ForwardDiagonal   // diagonal gradient
           ))

            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void loginsignup_Load(object sender, EventArgs e)
        {

        }

       
    }
}
