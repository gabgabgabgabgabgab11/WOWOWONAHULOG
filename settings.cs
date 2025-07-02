using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace archivingsystemshits
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            panel1.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
        }

        private void lblActive_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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

        private void settings_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void lblAdminSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
