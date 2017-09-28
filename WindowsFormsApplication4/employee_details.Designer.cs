namespace WindowsFormsApplication4
{
    partial class employee_details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.table12 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.address2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dob = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cardid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.position = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gender = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.HintForeColor = System.Drawing.Color.Empty;
            this.search.HintText = "";
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.search.LineIdleColor = System.Drawing.Color.Gray;
            this.search.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(132, 66);
            this.search.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(539, 54);
            this.search.TabIndex = 25;
            this.search.Text = "Enter nic num";
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.search.Enter += new System.EventHandler(this.search_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(704, 73);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 47);
            this.button1.TabIndex = 31;
            this.button1.Text = "Serach";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.table12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(100, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(920, 688);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee List";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(344, 390);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 47);
            this.button3.TabIndex = 32;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(51, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 47);
            this.button2.TabIndex = 31;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // table12
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.table12.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.table12.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.table12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table12.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.table12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.address1DataGridViewTextBoxColumn,
            this.address2DataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.nicDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.cardidDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.table12.DoubleBuffered = true;
            this.table12.EnableHeadersVisualStyles = false;
            this.table12.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.table12.HeaderForeColor = System.Drawing.Color.Black;
            this.table12.Location = new System.Drawing.Point(42, 48);
            this.table12.Margin = new System.Windows.Forms.Padding(4);
            this.table12.Name = "table12";
            this.table12.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table12.Size = new System.Drawing.Size(850, 257);
            this.table12.TabIndex = 30;
            this.table12.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table12_CellContentClick);
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "fname";
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "lname";
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // address1DataGridViewTextBoxColumn
            // 
            this.address1DataGridViewTextBoxColumn.DataPropertyName = "address1";
            this.address1DataGridViewTextBoxColumn.HeaderText = "address1";
            this.address1DataGridViewTextBoxColumn.Name = "address1DataGridViewTextBoxColumn";
            // 
            // address2DataGridViewTextBoxColumn
            // 
            this.address2DataGridViewTextBoxColumn.DataPropertyName = "address2";
            this.address2DataGridViewTextBoxColumn.HeaderText = "address2";
            this.address2DataGridViewTextBoxColumn.Name = "address2DataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            this.cityDataGridViewTextBoxColumn.HeaderText = "city";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // nicDataGridViewTextBoxColumn
            // 
            this.nicDataGridViewTextBoxColumn.DataPropertyName = "nic";
            this.nicDataGridViewTextBoxColumn.HeaderText = "nic";
            this.nicDataGridViewTextBoxColumn.Name = "nicDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // cardidDataGridViewTextBoxColumn
            // 
            this.cardidDataGridViewTextBoxColumn.DataPropertyName = "cardid";
            this.cardidDataGridViewTextBoxColumn.HeaderText = "cardid";
            this.cardidDataGridViewTextBoxColumn.Name = "cardidDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "image";
            this.imageDataGridViewImageColumn.HeaderText = "image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1041, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 694);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_Member_100;
            this.pictureBox1.Location = new System.Drawing.Point(107, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.address2);
            this.groupBox4.Controls.Add(this.city);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.Telephone);
            this.groupBox4.Controls.Add(this.address1);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(33, 496);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 192);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Info";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // address2
            // 
            this.address2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.address2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address2.HintForeColor = System.Drawing.Color.Empty;
            this.address2.HintText = "";
            this.address2.isPassword = false;
            this.address2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address2.LineIdleColor = System.Drawing.Color.Gray;
            this.address2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address2.LineThickness = 3;
            this.address2.Location = new System.Drawing.Point(137, 95);
            this.address2.Margin = new System.Windows.Forms.Padding(4);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(131, 30);
            this.address2.TabIndex = 44;
            this.address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.HintForeColor = System.Drawing.Color.Empty;
            this.city.HintText = "";
            this.city.isPassword = false;
            this.city.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.city.LineIdleColor = System.Drawing.Color.Gray;
            this.city.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.city.LineThickness = 3;
            this.city.Location = new System.Drawing.Point(137, 123);
            this.city.Margin = new System.Windows.Forms.Padding(4);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(131, 30);
            this.city.TabIndex = 38;
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(7, 130);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(7, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 40;
            this.label10.Text = "Address2";
            // 
            // Telephone
            // 
            this.Telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.Telephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telephone.HintForeColor = System.Drawing.Color.Empty;
            this.Telephone.HintText = "";
            this.Telephone.isPassword = false;
            this.Telephone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.Telephone.LineIdleColor = System.Drawing.Color.Gray;
            this.Telephone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.Telephone.LineThickness = 3;
            this.Telephone.Location = new System.Drawing.Point(137, 161);
            this.Telephone.Margin = new System.Windows.Forms.Padding(4);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(131, 30);
            this.Telephone.TabIndex = 39;
            this.Telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // address1
            // 
            this.address1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.address1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address1.HintForeColor = System.Drawing.Color.Empty;
            this.address1.HintText = "";
            this.address1.isPassword = false;
            this.address1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address1.LineIdleColor = System.Drawing.Color.Gray;
            this.address1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address1.LineThickness = 3;
            this.address1.Location = new System.Drawing.Point(137, 45);
            this.address1.Margin = new System.Windows.Forms.Padding(4);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(131, 30);
            this.address1.TabIndex = 38;
            this.address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox9_OnValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(6, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Telephone";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Address1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dob);
            this.groupBox3.Controls.Add(this.cardid);
            this.groupBox3.Controls.Add(this.position);
            this.groupBox3.Controls.Add(this.nic);
            this.groupBox3.Controls.Add(this.gender);
            this.groupBox3.Controls.Add(this.lname);
            this.groupBox3.Controls.Add(this.fname);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(33, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 288);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Info";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // dob
            // 
            this.dob.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dob.HintForeColor = System.Drawing.Color.Empty;
            this.dob.HintText = "";
            this.dob.isPassword = false;
            this.dob.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dob.LineIdleColor = System.Drawing.Color.Gray;
            this.dob.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dob.LineThickness = 3;
            this.dob.Location = new System.Drawing.Point(137, 95);
            this.dob.Margin = new System.Windows.Forms.Padding(4);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(131, 30);
            this.dob.TabIndex = 38;
            this.dob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cardid
            // 
            this.cardid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cardid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardid.HintForeColor = System.Drawing.Color.Empty;
            this.cardid.HintText = "";
            this.cardid.isPassword = false;
            this.cardid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid.LineIdleColor = System.Drawing.Color.Gray;
            this.cardid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid.LineThickness = 3;
            this.cardid.Location = new System.Drawing.Point(137, 251);
            this.cardid.Margin = new System.Windows.Forms.Padding(4);
            this.cardid.Name = "cardid";
            this.cardid.Size = new System.Drawing.Size(131, 30);
            this.cardid.TabIndex = 37;
            this.cardid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // position
            // 
            this.position.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.position.HintForeColor = System.Drawing.Color.Empty;
            this.position.HintText = "";
            this.position.isPassword = false;
            this.position.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.position.LineIdleColor = System.Drawing.Color.Gray;
            this.position.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.position.LineThickness = 3;
            this.position.Location = new System.Drawing.Point(137, 211);
            this.position.Margin = new System.Windows.Forms.Padding(4);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(131, 30);
            this.position.TabIndex = 36;
            this.position.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nic
            // 
            this.nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nic.HintForeColor = System.Drawing.Color.Empty;
            this.nic.HintText = "";
            this.nic.isPassword = false;
            this.nic.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic.LineIdleColor = System.Drawing.Color.Gray;
            this.nic.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic.LineThickness = 3;
            this.nic.Location = new System.Drawing.Point(137, 179);
            this.nic.Margin = new System.Windows.Forms.Padding(4);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(131, 30);
            this.nic.TabIndex = 35;
            this.nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gender
            // 
            this.gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gender.HintForeColor = System.Drawing.Color.Empty;
            this.gender.HintText = "";
            this.gender.isPassword = false;
            this.gender.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.gender.LineIdleColor = System.Drawing.Color.Gray;
            this.gender.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.gender.LineThickness = 3;
            this.gender.Location = new System.Drawing.Point(137, 142);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(131, 30);
            this.gender.TabIndex = 34;
            this.gender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname.LineIdleColor = System.Drawing.Color.Gray;
            this.lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(137, 57);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(131, 30);
            this.lname.TabIndex = 33;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname.LineIdleColor = System.Drawing.Color.Gray;
            this.fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(138, 19);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(131, 30);
            this.fname.TabIndex = 31;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Card ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Postion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "First Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(1118, 117);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 47);
            this.button4.TabIndex = 35;
            this.button4.Text = "load details";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // employee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.search);
            this.Name = "employee_details";
            this.Size = new System.Drawing.Size(1215, 636);
            this.Load += new System.EventHandler(this.reserve_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Telephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cardid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox position;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gender;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox city;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dob;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn address2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
    }
}
