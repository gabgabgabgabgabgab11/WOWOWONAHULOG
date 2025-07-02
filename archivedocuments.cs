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
    public partial class frmArchiveDocuments : Form
    {
        public frmArchiveDocuments()
        {
            InitializeComponent();
            panel2.BorderStyle = BorderStyle.None;
            panel3.BorderStyle = BorderStyle.None;
            panel1.BorderStyle = BorderStyle.None;

            panel3.BorderStyle = BorderStyle.None;
            // Add items after InitializeComponent
            cbDocumentType.Items.AddRange(new string[] {
                "Research Paper", "Thesis", "OJT Report", "Project Report"
            });

            cbCategory.Items.AddRange(new string[] {
               "Computer Engineering", "Information Technology", "Entrepreneurship", "Hospitality Management"
            });

            cbStatus.Items.AddRange(new string[] {
                "Draft", "Under Review", "Approved", "Published"
            });
        }

        private void lblHeader_Click(object sender, EventArgs e)
        {
            Label labelHeader = new Label();
            labelHeader.Text = "Archive New Document";
            labelHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            labelHeader.Location = new Point(20, 15);
            labelHeader.Size = new Size(600, 54);
            this.Controls.Add(labelHeader);
        }

        private void lblSubtitle_Click(object sender, EventArgs e)
        {
            Label labelSubHeader = new Label();
            labelSubHeader.Text = "Add a new document to your research archive";
            labelSubHeader.Font = new Font("Segoe UI", 12F);
            labelSubHeader.Location = new Point(24, 65);
            labelSubHeader.Size = new Size(600, 28);
            this.Controls.Add(labelSubHeader);
        }

        private void lblDocumentTitle_Click(object sender, EventArgs e)
        {
            Label labelDocumentTitle = new Label();
            labelDocumentTitle.Text = "Document Title";
            labelDocumentTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDocumentTitle.Location = new Point(30, 120);
            labelDocumentTitle.Size = new Size(180, 23);
            this.Controls.Add(labelDocumentTitle);

        }

        private void txtDocumentTitle_TextChanged(object sender, EventArgs e)
        {
            TextBox txtDocumentTitle = new TextBox();
            txtDocumentTitle.Location = new Point(30, 146);
            txtDocumentTitle.Size = new Size(700, 27);
            txtDocumentTitle.Text = "Enter document title";
            this.Controls.Add(txtDocumentTitle);
        }

        private void lblDocumentType_Click(object sender, EventArgs e)
        {
            Label labelDocumentType = new Label();
            labelDocumentType.Text = "Document Type";
            labelDocumentType.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDocumentType.Location = new Point(770, 120);
            labelDocumentType.Size = new Size(180, 23);
            this.Controls.Add(labelDocumentType);
        }

        private void cbDocumentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbDocumentType = new ComboBox();
            cbDocumentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDocumentType.Items.AddRange(new string[] { "Research Paper", "Thesis", "OJT Report", "Project Report" });
            cbDocumentType.Location = new Point(770, 146);
            cbDocumentType.Size = new Size(700, 28);
            this.Controls.Add(cbDocumentType);
        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {
            Label labelAuthor = new Label();
            labelAuthor.Text = "Author(s)";
            labelAuthor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelAuthor.Location = new Point(30, 190);
            labelAuthor.Size = new Size(180, 23);
            this.Controls.Add(labelAuthor);
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            TextBox txtAuthor = new TextBox();
            txtAuthor.Location = new Point(30, 216);
            txtAuthor.Size = new Size(700, 27);
            txtAuthor.Text = "Enter author name(s)";
            this.Controls.Add(txtAuthor);
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            Label labelCategory = new Label();
            labelCategory.Text = "Category";
            labelCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCategory.Location = new Point(770, 190);
            labelCategory.Size = new Size(180, 23);
            this.Controls.Add(labelCategory);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbCategory = new ComboBox();
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.Items.AddRange(new string[] { "Computer Engineering", "Information Technology", "Entrepreneurship", "Hospitality Management" });
            cbCategory.Location = new Point(770, 216);
            cbCategory.Size = new Size(700, 28);
            this.Controls.Add(cbCategory);
        }

        private void lblDescription_Click(object sender, EventArgs e)
        {
            Label labelDescription = new Label();
            labelDescription.Text = "Description";
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDescription.Location = new Point(30, 260);
            labelDescription.Size = new Size(180, 23);
            this.Controls.Add(labelDescription);
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            TextBox txtDescription = new TextBox();
            txtDescription.Location = new Point(30, 286);
            txtDescription.Size = new Size(1440, 70);
            txtDescription.Multiline = true;
            txtDescription.Text = "Enter document description or abstract";
            this.Controls.Add(txtDescription);
        }

        private void lblDateCreated_Click(object sender, EventArgs e)
        {
            Label labelDateCreated = new Label();
            labelDateCreated.Text = "Date Created";
            labelDateCreated.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDateCreated.Location = new Point(30, 505);
            labelDateCreated.Size = new Size(112, 23);
            this.Controls.Add(labelDateCreated);
        }

        private void dtpDateCreated_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtpDateCreated = new DateTimePicker();
            dtpDateCreated.CustomFormat = "dd/MM/yyyy";
            dtpDateCreated.Format = DateTimePickerFormat.Custom;
            dtpDateCreated.Location = new Point(30, 530);
            dtpDateCreated.Size = new Size(250, 27);
            this.Controls.Add(dtpDateCreated);
        }

        private void lblKeywords_Click(object sender, EventArgs e)
        {
            Label labelKeywords = new Label();
            labelKeywords.Text = "Keywords";
            labelKeywords.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelKeywords.Location = new Point(320, 505);
            labelKeywords.Size = new Size(86, 23);
            this.Controls.Add(labelKeywords);
        }

        private void txtKeywords_TextChanged(object sender, EventArgs e)
        {
            TextBox txtKeywords = new TextBox();
            txtKeywords.Location = new Point(320, 530);
            txtKeywords.Size = new Size(600, 27);
            txtKeywords.Text = "machine learning, AI, etc.";
            this.Controls.Add(txtKeywords);
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {
            Label labelStatus = new Label();
            labelStatus.Text = "Status";
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(950, 505);
            labelStatus.Size = new Size(60, 23);
            this.Controls.Add(labelStatus);

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbStatus = new ComboBox();
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Items.AddRange(new string[] { "Draft", "Under Review", "Approved", "Published" });
            cbStatus.Location = new Point(950, 530);
            cbStatus.Size = new Size(250, 28);
            this.Controls.Add(cbStatus);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button btnCancel = new Button();
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.Location = new Point(1200, 600);
            btnCancel.Size = new Size(120, 40);
            this.Controls.Add(btnCancel);
        }

        private void btnArchiveDocument_Click(object sender, EventArgs e)
        {
            Button btnArchive = new Button();
            btnArchive.Text = "Archive Document";
            btnArchive.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnArchive.BackColor = Color.Maroon;
            btnArchive.ForeColor = Color.White;
            btnArchive.Location = new Point(1330, 600);
            btnArchive.Size = new Size(220, 40);
            btnArchive.UseVisualStyleBackColor = false;
            this.Controls.Add(btnArchive);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
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
