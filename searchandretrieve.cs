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
    public partial class snr : Form
    {
        public snr()
        {
            InitializeComponent();
            panelsearch.BorderStyle = BorderStyle.None;
            panel1.BorderStyle = BorderStyle.None;

        }

        private void cbAllTypeDoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
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
    }
}
