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
    partial class snr
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            btnSearchsearchR = new Button();
            cbAllCategory = new ComboBox();
            label7 = new Label();
            cbAllStats = new ComboBox();
            label6 = new Label();
            cbAllTypeDoc = new ComboBox();
            label5 = new Label();
            dtDateTo = new DateTimePicker();
            label4 = new Label();
            dtDateFrom = new DateTimePicker();
            label3 = new Label();
            txtSearchTerms = new TextBox();
            label2 = new Label();
            cbSortDate = new ComboBox();
            lblSearchResultinSearchRetrieve = new Label();
            lbldocuResult = new Label();
            panel2 = new Panel();
            btnDownload = new Button();
            btnView = new Button();
            lblCourse = new Label();
            LblDate = new Label();
            lblAuthor = new Label();
            lblDocumentType = new Label();
            panelsearch = new Panel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelsearch.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(627, 51);
            label1.TabIndex = 0;
            label1.Text = "Search and Retrieve Documents";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.de289ba7_28f7_4089_91f1_867b4eedcadc;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnSearchsearchR);
            panel1.Controls.Add(cbAllCategory);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cbAllStats);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cbAllTypeDoc);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtDateTo);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(dtDateFrom);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSearchTerms);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 99);
            panel1.Name = "panel1";
            panel1.Size = new Size(1900, 284);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // btnSearchsearchR
            // 
            btnSearchsearchR.BackColor = Color.Maroon;
            btnSearchsearchR.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchsearchR.ForeColor = Color.White;
            btnSearchsearchR.Location = new Point(1777, 218);
            btnSearchsearchR.Name = "btnSearchsearchR";
            btnSearchsearchR.Size = new Size(120, 38);
            btnSearchsearchR.TabIndex = 3;
            btnSearchsearchR.Text = "Search";
            btnSearchsearchR.UseVisualStyleBackColor = false;
            // 
            // cbAllCategory
            // 
            cbAllCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAllCategory.FormattingEnabled = true;
            cbAllCategory.Location = new Point(1265, 70);
            cbAllCategory.Name = "cbAllCategory";
            cbAllCategory.Size = new Size(623, 28);
            cbAllCategory.TabIndex = 3;
            cbAllCategory.Text = "All Categories";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label7.Location = new Point(1265, 15);
            label7.Name = "label7";
            label7.Size = new Size(174, 46);
            label7.TabIndex = 4;
            label7.Text = "Category";
            // 
            // cbAllStats
            // 
            cbAllStats.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAllStats.FormattingEnabled = true;
            cbAllStats.Location = new Point(1265, 224);
            cbAllStats.Name = "cbAllStats";
            cbAllStats.Size = new Size(477, 28);
            cbAllStats.TabIndex = 3;
            cbAllStats.Text = "All Status";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1265, 177);
            label6.Name = "label6";
            label6.Size = new Size(145, 44);
            label6.TabIndex = 4;
            label6.Text = "Status";
            // 
            // cbAllTypeDoc
            // 
            cbAllTypeDoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbAllTypeDoc.FormattingEnabled = true;
            cbAllTypeDoc.Location = new Point(643, 70);
            cbAllTypeDoc.Name = "cbAllTypeDoc";
            cbAllTypeDoc.Size = new Size(548, 28);
            cbAllTypeDoc.TabIndex = 2;
            cbAllTypeDoc.Text = "All Type";
            cbAllTypeDoc.SelectedIndexChanged += cbAllTypeDoc_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label5.Location = new Point(643, 14);
            label5.Name = "label5";
            label5.Size = new Size(232, 53);
            label5.TabIndex = 3;
            label5.Text = "Document Type";
            // 
            // dtDateTo
            // 
            dtDateTo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDateTo.Location = new Point(643, 222);
            dtDateTo.Name = "dtDateTo";
            dtDateTo.Size = new Size(548, 27);
            dtDateTo.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(643, 165);
            label4.Name = "label4";
            label4.Size = new Size(136, 45);
            label4.TabIndex = 3;
            label4.Text = "Date To";
            // 
            // dtDateFrom
            // 
            dtDateFrom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtDateFrom.Location = new Point(14, 222);
            dtDateFrom.Name = "dtDateFrom";
            dtDateFrom.Size = new Size(562, 27);
            dtDateFrom.TabIndex = 2;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 149);
            label3.Name = "label3";
            label3.Size = new Size(172, 45);
            label3.TabIndex = 3;
            label3.Text = "Date From";
            // 
            // txtSearchTerms
            // 
            txtSearchTerms.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchTerms.Location = new Point(14, 65);
            txtSearchTerms.Multiline = true;
            txtSearchTerms.Name = "txtSearchTerms";
            txtSearchTerms.Size = new Size(562, 42);
            txtSearchTerms.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 15);
            label2.Name = "label2";
            label2.Size = new Size(172, 36);
            label2.TabIndex = 2;
            label2.Text = "Search Terms";
            // 
            // cbSortDate
            // 
            cbSortDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSortDate.FormattingEnabled = true;
            cbSortDate.Location = new Point(1740, 401);
            cbSortDate.Name = "cbSortDate";
            cbSortDate.Size = new Size(169, 28);
            cbSortDate.TabIndex = 4;
            cbSortDate.Text = "Sort By Date";
            // 
            // lblSearchResultinSearchRetrieve
            // 
            lblSearchResultinSearchRetrieve.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchResultinSearchRetrieve.Location = new Point(14, 393);
            lblSearchResultinSearchRetrieve.Name = "lblSearchResultinSearchRetrieve";
            lblSearchResultinSearchRetrieve.Size = new Size(513, 42);
            lblSearchResultinSearchRetrieve.TabIndex = 5;
            lblSearchResultinSearchRetrieve.Text = "Search Results (0 documents found)";
            // 
            // lbldocuResult
            // 
            lbldocuResult.BackColor = SystemColors.ControlLight;
            lbldocuResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldocuResult.ForeColor = SystemColors.ActiveCaptionText;
            lbldocuResult.Location = new Point(8, 10);
            lbldocuResult.Name = "lbldocuResult";
            lbldocuResult.Size = new Size(1862, 78);
            lbldocuResult.TabIndex = 6;
            lbldocuResult.Text = "Machine Learning in Healthcare Systems\r\n\r\n\r\n";
            lbldocuResult.Click += label9_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDownload);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(lblCourse);
            panel2.Controls.Add(LblDate);
            panel2.Controls.Add(lblAuthor);
            panel2.Controls.Add(lblDocumentType);
            panel2.Controls.Add(lbldocuResult);
            panel2.Location = new Point(11, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(1877, 105);
            panel2.TabIndex = 9;
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.Gold;
            btnDownload.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.ForeColor = Color.White;
            btnDownload.Location = new Point(1775, 51);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(92, 28);
            btnDownload.TabIndex = 13;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            // 
            // btnView
            // 
            btnView.BackColor = Color.Maroon;
            btnView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = Color.White;
            btnView.Location = new Point(1704, 51);
            btnView.Name = "btnView";
            btnView.Size = new Size(68, 28);
            btnView.TabIndex = 5;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = false;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BackColor = SystemColors.ControlLight;
            lblCourse.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(1482, 51);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(216, 28);
            lblCourse.TabIndex = 12;
            lblCourse.Text = "🏷️ Computer Science";
            // 
            // LblDate
            // 
            LblDate.AutoSize = true;
            LblDate.BackColor = SystemColors.ControlLight;
            LblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblDate.Location = new Point(928, 51);
            LblDate.Name = "LblDate";
            LblDate.Size = new Size(171, 28);
            LblDate.TabIndex = 11;
            LblDate.Text = "📅 Dec 15, 2023";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.BackColor = SystemColors.ControlLight;
            lblAuthor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.Location = new Point(400, 51);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(233, 28);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "👤 Prof. Sarah Johnson";
            // 
            // lblDocumentType
            // 
            lblDocumentType.AutoSize = true;
            lblDocumentType.BackColor = SystemColors.ControlLight;
            lblDocumentType.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocumentType.Location = new Point(8, 51);
            lblDocumentType.Name = "lblDocumentType";
            lblDocumentType.Size = new Size(191, 28);
            lblDocumentType.TabIndex = 10;
            lblDocumentType.Text = "📄 Research Paper";
            // 
            // panelsearch
            // 
            panelsearch.AccessibleRole = AccessibleRole.ScrollBar;
            panelsearch.AutoScroll = true;
            panelsearch.BackgroundImage = Properties.Resources.de289ba7_28f7_4089_91f1_867b4eedcadc;
            panelsearch.BackgroundImageLayout = ImageLayout.Stretch;
            panelsearch.Controls.Add(panel2);
            panelsearch.Location = new Point(12, 435);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(1900, 525);
            panelsearch.TabIndex = 10;
            panelsearch.Paint += panel3_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Maroon;
            panel3.Controls.Add(label1);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(-5, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1935, 83);
            panel3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1924, 972);
            Controls.Add(lblSearchResultinSearchRetrieve);
            Controls.Add(cbSortDate);
            Controls.Add(panel1);
            Controls.Add(panelsearch);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelsearch.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox txtSearchTerms;
        private Label label2;
        private ComboBox cbAllStats;
        private Label label6;
        private ComboBox cbAllTypeDoc;
        private Label label5;
        private DateTimePicker dtDateTo;
        private Label label4;
        private DateTimePicker dtDateFrom;
        private Button btnSearchsearchR;
        private ComboBox cbAllCategory;
        private Label label7;
        private ComboBox cbSortDate;
        private Label lblSearchResultinSearchRetrieve;
        private Label lbldocuResult;
        private Panel panel2;
        private Label lblAuthor;
        private Label lblDocumentType;
        private Label LblDate;
        private Label lblCourse;
        private Panel panelsearch;
        private Panel panel3;
        private Button btnView;
        private Button btnDownload;
    }
}
