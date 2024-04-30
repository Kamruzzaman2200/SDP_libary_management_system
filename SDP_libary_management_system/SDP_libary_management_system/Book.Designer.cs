namespace SDP_libary_management_system
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.author = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.publisher = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BookDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).BeginInit();
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
            this.panel1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(517, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "BOOKS";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SkyBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 734);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 100);
            this.panel2.TabIndex = 24;
            // 
            // bookname
            // 
            this.bookname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookname.HintForeColor = System.Drawing.Color.Empty;
            this.bookname.HintText = "";
            this.bookname.isPassword = false;
            this.bookname.LineFocusedColor = System.Drawing.Color.Blue;
            this.bookname.LineIdleColor = System.Drawing.Color.Gray;
            this.bookname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bookname.LineThickness = 3;
            this.bookname.Location = new System.Drawing.Point(251, 185);
            this.bookname.Margin = new System.Windows.Forms.Padding(4);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(370, 44);
            this.bookname.TabIndex = 25;
            this.bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bookname.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(60, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Book Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(65, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Author";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // author
            // 
            this.author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.author.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.author.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.author.HintForeColor = System.Drawing.Color.Empty;
            this.author.HintText = "";
            this.author.isPassword = false;
            this.author.LineFocusedColor = System.Drawing.Color.Blue;
            this.author.LineIdleColor = System.Drawing.Color.Gray;
            this.author.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.author.LineThickness = 3;
            this.author.Location = new System.Drawing.Point(251, 253);
            this.author.Margin = new System.Windows.Forms.Padding(4);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(370, 44);
            this.author.TabIndex = 28;
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.author.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // publisher
            // 
            this.publisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.publisher.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.publisher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publisher.HintForeColor = System.Drawing.Color.Empty;
            this.publisher.HintText = "";
            this.publisher.isPassword = false;
            this.publisher.LineFocusedColor = System.Drawing.Color.Blue;
            this.publisher.LineIdleColor = System.Drawing.Color.Gray;
            this.publisher.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.publisher.LineThickness = 3;
            this.publisher.Location = new System.Drawing.Point(251, 327);
            this.publisher.Margin = new System.Windows.Forms.Padding(4);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(370, 44);
            this.publisher.TabIndex = 29;
            this.publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.publisher.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Publisher";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(65, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Price";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.price.HintForeColor = System.Drawing.Color.Empty;
            this.price.HintText = "";
            this.price.isPassword = false;
            this.price.LineFocusedColor = System.Drawing.Color.Blue;
            this.price.LineIdleColor = System.Drawing.Color.Gray;
            this.price.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.price.LineThickness = 3;
            this.price.Location = new System.Drawing.Point(251, 395);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(370, 44);
            this.price.TabIndex = 36;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.price.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(72, 608);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(291, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 41);
            this.button2.TabIndex = 38;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(487, 598);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 41);
            this.button3.TabIndex = 39;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(291, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 41);
            this.button4.TabIndex = 41;
            this.button4.Text = "HOME";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(65, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "Quantity";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // quantity
            // 
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity.HintForeColor = System.Drawing.Color.Empty;
            this.quantity.HintText = "";
            this.quantity.isPassword = false;
            this.quantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.quantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.quantity.LineThickness = 3;
            this.quantity.Location = new System.Drawing.Point(251, 467);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(370, 44);
            this.quantity.TabIndex = 43;
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantity.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox6_OnValueChanged);
            // 
            // BookDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BookDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.BookDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookDGV.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.BookDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.BookDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BookDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.BookDGV.EnableHeadersVisualStyles = false;
            this.BookDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookDGV.Location = new System.Drawing.Point(686, 185);
            this.BookDGV.Name = "BookDGV";
            this.BookDGV.RowHeadersVisible = false;
            this.BookDGV.RowHeadersWidth = 51;
            this.BookDGV.RowTemplate.Height = 30;
            this.BookDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookDGV.Size = new System.Drawing.Size(622, 522);
            this.BookDGV.TabIndex = 56;
            this.BookDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BookDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BookDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BookDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BookDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BookDGV.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.BookDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.BookDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BookDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BookDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BookDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.BookDGV.ThemeStyle.ReadOnly = false;
            this.BookDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BookDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.BookDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookDGV.ThemeStyle.RowsStyle.Height = 30;
            this.BookDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BookDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BookDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookDGV_CellContentClick);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 834);
            this.Controls.Add(this.BookDGV);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.author);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox author;
        private Bunifu.Framework.UI.BunifuMaterialTextbox publisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox price;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantity;
        private Guna.UI.WinForms.GunaDataGridView BookDGV;
    }
}