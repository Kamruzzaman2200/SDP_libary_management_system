namespace SDP_libary_management_system
{
    partial class ReturnBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IssueDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.Bookch = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.StdCb = new System.Windows.Forms.ComboBox();
            this.StdphnTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.StdDeptTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StdnameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IssueNumTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label10 = new System.Windows.Forms.Label();
            this.IssueBookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ReturnedBookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBookDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 143);
            this.panel1.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Return BOOKS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1279, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // IssueDate
            // 
            this.IssueDate.BackColor = System.Drawing.Color.SeaGreen;
            this.IssueDate.BorderRadius = 0;
            this.IssueDate.ForeColor = System.Drawing.Color.White;
            this.IssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.IssueDate.FormatCustom = null;
            this.IssueDate.Location = new System.Drawing.Point(205, 525);
            this.IssueDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.Size = new System.Drawing.Size(370, 44);
            this.IssueDate.TabIndex = 83;
            this.IssueDate.Value = new System.DateTime(2024, 3, 25, 2, 44, 41, 451);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 543);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 82;
            this.label6.Text = "ISSUE";
            // 
            // Bookch
            // 
            this.Bookch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.Bookch.FormattingEnabled = true;
            this.Bookch.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Bookch.Location = new System.Drawing.Point(205, 478);
            this.Bookch.Name = "Bookch";
            this.Bookch.Size = new System.Drawing.Size(370, 33);
            this.Bookch.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "BOOK";
            // 
            // StdCb
            // 
            this.StdCb.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.StdCb.FormattingEnabled = true;
            this.StdCb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.StdCb.Location = new System.Drawing.Point(205, 245);
            this.StdCb.Name = "StdCb";
            this.StdCb.Size = new System.Drawing.Size(370, 33);
            this.StdCb.TabIndex = 79;
            // 
            // StdphnTb
            // 
            this.StdphnTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StdphnTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StdphnTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StdphnTb.HintForeColor = System.Drawing.Color.Empty;
            this.StdphnTb.HintText = "";
            this.StdphnTb.isPassword = false;
            this.StdphnTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.StdphnTb.LineIdleColor = System.Drawing.Color.Gray;
            this.StdphnTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StdphnTb.LineThickness = 3;
            this.StdphnTb.Location = new System.Drawing.Point(205, 402);
            this.StdphnTb.Margin = new System.Windows.Forms.Padding(4);
            this.StdphnTb.Name = "StdphnTb";
            this.StdphnTb.Size = new System.Drawing.Size(370, 44);
            this.StdphnTb.TabIndex = 78;
            this.StdphnTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 77;
            this.label7.Text = "PHONE";
            // 
            // StdDeptTb
            // 
            this.StdDeptTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StdDeptTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StdDeptTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StdDeptTb.HintForeColor = System.Drawing.Color.Empty;
            this.StdDeptTb.HintText = "";
            this.StdDeptTb.isPassword = false;
            this.StdDeptTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.StdDeptTb.LineIdleColor = System.Drawing.Color.Gray;
            this.StdDeptTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StdDeptTb.LineThickness = 3;
            this.StdDeptTb.Location = new System.Drawing.Point(205, 340);
            this.StdDeptTb.Margin = new System.Windows.Forms.Padding(4);
            this.StdDeptTb.Name = "StdDeptTb";
            this.StdDeptTb.Size = new System.Drawing.Size(370, 44);
            this.StdDeptTb.TabIndex = 76;
            this.StdDeptTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 358);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 25);
            this.label8.TabIndex = 75;
            this.label8.Text = "DEPARTMENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "NAME";
            // 
            // StdnameTb
            // 
            this.StdnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StdnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.StdnameTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StdnameTb.HintForeColor = System.Drawing.Color.Empty;
            this.StdnameTb.HintText = "";
            this.StdnameTb.isPassword = false;
            this.StdnameTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.StdnameTb.LineIdleColor = System.Drawing.Color.Gray;
            this.StdnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.StdnameTb.LineThickness = 3;
            this.StdnameTb.Location = new System.Drawing.Point(205, 284);
            this.StdnameTb.Margin = new System.Windows.Forms.Padding(4);
            this.StdnameTb.Name = "StdnameTb";
            this.StdnameTb.Size = new System.Drawing.Size(370, 44);
            this.StdnameTb.TabIndex = 73;
            this.StdnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "USN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "NUM";
            // 
            // IssueNumTb
            // 
            this.IssueNumTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IssueNumTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IssueNumTb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IssueNumTb.HintForeColor = System.Drawing.Color.Empty;
            this.IssueNumTb.HintText = "";
            this.IssueNumTb.isPassword = false;
            this.IssueNumTb.LineFocusedColor = System.Drawing.Color.Blue;
            this.IssueNumTb.LineIdleColor = System.Drawing.Color.Gray;
            this.IssueNumTb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.IssueNumTb.LineThickness = 3;
            this.IssueNumTb.Location = new System.Drawing.Point(205, 177);
            this.IssueNumTb.Margin = new System.Windows.Forms.Padding(4);
            this.IssueNumTb.Name = "IssueNumTb";
            this.IssueNumTb.Size = new System.Drawing.Size(370, 44);
            this.IssueNumTb.TabIndex = 70;
            this.IssueNumTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(205, 596);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(370, 44);
            this.bunifuDatepicker1.TabIndex = 85;
            this.bunifuDatepicker1.Value = new System.DateTime(2024, 3, 25, 2, 44, 41, 451);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(14, 614);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 25);
            this.label10.TabIndex = 84;
            this.label10.Text = "RETURN";
            // 
            // IssueBookDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.IssueBookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.IssueBookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.IssueBookDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.IssueBookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssueBookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.IssueBookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.IssueBookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.IssueBookDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.IssueBookDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.IssueBookDGV.EnableHeadersVisualStyles = false;
            this.IssueBookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDGV.Location = new System.Drawing.Point(602, 217);
            this.IssueBookDGV.Name = "IssueBookDGV";
            this.IssueBookDGV.RowHeadersVisible = false;
            this.IssueBookDGV.RowHeadersWidth = 51;
            this.IssueBookDGV.RowTemplate.Height = 30;
            this.IssueBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.IssueBookDGV.Size = new System.Drawing.Size(728, 274);
            this.IssueBookDGV.TabIndex = 86;
            this.IssueBookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.IssueBookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.IssueBookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.IssueBookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.IssueBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.IssueBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.IssueBookDGV.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.IssueBookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.IssueBookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.IssueBookDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.IssueBookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.IssueBookDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.IssueBookDGV.ThemeStyle.ReadOnly = false;
            this.IssueBookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.IssueBookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.IssueBookDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueBookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.IssueBookDGV.ThemeStyle.RowsStyle.Height = 30;
            this.IssueBookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.IssueBookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(881, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 25);
            this.label11.TabIndex = 87;
            this.label11.Text = "BOOKS ISSUED";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(868, 494);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 25);
            this.label12.TabIndex = 88;
            this.label12.Text = "BOOKS RETURNED";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // ReturnedBookDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ReturnedBookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReturnedBookDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ReturnedBookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReturnedBookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ReturnedBookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ReturnedBookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ReturnedBookDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReturnedBookDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.ReturnedBookDGV.EnableHeadersVisualStyles = false;
            this.ReturnedBookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.Location = new System.Drawing.Point(602, 525);
            this.ReturnedBookDGV.Name = "ReturnedBookDGV";
            this.ReturnedBookDGV.RowHeadersVisible = false;
            this.ReturnedBookDGV.RowHeadersWidth = 51;
            this.ReturnedBookDGV.RowTemplate.Height = 30;
            this.ReturnedBookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnedBookDGV.Size = new System.Drawing.Size(728, 274);
            this.ReturnedBookDGV.TabIndex = 89;
            this.ReturnedBookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ReturnedBookDGV.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.ReturnedBookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ReturnedBookDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.ReturnedBookDGV.ThemeStyle.ReadOnly = false;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.Height = 30;
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ReturnedBookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(100, 757);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 41);
            this.button4.TabIndex = 92;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(382, 757);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 41);
            this.button3.TabIndex = 91;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(222, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 41);
            this.button1.TabIndex = 90;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 834);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnedBookDGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.IssueBookDGV);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.IssueDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Bookch);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StdCb);
            this.Controls.Add(this.StdphnTb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StdDeptTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StdnameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IssueNumTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssueBookDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnedBookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker IssueDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Bookch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox StdCb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StdphnTb;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StdDeptTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox StdnameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox IssueNumTb;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDataGridView IssueBookDGV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Guna.UI.WinForms.GunaDataGridView ReturnedBookDGV;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}