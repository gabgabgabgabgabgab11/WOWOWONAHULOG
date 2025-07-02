using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace archivingsystemshits
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

            // Set up placeholder for .NET Framework
            SetPlaceholder(txtEnterName, "Enter Your Name");
            SetPlaceholder(txtEmail, "Email Address");
            SetPlaceholder(txtCreatepass, "Create Your Password", isPassword: true);

            txtEnterName.GotFocus += RemovePlaceholder;
            txtEnterName.LostFocus += AddPlaceholder;

            txtEmail.GotFocus += RemovePlaceholder;
            txtEmail.LostFocus += AddPlaceholder;

            txtCreatepass.GotFocus += RemovePlaceholder;
            txtCreatepass.LostFocus += AddPlaceholder;

            btnSignin.Click += Btnsignup1_Click;
            btnsignup2.Click += Btnsignup2_Click;
            checkboxSignup.CheckedChanged += CheckboxSignup_CheckedChanged;

            this.DoubleBuffered = true; // Smoother gradient

            // Set the login panel to transparent so form gradient shows through
            pnlbg.BackColor = Color.Transparent;
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
        // Placeholder logic for TextBox (since .NET Framework does not support PlaceholderText)
        private void SetPlaceholder(TextBox textBox, string placeholder, bool isPassword = false)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;
            textBox.Tag = placeholder;
            if (isPassword)
                textBox.PasswordChar = '\0';
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.Text == (tb.Tag as string))
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
                if (tb == txtCreatepass)
                    tb.PasswordChar = '*';
            }
        }

        private void AddPlaceholder(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = tb.Tag as string;
                tb.ForeColor = Color.Gray;
                if (tb == txtCreatepass)
                    tb.PasswordChar = '\0';
            }
        }

        private void Btnsignup1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Top 'Sign Up' button clicked. Please fill the form below.");
            txtEnterName.Focus();
        }

        private void Btnsignup2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void CheckboxSignup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxSignup.Checked)
            {
                MessageBox.Show("You chose to be remembered.");
            }
        }

        private bool ValidateForm()
        {
            if (IsPlaceholderOrEmpty(txtEnterName))
            {
                MessageBox.Show("Please enter your name.");
                txtEnterName.Focus();
                return false;
            }
            if (IsPlaceholderOrEmpty(txtEmail))
            {
                MessageBox.Show("Please enter your email address.");
                txtEmail.Focus();
                return false;
            }
            if (IsPlaceholderOrEmpty(txtCreatepass))
            {
                MessageBox.Show("Please create a password.");
                txtCreatepass.Focus();
                return false;
            }
            return true;
        }

        // Utility to check if textbox is empty or still on placeholder
        private bool IsPlaceholderOrEmpty(TextBox tb)
        {
            return string.IsNullOrWhiteSpace(tb.Text) || tb.Text == (tb.Tag as string);
        }

        private void ClearForm()
        {
            SetPlaceholder(txtEnterName, "Enter Your Name");
            SetPlaceholder(txtEmail, "Email Address");
            SetPlaceholder(txtCreatepass, "Create Your Password", isPassword: true);
            checkboxSignup.Checked = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // You can leave this empty or add your logic here
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

           

            {

            }
        }

        private void pnlbg_Paint(object sender, PaintEventArgs e)
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

        private void btnsignup1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnsignup2_Click_1(object sender, EventArgs e)
        {
            // Create an instance of the Settings form
            settings settingsForm = new settings();

            // Show the Settings form
            settingsForm.Show();

            // OPTIONAL: To hide the current form, uncomment the next line:
            // this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
