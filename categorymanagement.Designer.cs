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
    partial class cm
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
            label2 = new Label();
            panel1 = new Panel();
            lblDocument1 = new Label();
            button7 = new Button();
            button3 = new Button();
            lblBSCPE = new Label();
            panel2 = new Panel();
            lblTextField = new Label();
            button15 = new Button();
            button11 = new Button();
            lblKeyword = new Label();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            lblDocument2 = new Label();
            button8 = new Button();
            button4 = new Button();
            lblHM = new Label();
            panel4 = new Panel();
            lblDocument3 = new Label();
            button9 = new Button();
            button5 = new Button();
            lblBsit = new Label();
            panel5 = new Panel();
            lblDocument4 = new Label();
            button10 = new Button();
            button6 = new Button();
            lblBSHM = new Label();
            panel6 = new Panel();
            lblLongText = new Label();
            button16 = new Button();
            button12 = new Button();
            lblAbstract = new Label();
            panel7 = new Panel();
            lblYearField = new Label();
            button17 = new Button();
            button13 = new Button();
            lblPublicationYear = new Label();
            panel8 = new Panel();
            lblInstitutions = new Label();
            button18 = new Button();
            button14 = new Button();
            lblInstitution = new Label();
            label3 = new Label();
            label4 = new Label();
            panel9 = new Panel();
            label5 = new Label();
            cbTagging = new CheckBox();
            lblAutoTagging = new Label();
            panel10 = new Panel();
            label8 = new Label();
            cbTextIndexing = new CheckBox();
            lblFullText = new Label();
            panel11 = new Panel();
            label6 = new Label();
            cbDuplicateDetection = new CheckBox();
            lblDuplicateDetection = new Label();
            panel12 = new Panel();
            label7 = new Label();
            cbVersionControl = new CheckBox();
            lblVersionControl = new Label();
            panel13 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Maroon;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 0);
            label1.Name = "label1";
            label1.Size = new Size(663, 44);
            label1.TabIndex = 0;
            label1.Text = "Category and Metadata Management";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 124);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 1;
            label2.Text = "Document Categories";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblDocument1);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(lblBSCPE);
            panel1.Location = new Point(12, 159);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 87);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // lblDocument1
            // 
            lblDocument1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocument1.Location = new Point(13, 42);
            lblDocument1.Name = "lblDocument1";
            lblDocument1.Size = new Size(118, 31);
            lblDocument1.TabIndex = 26;
            lblDocument1.Text = "156 documents";
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(800, 29);
            button7.Name = "button7";
            button7.Size = new Size(84, 29);
            button7.TabIndex = 25;
            button7.Text = "Delete";
            button7.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(737, 29);
            button3.Name = "button3";
            button3.Size = new Size(57, 29);
            button3.TabIndex = 24;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            // 
            // lblBSCPE
            // 
            lblBSCPE.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBSCPE.Location = new Point(13, 9);
            lblBSCPE.Name = "lblBSCPE";
            lblBSCPE.Size = new Size(82, 33);
            lblBSCPE.TabIndex = 18;
            lblBSCPE.Text = "BSCPE";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblTextField);
            panel2.Controls.Add(button15);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(lblKeyword);
            panel2.Location = new Point(994, 159);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 87);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // lblTextField
            // 
            lblTextField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextField.Location = new Point(9, 42);
            lblTextField.Name = "lblTextField";
            lblTextField.Size = new Size(319, 31);
            lblTextField.TabIndex = 27;
            lblTextField.Text = "Text field for document keywords and tags";
            lblTextField.Click += label5_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.IndianRed;
            button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button15.Location = new Point(814, 29);
            button15.Name = "button15";
            button15.Size = new Size(78, 29);
            button15.TabIndex = 26;
            button15.Text = "Edit";
            button15.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.CornflowerBlue;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(730, 29);
            button11.Name = "button11";
            button11.Size = new Size(78, 29);
            button11.TabIndex = 25;
            button11.Text = "Active";
            button11.UseVisualStyleBackColor = false;
            // 
            // lblKeyword
            // 
            lblKeyword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKeyword.Location = new Point(13, 9);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(89, 33);
            lblKeyword.TabIndex = 20;
            lblKeyword.Text = "Keywords";
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(788, 124);
            button1.Name = "button1";
            button1.Size = new Size(142, 32);
            button1.TabIndex = 5;
            button1.Text = "Add Category";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Maroon;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1782, 124);
            button2.Name = "button2";
            button2.Size = new Size(130, 32);
            button2.TabIndex = 6;
            button2.Text = "Add Field";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(lblDocument2);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(lblHM);
            panel3.Location = new Point(12, 252);
            panel3.Name = "panel3";
            panel3.Size = new Size(918, 87);
            panel3.TabIndex = 7;
            panel3.Paint += panel3_Paint;
            // 
            // lblDocument2
            // 
            lblDocument2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocument2.Location = new Point(13, 46);
            lblDocument2.Name = "lblDocument2";
            lblDocument2.Size = new Size(118, 31);
            lblDocument2.TabIndex = 27;
            lblDocument2.Text = "156 documents";
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(800, 30);
            button8.Name = "button8";
            button8.Size = new Size(84, 29);
            button8.TabIndex = 26;
            button8.Text = "Delete";
            button8.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(737, 30);
            button4.Name = "button4";
            button4.Size = new Size(57, 29);
            button4.TabIndex = 25;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            // 
            // lblHM
            // 
            lblHM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHM.Location = new Point(12, 9);
            lblHM.Name = "lblHM";
            lblHM.Size = new Size(64, 26);
            lblHM.TabIndex = 19;
            lblHM.Text = "BSHM";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(lblDocument3);
            panel4.Controls.Add(button9);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(lblBsit);
            panel4.Location = new Point(12, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(918, 87);
            panel4.TabIndex = 8;
            panel4.Paint += panel4_Paint;
            // 
            // lblDocument3
            // 
            lblDocument3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocument3.Location = new Point(13, 37);
            lblDocument3.Name = "lblDocument3";
            lblDocument3.Size = new Size(118, 31);
            lblDocument3.TabIndex = 28;
            lblDocument3.Text = "156 documents";
            lblDocument3.Click += label7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.IndianRed;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(800, 28);
            button9.Name = "button9";
            button9.Size = new Size(84, 29);
            button9.TabIndex = 26;
            button9.Text = "Delete";
            button9.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.CornflowerBlue;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(737, 28);
            button5.Name = "button5";
            button5.Size = new Size(57, 29);
            button5.TabIndex = 25;
            button5.Text = "Edit";
            button5.UseVisualStyleBackColor = false;
            // 
            // lblBsit
            // 
            lblBsit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBsit.Location = new Point(12, 9);
            lblBsit.Name = "lblBsit";
            lblBsit.Size = new Size(64, 28);
            lblBsit.TabIndex = 20;
            lblBsit.Text = "BSIT";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(lblDocument4);
            panel5.Controls.Add(button10);
            panel5.Controls.Add(button6);
            panel5.Controls.Add(lblBSHM);
            panel5.Location = new Point(12, 438);
            panel5.Name = "panel5";
            panel5.Size = new Size(918, 87);
            panel5.TabIndex = 9;
            panel5.Paint += panel5_Paint;
            // 
            // lblDocument4
            // 
            lblDocument4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocument4.Location = new Point(13, 42);
            lblDocument4.Name = "lblDocument4";
            lblDocument4.Size = new Size(118, 31);
            lblDocument4.TabIndex = 29;
            lblDocument4.Text = "156 documents";
            // 
            // button10
            // 
            button10.BackColor = Color.IndianRed;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(800, 30);
            button10.Name = "button10";
            button10.Size = new Size(84, 29);
            button10.TabIndex = 26;
            button10.Text = "Delete";
            button10.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(737, 30);
            button6.Name = "button6";
            button6.Size = new Size(57, 29);
            button6.TabIndex = 25;
            button6.Text = "Edit";
            button6.UseVisualStyleBackColor = false;
            // 
            // lblBSHM
            // 
            lblBSHM.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBSHM.Location = new Point(13, 9);
            lblBSHM.Name = "lblBSHM";
            lblBSHM.Size = new Size(99, 33);
            lblBSHM.TabIndex = 20;
            lblBSHM.Text = "BSENTREP";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Controls.Add(lblLongText);
            panel6.Controls.Add(button16);
            panel6.Controls.Add(button12);
            panel6.Controls.Add(lblAbstract);
            panel6.Location = new Point(994, 252);
            panel6.Name = "panel6";
            panel6.Size = new Size(918, 87);
            panel6.TabIndex = 10;
            panel6.Paint += panel6_Paint;
            // 
            // lblLongText
            // 
            lblLongText.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLongText.Location = new Point(13, 46);
            lblLongText.Name = "lblLongText";
            lblLongText.Size = new Size(319, 31);
            lblLongText.TabIndex = 28;
            lblLongText.Text = "Long text field for document abstract";
            // 
            // button16
            // 
            button16.BackColor = Color.IndianRed;
            button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button16.Location = new Point(814, 30);
            button16.Name = "button16";
            button16.Size = new Size(78, 29);
            button16.TabIndex = 27;
            button16.Text = "Edit";
            button16.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.CornflowerBlue;
            button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button12.Location = new Point(730, 30);
            button12.Name = "button12";
            button12.Size = new Size(78, 29);
            button12.TabIndex = 26;
            button12.Text = "Active";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // lblAbstract
            // 
            lblAbstract.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAbstract.Location = new Point(13, 9);
            lblAbstract.Name = "lblAbstract";
            lblAbstract.Size = new Size(89, 26);
            lblAbstract.TabIndex = 20;
            lblAbstract.Text = "Abstract";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(lblYearField);
            panel7.Controls.Add(button17);
            panel7.Controls.Add(button13);
            panel7.Controls.Add(lblPublicationYear);
            panel7.Location = new Point(994, 345);
            panel7.Name = "panel7";
            panel7.Size = new Size(918, 87);
            panel7.TabIndex = 11;
            panel7.Paint += panel7_Paint;
            // 
            // lblYearField
            // 
            lblYearField.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearField.Location = new Point(13, 37);
            lblYearField.Name = "lblYearField";
            lblYearField.Size = new Size(319, 31);
            lblYearField.TabIndex = 29;
            lblYearField.Text = "Year field for publication date";
            // 
            // button17
            // 
            button17.BackColor = Color.IndianRed;
            button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button17.Location = new Point(814, 28);
            button17.Name = "button17";
            button17.Size = new Size(78, 29);
            button17.TabIndex = 28;
            button17.Text = "Edit";
            button17.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.CornflowerBlue;
            button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button13.Location = new Point(730, 28);
            button13.Name = "button13";
            button13.Size = new Size(78, 29);
            button13.TabIndex = 26;
            button13.Text = "Active";
            button13.UseVisualStyleBackColor = false;
            // 
            // lblPublicationYear
            // 
            lblPublicationYear.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublicationYear.Location = new Point(13, 9);
            lblPublicationYear.Name = "lblPublicationYear";
            lblPublicationYear.Size = new Size(125, 28);
            lblPublicationYear.TabIndex = 20;
            lblPublicationYear.Text = "Publication year";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Controls.Add(lblInstitutions);
            panel8.Controls.Add(button18);
            panel8.Controls.Add(button14);
            panel8.Controls.Add(lblInstitution);
            panel8.Location = new Point(994, 438);
            panel8.Name = "panel8";
            panel8.Size = new Size(918, 87);
            panel8.TabIndex = 12;
            panel8.Paint += panel8_Paint;
            // 
            // lblInstitutions
            // 
            lblInstitutions.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstitutions.Location = new Point(13, 34);
            lblInstitutions.Name = "lblInstitutions";
            lblInstitutions.Size = new Size(319, 31);
            lblInstitutions.TabIndex = 30;
            lblInstitutions.Text = "Institutions or organization field";
            // 
            // button18
            // 
            button18.BackColor = Color.CornflowerBlue;
            button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button18.Location = new Point(814, 30);
            button18.Name = "button18";
            button18.Size = new Size(78, 29);
            button18.TabIndex = 28;
            button18.Text = "Edit";
            button18.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.IndianRed;
            button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button14.Location = new Point(730, 30);
            button14.Name = "button14";
            button14.Size = new Size(78, 29);
            button14.TabIndex = 26;
            button14.Text = "Inactive";
            button14.UseVisualStyleBackColor = false;
            // 
            // lblInstitution
            // 
            lblInstitution.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstitution.Location = new Point(13, 9);
            lblInstitution.Name = "lblInstitution";
            lblInstitution.Size = new Size(113, 33);
            lblInstitution.TabIndex = 20;
            lblInstitution.Text = "Institution";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 574);
            label3.Name = "label3";
            label3.Size = new Size(262, 40);
            label3.TabIndex = 13;
            label3.Text = "Advanced Settings";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(994, 122);
            label4.Name = "label4";
            label4.Size = new Size(262, 29);
            label4.TabIndex = 14;
            label4.Text = "Metadata Fields";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Controls.Add(label5);
            panel9.Controls.Add(cbTagging);
            panel9.Controls.Add(lblAutoTagging);
            panel9.Location = new Point(12, 627);
            panel9.Name = "panel9";
            panel9.Size = new Size(918, 138);
            panel9.TabIndex = 15;
            panel9.Paint += panel9_Paint;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 49);
            label5.Name = "label5";
            label5.Size = new Size(449, 31);
            label5.TabIndex = 30;
            label5.Text = "Automatically generate tags based on document content";
            // 
            // cbTagging
            // 
            cbTagging.AutoSize = true;
            cbTagging.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTagging.Location = new Point(12, 88);
            cbTagging.Name = "cbTagging";
            cbTagging.Size = new Size(171, 24);
            cbTagging.TabIndex = 22;
            cbTagging.Text = "Enable auto-tagging";
            cbTagging.UseVisualStyleBackColor = true;
            // 
            // lblAutoTagging
            // 
            lblAutoTagging.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutoTagging.Location = new Point(13, 16);
            lblAutoTagging.Name = "lblAutoTagging";
            lblAutoTagging.Size = new Size(130, 28);
            lblAutoTagging.TabIndex = 20;
            lblAutoTagging.Text = "Auto-Tagging";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Transparent;
            panel10.Controls.Add(label8);
            panel10.Controls.Add(cbTextIndexing);
            panel10.Controls.Add(lblFullText);
            panel10.Location = new Point(12, 808);
            panel10.Name = "panel10";
            panel10.Size = new Size(918, 139);
            panel10.TabIndex = 16;
            panel10.Paint += panel10_Paint;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 49);
            label8.Name = "label8";
            label8.Size = new Size(449, 31);
            label8.TabIndex = 33;
            label8.Text = "Index document content for full-text search";
            // 
            // cbTextIndexing
            // 
            cbTextIndexing.AutoSize = true;
            cbTextIndexing.BackColor = Color.Transparent;
            cbTextIndexing.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTextIndexing.Location = new Point(12, 101);
            cbTextIndexing.Name = "cbTextIndexing";
            cbTextIndexing.Size = new Size(199, 24);
            cbTextIndexing.TabIndex = 23;
            cbTextIndexing.Text = "Enable full-text indexing";
            cbTextIndexing.UseVisualStyleBackColor = false;
            cbTextIndexing.CheckedChanged += cbTextIndexing_CheckedChanged;
            // 
            // lblFullText
            // 
            lblFullText.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullText.Location = new Point(13, 15);
            lblFullText.Name = "lblFullText";
            lblFullText.Size = new Size(115, 29);
            lblFullText.TabIndex = 21;
            lblFullText.Text = "Full-Text Search";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Controls.Add(label6);
            panel11.Controls.Add(cbDuplicateDetection);
            panel11.Controls.Add(lblDuplicateDetection);
            panel11.Location = new Point(994, 627);
            panel11.Name = "panel11";
            panel11.Size = new Size(918, 138);
            panel11.TabIndex = 17;
            panel11.Paint += panel11_Paint;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(13, 54);
            label6.Name = "label6";
            label6.Size = new Size(449, 31);
            label6.TabIndex = 31;
            label6.Text = "Check for duplicate documents during upload";
            // 
            // cbDuplicateDetection
            // 
            cbDuplicateDetection.AutoSize = true;
            cbDuplicateDetection.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbDuplicateDetection.Location = new Point(13, 88);
            cbDuplicateDetection.Name = "cbDuplicateDetection";
            cbDuplicateDetection.Size = new Size(212, 24);
            cbDuplicateDetection.TabIndex = 23;
            cbDuplicateDetection.Text = "Enable duplicate detection";
            cbDuplicateDetection.UseVisualStyleBackColor = true;
            // 
            // lblDuplicateDetection
            // 
            lblDuplicateDetection.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuplicateDetection.Location = new Point(13, 15);
            lblDuplicateDetection.Name = "lblDuplicateDetection";
            lblDuplicateDetection.Size = new Size(150, 29);
            lblDuplicateDetection.TabIndex = 21;
            lblDuplicateDetection.Text = "Duplicate Detection";
            lblDuplicateDetection.Click += label15_Click;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Transparent;
            panel12.Controls.Add(label7);
            panel12.Controls.Add(cbVersionControl);
            panel12.Controls.Add(lblVersionControl);
            panel12.Location = new Point(994, 808);
            panel12.Name = "panel12";
            panel12.Size = new Size(918, 139);
            panel12.TabIndex = 16;
            panel12.Paint += panel12_Paint;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 49);
            label7.Name = "label7";
            label7.Size = new Size(449, 31);
            label7.TabIndex = 32;
            label7.Text = "Track document versions and changes";
            // 
            // cbVersionControl
            // 
            cbVersionControl.AutoSize = true;
            cbVersionControl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbVersionControl.Location = new Point(13, 101);
            cbVersionControl.Name = "cbVersionControl";
            cbVersionControl.Size = new Size(184, 24);
            cbVersionControl.TabIndex = 23;
            cbVersionControl.Text = "Enable version control";
            cbVersionControl.UseVisualStyleBackColor = true;
            cbVersionControl.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // lblVersionControl
            // 
            lblVersionControl.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVersionControl.Location = new Point(13, 15);
            lblVersionControl.Name = "lblVersionControl";
            lblVersionControl.Size = new Size(150, 34);
            lblVersionControl.TabIndex = 21;
            lblVersionControl.Text = "Version Control";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Maroon;
            panel13.Controls.Add(label1);
            panel13.Location = new Point(-1, -1);
            panel13.Name = "panel13";
            panel13.Size = new Size(1936, 76);
            panel13.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 972);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(panel13);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Label label3;
        private Label label4;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label lblBSCPE;
        private Label lblKeyword;
        private Label lblHM;
        private Label lblBsit;
        private Label lblBSHM;
        private Label lblAbstract;
        private Label lblPublicationYear;
        private Label lblInstitution;
        private CheckBox cbTagging;
        private Label lblAutoTagging;
        private Label lblFullText;
        private CheckBox cbDuplicateDetection;
        private Label lblDuplicateDetection;
        private CheckBox cbVersionControl;
        private Label lblVersionControl;
        private CheckBox cbTextIndexing;
        private Button button7;
        private Button button3;
        private Button button8;
        private Button button4;
        private Button button9;
        private Button button5;
        private Button button10;
        private Button button6;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Label lblDocument1;
        private Label lblDocument2;
        private Label lblDocument3;
        private Label lblDocument4;
        private Label lblTextField;
        private Label lblLongText;
        private Label lblYearField;
        private Label lblInstitutions;
        private Label label5;
        private Label label8;
        private Label label6;
        private Label label7;
        private Panel panel13;
    }
}
