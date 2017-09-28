namespace WindowsFormsApplication4
{
    partial class Employee_attendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.serach1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.telephone1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address11 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cardid1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.position1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nic1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gender1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lname1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dob1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fname1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.table13 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.table123 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table123)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(524, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "view attendance details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serach1
            // 
            this.serach1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.serach1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serach1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serach1.HintForeColor = System.Drawing.Color.Empty;
            this.serach1.HintText = "";
            this.serach1.isPassword = false;
            this.serach1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.serach1.LineIdleColor = System.Drawing.Color.Gray;
            this.serach1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.serach1.LineThickness = 3;
            this.serach1.Location = new System.Drawing.Point(57, 69);
            this.serach1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.serach1.Name = "serach1";
            this.serach1.Size = new System.Drawing.Size(404, 47);
            this.serach1.TabIndex = 32;
            this.serach1.Text = "Search card id";
            this.serach1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.serach1.Enter += new System.EventHandler(this.serach1_Enter);
            this.serach1.Leave += new System.EventHandler(this.serach1_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(57, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1186, 376);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.telephone1);
            this.groupBox4.Controls.Add(this.address11);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(785, 53);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 110);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Info";
            // 
            // telephone1
            // 
            this.telephone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.telephone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.telephone1.HintForeColor = System.Drawing.Color.Empty;
            this.telephone1.HintText = "";
            this.telephone1.isPassword = false;
            this.telephone1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.telephone1.LineIdleColor = System.Drawing.Color.Gray;
            this.telephone1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.telephone1.LineThickness = 3;
            this.telephone1.Location = new System.Drawing.Point(151, 74);
            this.telephone1.Margin = new System.Windows.Forms.Padding(4);
            this.telephone1.Name = "telephone1";
            this.telephone1.Size = new System.Drawing.Size(131, 26);
            this.telephone1.TabIndex = 39;
            this.telephone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // address11
            // 
            this.address11.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address11.HintForeColor = System.Drawing.Color.Empty;
            this.address11.HintText = "";
            this.address11.isPassword = false;
            this.address11.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address11.LineIdleColor = System.Drawing.Color.Gray;
            this.address11.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address11.LineThickness = 3;
            this.address11.Location = new System.Drawing.Point(151, 45);
            this.address11.Margin = new System.Windows.Forms.Padding(4);
            this.address11.Name = "address11";
            this.address11.Size = new System.Drawing.Size(131, 26);
            this.address11.TabIndex = 38;
            this.address11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 80);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(7, 45);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Address1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cardid1);
            this.groupBox3.Controls.Add(this.position1);
            this.groupBox3.Controls.Add(this.nic1);
            this.groupBox3.Controls.Add(this.gender1);
            this.groupBox3.Controls.Add(this.lname1);
            this.groupBox3.Controls.Add(this.dob1);
            this.groupBox3.Controls.Add(this.fname1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(448, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "General Info";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cardid1
            // 
            this.cardid1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardid1.HintForeColor = System.Drawing.Color.Empty;
            this.cardid1.HintText = "";
            this.cardid1.isPassword = false;
            this.cardid1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid1.LineIdleColor = System.Drawing.Color.Gray;
            this.cardid1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid1.LineThickness = 3;
            this.cardid1.Location = new System.Drawing.Point(128, 254);
            this.cardid1.Margin = new System.Windows.Forms.Padding(4);
            this.cardid1.Name = "cardid1";
            this.cardid1.Size = new System.Drawing.Size(131, 26);
            this.cardid1.TabIndex = 37;
            this.cardid1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // position1
            // 
            this.position1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.position1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.position1.HintForeColor = System.Drawing.Color.Empty;
            this.position1.HintText = "";
            this.position1.isPassword = false;
            this.position1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.position1.LineIdleColor = System.Drawing.Color.Gray;
            this.position1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.position1.LineThickness = 3;
            this.position1.Location = new System.Drawing.Point(128, 214);
            this.position1.Margin = new System.Windows.Forms.Padding(4);
            this.position1.Name = "position1";
            this.position1.Size = new System.Drawing.Size(131, 26);
            this.position1.TabIndex = 36;
            this.position1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nic1
            // 
            this.nic1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nic1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nic1.HintForeColor = System.Drawing.Color.Empty;
            this.nic1.HintText = "";
            this.nic1.isPassword = false;
            this.nic1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic1.LineIdleColor = System.Drawing.Color.Gray;
            this.nic1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic1.LineThickness = 3;
            this.nic1.Location = new System.Drawing.Point(128, 182);
            this.nic1.Margin = new System.Windows.Forms.Padding(4);
            this.nic1.Name = "nic1";
            this.nic1.Size = new System.Drawing.Size(131, 26);
            this.nic1.TabIndex = 35;
            this.nic1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // gender1
            // 
            this.gender1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gender1.HintForeColor = System.Drawing.Color.Empty;
            this.gender1.HintText = "";
            this.gender1.isPassword = false;
            this.gender1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.gender1.LineIdleColor = System.Drawing.Color.Gray;
            this.gender1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.gender1.LineThickness = 3;
            this.gender1.Location = new System.Drawing.Point(128, 145);
            this.gender1.Margin = new System.Windows.Forms.Padding(4);
            this.gender1.Name = "gender1";
            this.gender1.Size = new System.Drawing.Size(131, 26);
            this.gender1.TabIndex = 34;
            this.gender1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lname1
            // 
            this.lname1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname1.HintForeColor = System.Drawing.Color.Empty;
            this.lname1.HintText = "";
            this.lname1.isPassword = false;
            this.lname1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname1.LineIdleColor = System.Drawing.Color.Gray;
            this.lname1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname1.LineThickness = 3;
            this.lname1.Location = new System.Drawing.Point(128, 77);
            this.lname1.Margin = new System.Windows.Forms.Padding(4);
            this.lname1.Name = "lname1";
            this.lname1.Size = new System.Drawing.Size(131, 26);
            this.lname1.TabIndex = 33;
            this.lname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dob1
            // 
            this.dob1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.dob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dob1.HintForeColor = System.Drawing.Color.Empty;
            this.dob1.HintText = "";
            this.dob1.isPassword = false;
            this.dob1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dob1.LineIdleColor = System.Drawing.Color.Gray;
            this.dob1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dob1.LineThickness = 3;
            this.dob1.Location = new System.Drawing.Point(128, 117);
            this.dob1.Margin = new System.Windows.Forms.Padding(4);
            this.dob1.Name = "dob1";
            this.dob1.Size = new System.Drawing.Size(131, 26);
            this.dob1.TabIndex = 32;
            this.dob1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fname1
            // 
            this.fname1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname1.HintForeColor = System.Drawing.Color.Empty;
            this.fname1.HintText = "";
            this.fname1.isPassword = false;
            this.fname1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname1.LineIdleColor = System.Drawing.Color.Gray;
            this.fname1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname1.LineThickness = 3;
            this.fname1.Location = new System.Drawing.Point(127, 42);
            this.fname1.Margin = new System.Windows.Forms.Padding(4);
            this.fname1.Name = "fname1";
            this.fname1.Size = new System.Drawing.Size(131, 26);
            this.fname1.TabIndex = 31;
            this.fname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fname1.OnValueChanged += new System.EventHandler(this.fname1_OnValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(7, 257);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 23);
            this.label7.TabIndex = 30;
            this.label7.Text = "Card ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(7, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 29;
            this.label5.Text = "Postion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(7, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Birthday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(7, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "NIC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 45);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "First Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.table123);
            this.groupBox2.Controls.Add(this.table13);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 636);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1186, 355);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // table13
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.table13.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.table13.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.table13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table13.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table13.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.table13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table13.DoubleBuffered = true;
            this.table13.EnableHeadersVisualStyles = false;
            this.table13.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.table13.HeaderForeColor = System.Drawing.Color.White;
            this.table13.Location = new System.Drawing.Point(7, 38);
            this.table13.Margin = new System.Windows.Forms.Padding(4);
            this.table13.Name = "table13";
            this.table13.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table13.Size = new System.Drawing.Size(1164, 284);
            this.table13.TabIndex = 30;
            this.table13.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(794, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(330, 47);
            this.button2.TabIndex = 36;
            this.button2.Text = "view employee details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // table123
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.table123.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.table123.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.table123.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table123.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table123.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.table123.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table123.DoubleBuffered = true;
            this.table123.EnableHeadersVisualStyles = false;
            this.table123.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.table123.HeaderForeColor = System.Drawing.Color.White;
            this.table123.Location = new System.Drawing.Point(0, 38);
            this.table123.Margin = new System.Windows.Forms.Padding(4);
            this.table123.Name = "table123";
            this.table123.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.table123.Size = new System.Drawing.Size(1164, 284);
            this.table123.TabIndex = 31;
            this.table123.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table123_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_Member_100;
            this.pictureBox1.Location = new System.Drawing.Point(80, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // Employee_attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serach1);
            this.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Employee_attendance";
            this.Size = new System.Drawing.Size(2384, 1237);
            this.Load += new System.EventHandler(this.Employee_attendance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table123)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox serach1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox telephone1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cardid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox position1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nic1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gender1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox dob1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid table123;
    }
}
