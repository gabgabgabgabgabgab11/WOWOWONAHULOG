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
    public partial class Form1 : Form
    {
     

        public Form1()
        {
           
            InitializeComponent();
            panel4.BorderStyle = BorderStyle.None;
            panel5.BorderStyle = BorderStyle.None;
            panel6.BorderStyle = BorderStyle.None;
            panel7.BorderStyle = BorderStyle.None;
            panel9.BorderStyle = BorderStyle.None;
            panel10.BorderStyle = BorderStyle.None;
                

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click(object sender, EventArgs e)
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void iconButton10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton11_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void iconBtnOjtReport_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {Color borderColor = Color.FromArgb(204, 153, 0); // Dark yellow
    int borderWidth = 2;

    Rectangle rect = ((Panel)sender).ClientRectangle;
    rect.Width -= 1;
    rect.Height -= 1;

    ControlPaint.DrawBorder(
        e.Graphics,
        rect,
        borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.FromArgb(0, 100, 0); // Dark green
            int borderWidth = 2;

            Rectangle rect = ((Panel)sender).ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                rect,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
                );
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.LightBlue;
            int borderWidth = 2;

            Rectangle rect = ((Panel)sender).ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                rect,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Orchid;
            int borderWidth = 2;

            Rectangle rect = ((Panel)sender).ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                rect,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

            Rectangle rect = ((Panel)sender).ClientRectangle;
            // Choose two soft grey shades
            Color color1 = Color.FromArgb(230, 230, 230); // Light grey
            Color color2 = Color.FromArgb(200, 200, 200); // Slightly darker grey

            using (LinearGradientBrush brush = new LinearGradientBrush(rect, color1, color2, LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.Maroon; // Standard maroon color
            int borderWidth = 2;

            Rectangle rect = ((Panel)sender).ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                rect,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

            Color borderColor = Color.Maroon; // Standard maroon color
            int borderWidth = 2;

            Rectangle rect = ((Panel)sender).ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            ControlPaint.DrawBorder(
                e.Graphics,
                rect,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid,
                borderColor, borderWidth, ButtonBorderStyle.Solid
            );
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void iconButton6_Click_1(object sender, EventArgs e)
        {

        }

        private void iconDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click_1(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
       
        

        private void panel14_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

        
    }

}

