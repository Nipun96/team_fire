namespace WindowsFormsApplication4
{
    partial class employee_manage
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
            this.label6 = new System.Windows.Forms.Label();
            this.txt13 = new System.Windows.Forms.GroupBox();
            this.address1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.city = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cardid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.address2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.nic = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button3 = new System.Windows.Forms.Button();
            this.image1 = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.female = new MaterialSkin.Controls.MaterialRadioButton();
            this.male = new MaterialSkin.Controls.MaterialRadioButton();
            this.dob1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.salary = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label14 = new System.Windows.Forms.Label();
            this.rpt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.rpot = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label16 = new System.Windows.Forms.Label();
            this.empid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(31, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "First Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt13
            // 
            this.txt13.AutoSize = true;
            this.txt13.BackColor = System.Drawing.Color.White;
            this.txt13.Controls.Add(this.empid);
            this.txt13.Controls.Add(this.label16);
            this.txt13.Controls.Add(this.rpot);
            this.txt13.Controls.Add(this.label15);
            this.txt13.Controls.Add(this.rpt);
            this.txt13.Controls.Add(this.label14);
            this.txt13.Controls.Add(this.salary);
            this.txt13.Controls.Add(this.label13);
            this.txt13.Controls.Add(this.address1);
            this.txt13.Controls.Add(this.city);
            this.txt13.Controls.Add(this.cardid);
            this.txt13.Controls.Add(this.tel);
            this.txt13.Controls.Add(this.lname);
            this.txt13.Controls.Add(this.address2);
            this.txt13.Controls.Add(this.nic);
            this.txt13.Controls.Add(this.fname);
            this.txt13.Controls.Add(this.button3);
            this.txt13.Controls.Add(this.image1);
            this.txt13.Controls.Add(this.save);
            this.txt13.Controls.Add(this.clear);
            this.txt13.Controls.Add(this.label12);
            this.txt13.Controls.Add(this.position);
            this.txt13.Controls.Add(this.label11);
            this.txt13.Controls.Add(this.label10);
            this.txt13.Controls.Add(this.label9);
            this.txt13.Controls.Add(this.label8);
            this.txt13.Controls.Add(this.label7);
            this.txt13.Controls.Add(this.label5);
            this.txt13.Controls.Add(this.female);
            this.txt13.Controls.Add(this.male);
            this.txt13.Controls.Add(this.dob1);
            this.txt13.Controls.Add(this.label4);
            this.txt13.Controls.Add(this.label3);
            this.txt13.Controls.Add(this.label2);
            this.txt13.Controls.Add(this.label1);
            this.txt13.Controls.Add(this.label6);
            this.txt13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.txt13.Location = new System.Drawing.Point(0, 3);
            this.txt13.Name = "txt13";
            this.txt13.Size = new System.Drawing.Size(1296, 1259);
            this.txt13.TabIndex = 27;
            this.txt13.TabStop = false;
            this.txt13.Text = "Employee Registration";
            this.txt13.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // address1
            // 
            this.address1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.address1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address1.HintForeColor = System.Drawing.Color.Empty;
            this.address1.HintText = "";
            this.address1.isPassword = false;
            this.address1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address1.LineIdleColor = System.Drawing.Color.Gray;
            this.address1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address1.LineThickness = 3;
            this.address1.Location = new System.Drawing.Point(314, 436);
            this.address1.Margin = new System.Windows.Forms.Padding(5);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(505, 41);
            this.address1.TabIndex = 66;
            this.address1.Text = "Enter address line 1";
            this.address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox9_OnValueChanged);
            this.address1.Enter += new System.EventHandler(this.address1_Enter);
            this.address1.Leave += new System.EventHandler(this.address1_Leave);
            // 
            // city
            // 
            this.city.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.city.HintForeColor = System.Drawing.Color.Empty;
            this.city.HintText = "";
            this.city.isPassword = false;
            this.city.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.city.LineIdleColor = System.Drawing.Color.Gray;
            this.city.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.city.LineThickness = 3;
            this.city.Location = new System.Drawing.Point(314, 611);
            this.city.Margin = new System.Windows.Forms.Padding(5);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(505, 41);
            this.city.TabIndex = 65;
            this.city.Text = "Enter city";
            this.city.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.city.OnValueChanged += new System.EventHandler(this.city_OnValueChanged);
            this.city.Enter += new System.EventHandler(this.city_Enter);
            this.city.Leave += new System.EventHandler(this.city_Leave);
            // 
            // cardid
            // 
            this.cardid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cardid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardid.HintForeColor = System.Drawing.Color.Empty;
            this.cardid.HintText = "";
            this.cardid.isPassword = false;
            this.cardid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid.LineIdleColor = System.Drawing.Color.Gray;
            this.cardid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.cardid.LineThickness = 3;
            this.cardid.Location = new System.Drawing.Point(314, 882);
            this.cardid.Margin = new System.Windows.Forms.Padding(5);
            this.cardid.Name = "cardid";
            this.cardid.Size = new System.Drawing.Size(505, 41);
            this.cardid.TabIndex = 63;
            this.cardid.Text = "Enter Card Id";
            this.cardid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cardid.Enter += new System.EventHandler(this.cardid_Enter);
            this.cardid.Leave += new System.EventHandler(this.cardid_Leave);
            // 
            // tel
            // 
            this.tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tel.HintForeColor = System.Drawing.Color.Empty;
            this.tel.HintText = "";
            this.tel.isPassword = false;
            this.tel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.tel.LineIdleColor = System.Drawing.Color.Gray;
            this.tel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.tel.LineThickness = 3;
            this.tel.Location = new System.Drawing.Point(314, 746);
            this.tel.Margin = new System.Windows.Forms.Padding(5);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(505, 41);
            this.tel.TabIndex = 62;
            this.tel.Text = "Enter Telephone number";
            this.tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tel.Enter += new System.EventHandler(this.tel_Enter);
            this.tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tel_KeyPress);
            this.tel.Leave += new System.EventHandler(this.tel_Leave);
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname.LineIdleColor = System.Drawing.Color.Gray;
            this.lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(314, 164);
            this.lname.Margin = new System.Windows.Forms.Padding(5);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(505, 41);
            this.lname.TabIndex = 61;
            this.lname.Text = "Last Name";
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lname.OnValueChanged += new System.EventHandler(this.lname_OnValueChanged);
            this.lname.Enter += new System.EventHandler(this.lname_Enter);
            this.lname.Leave += new System.EventHandler(this.lname_Leave);
            // 
            // address2
            // 
            this.address2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.address2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address2.HintForeColor = System.Drawing.Color.Empty;
            this.address2.HintText = "";
            this.address2.isPassword = false;
            this.address2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address2.LineIdleColor = System.Drawing.Color.Gray;
            this.address2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.address2.LineThickness = 3;
            this.address2.Location = new System.Drawing.Point(314, 525);
            this.address2.Margin = new System.Windows.Forms.Padding(5);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(505, 41);
            this.address2.TabIndex = 59;
            this.address2.Text = "Enter address line 2";
            this.address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.address2.Enter += new System.EventHandler(this.address2_Enter);
            this.address2.Leave += new System.EventHandler(this.address2_Leave);
            // 
            // nic
            // 
            this.nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.nic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nic.HintForeColor = System.Drawing.Color.Empty;
            this.nic.HintText = "";
            this.nic.isPassword = false;
            this.nic.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic.LineIdleColor = System.Drawing.Color.Gray;
            this.nic.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.nic.LineThickness = 3;
            this.nic.Location = new System.Drawing.Point(314, 675);
            this.nic.Margin = new System.Windows.Forms.Padding(5);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(505, 41);
            this.nic.TabIndex = 60;
            this.nic.Text = "Enter nic number";
            this.nic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nic.OnValueChanged += new System.EventHandler(this.nic_OnValueChanged);
            this.nic.Enter += new System.EventHandler(this.nic_Enter);
            this.nic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nic_KeyPress);
            this.nic.Leave += new System.EventHandler(this.nic_Leave);
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname.LineIdleColor = System.Drawing.Color.Gray;
            this.fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(314, 66);
            this.fname.Margin = new System.Windows.Forms.Padding(5);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(505, 41);
            this.fname.TabIndex = 58;
            this.fname.Text = "First Name";
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fname.OnValueChanged += new System.EventHandler(this.fname_OnValueChanged);
            this.fname.Enter += new System.EventHandler(this.fname_Enter);
            this.fname.Leave += new System.EventHandler(this.fname_Leave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(946, 371);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(237, 47);
            this.button3.TabIndex = 57;
            this.button3.Text = "Browse";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // image1
            // 
            this.image1.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_Member_100;
            this.image1.Location = new System.Drawing.Point(946, 66);
            this.image1.Name = "image1";
            this.image1.Size = new System.Drawing.Size(232, 224);
            this.image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image1.TabIndex = 56;
            this.image1.TabStop = false;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.Color.Silver;
            this.save.Location = new System.Drawing.Point(946, 611);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(237, 47);
            this.save.TabIndex = 55;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.clear.ForeColor = System.Drawing.Color.Silver;
            this.clear.Location = new System.Drawing.Point(946, 727);
            this.clear.Margin = new System.Windows.Forms.Padding(4);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(237, 47);
            this.clear.TabIndex = 54;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(32, 882);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 28);
            this.label12.TabIndex = 52;
            this.label12.Text = "Card ID";
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Items.AddRange(new object[] {
            "Engineer",
            "cleark"});
            this.position.Location = new System.Drawing.Point(314, 822);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(507, 27);
            this.position.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(32, 819);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 28);
            this.label11.TabIndex = 49;
            this.label11.Text = "position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(31, 746);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 28);
            this.label10.TabIndex = 47;
            this.label10.Text = "Telephone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(32, 611);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 28);
            this.label9.TabIndex = 43;
            this.label9.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(31, 675);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 28);
            this.label8.TabIndex = 42;
            this.label8.Text = "NIC Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(31, 525);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 28);
            this.label7.TabIndex = 41;
            this.label7.Text = "Address Line 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(31, 436);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 28);
            this.label5.TabIndex = 38;
            this.label5.Text = "Address Line 1";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Depth = 0;
            this.female.Font = new System.Drawing.Font("Roboto", 10F);
            this.female.Location = new System.Drawing.Point(521, 360);
            this.female.Margin = new System.Windows.Forms.Padding(0);
            this.female.MouseLocation = new System.Drawing.Point(-1, -1);
            this.female.MouseState = MaterialSkin.MouseState.HOVER;
            this.female.Name = "female";
            this.female.Ripple = true;
            this.female.Size = new System.Drawing.Size(87, 30);
            this.female.TabIndex = 37;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Depth = 0;
            this.male.Font = new System.Drawing.Font("Roboto", 10F);
            this.male.Location = new System.Drawing.Point(314, 360);
            this.male.Margin = new System.Windows.Forms.Padding(0);
            this.male.MouseLocation = new System.Drawing.Point(-1, -1);
            this.male.MouseState = MaterialSkin.MouseState.HOVER;
            this.male.Name = "male";
            this.male.Ripple = true;
            this.male.Size = new System.Drawing.Size(68, 30);
            this.male.TabIndex = 36;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.materialRadioButton1_CheckedChanged);
            // 
            // dob1
            // 
            this.dob1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.dob1.BorderRadius = 0;
            this.dob1.ForeColor = System.Drawing.Color.White;
            this.dob1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dob1.FormatCustom = null;
            this.dob1.Location = new System.Drawing.Point(314, 241);
            this.dob1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dob1.Name = "dob1";
            this.dob1.Size = new System.Drawing.Size(518, 71);
            this.dob1.TabIndex = 35;
            this.dob1.Value = new System.DateTime(2017, 5, 28, 5, 32, 30, 545);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 426);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 348);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 31;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(31, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "Date Of Birth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(31, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Last Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(32, 963);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 28);
            this.label13.TabIndex = 67;
            this.label13.Text = "Basic salary";
            // 
            // salary
            // 
            this.salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salary.HintForeColor = System.Drawing.Color.Empty;
            this.salary.HintText = "";
            this.salary.isPassword = false;
            this.salary.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.salary.LineIdleColor = System.Drawing.Color.Gray;
            this.salary.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.salary.LineThickness = 3;
            this.salary.Location = new System.Drawing.Point(314, 963);
            this.salary.Margin = new System.Windows.Forms.Padding(5);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(505, 41);
            this.salary.TabIndex = 68;
            this.salary.Text = "Enter Basic salary";
            this.salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salary.Enter += new System.EventHandler(this.salary_Enter);
            this.salary.Leave += new System.EventHandler(this.salary_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(32, 1036);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(167, 28);
            this.label14.TabIndex = 69;
            this.label14.Text = "Rate Per Hour";
            // 
            // rpt
            // 
            this.rpt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpt.HintForeColor = System.Drawing.Color.Empty;
            this.rpt.HintText = "";
            this.rpt.isPassword = false;
            this.rpt.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rpt.LineIdleColor = System.Drawing.Color.Gray;
            this.rpt.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rpt.LineThickness = 3;
            this.rpt.Location = new System.Drawing.Point(314, 1036);
            this.rpt.Margin = new System.Windows.Forms.Padding(5);
            this.rpt.Name = "rpt";
            this.rpt.Size = new System.Drawing.Size(505, 41);
            this.rpt.TabIndex = 70;
            this.rpt.Text = "Enter rate per hour";
            this.rpt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rpt.OnValueChanged += new System.EventHandler(this.rpt_OnValueChanged);
            this.rpt.Enter += new System.EventHandler(this.rpt_Enter);
            this.rpt.Leave += new System.EventHandler(this.rpt_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(32, 1122);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 28);
            this.label15.TabIndex = 71;
            this.label15.Text = "Rate Per OT Hour";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // rpot
            // 
            this.rpot.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rpot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rpot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rpot.HintForeColor = System.Drawing.Color.Empty;
            this.rpot.HintText = "";
            this.rpot.isPassword = false;
            this.rpot.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rpot.LineIdleColor = System.Drawing.Color.Gray;
            this.rpot.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.rpot.LineThickness = 3;
            this.rpot.Location = new System.Drawing.Point(316, 1122);
            this.rpot.Margin = new System.Windows.Forms.Padding(5);
            this.rpot.Name = "rpot";
            this.rpot.Size = new System.Drawing.Size(505, 41);
            this.rpot.TabIndex = 72;
            this.rpot.Text = "Enter rate per ot hour";
            this.rpot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rpot.Enter += new System.EventHandler(this.rpot_Enter);
            this.rpot.Leave += new System.EventHandler(this.rpot_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(32, 1189);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(158, 28);
            this.label16.TabIndex = 73;
            this.label16.Text = "Employee Id";
            // 
            // empid
            // 
            this.empid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.empid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empid.HintForeColor = System.Drawing.Color.Empty;
            this.empid.HintText = "";
            this.empid.isPassword = false;
            this.empid.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.empid.LineIdleColor = System.Drawing.Color.Gray;
            this.empid.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.empid.LineThickness = 3;
            this.empid.Location = new System.Drawing.Point(314, 1189);
            this.empid.Margin = new System.Windows.Forms.Padding(5);
            this.empid.Name = "empid";
            this.empid.Size = new System.Drawing.Size(505, 41);
            this.empid.TabIndex = 74;
            this.empid.Text = "Enter employee id";
            this.empid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empid.OnValueChanged += new System.EventHandler(this.empid_OnValueChanged);
            this.empid.Enter += new System.EventHandler(this.empid_Enter);
            this.empid.Leave += new System.EventHandler(this.empid_Leave);
            // 
            // employee_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.txt13);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "employee_manage";
            this.Size = new System.Drawing.Size(1314, 1265);
            this.Load += new System.EventHandler(this.status_Load);
            this.txt13.ResumeLayout(false);
            this.txt13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox txt13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRadioButton female;
        private MaterialSkin.Controls.MaterialRadioButton male;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private Bunifu.Framework.UI.BunifuDatepicker dob1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox image1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox city;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cardid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox nic;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox salary;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rpt;
        private System.Windows.Forms.Label label14;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rpot;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empid;
        private System.Windows.Forms.Label label16;
    }
}
