namespace WindowsFormsApplication4
{
    partial class requests
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.requestDetails = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.s1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textbox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox5 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textbox7 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // requestDetails
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.requestDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.requestDetails.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.requestDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.requestDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.requestDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestDetails.DoubleBuffered = true;
            this.requestDetails.EnableHeadersVisualStyles = false;
            this.requestDetails.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.requestDetails.HeaderForeColor = System.Drawing.Color.Black;
            this.requestDetails.Location = new System.Drawing.Point(16, 68);
            this.requestDetails.Name = "requestDetails";
            this.requestDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.requestDetails.Size = new System.Drawing.Size(441, 372);
            this.requestDetails.TabIndex = 20;
            this.requestDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestDetails_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Customer name\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(478, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 28);
            this.label5.TabIndex = 32;
            this.label5.Text = "New request";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Address line 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Contact no.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Email";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(684, 546);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 39;
            this.button1.Text = "Delete Request";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Address line 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 43;
            this.label7.Text = "City";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 19);
            this.label8.TabIndex = 45;
            this.label8.Text = "Company name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 19);
            this.label9.TabIndex = 47;
            this.label9.Text = "Sevice type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "Search";
            // 
            // s1
            // 
            this.s1.Depth = 0;
            this.s1.Hint = "";
            this.s1.Location = new System.Drawing.Point(93, 22);
            this.s1.Margin = new System.Windows.Forms.Padding(4);
            this.s1.MouseState = MaterialSkin.MouseState.HOVER;
            this.s1.Name = "s1";
            this.s1.PasswordChar = '\0';
            this.s1.SelectedText = "";
            this.s1.SelectionLength = 0;
            this.s1.SelectionStart = 0;
            this.s1.Size = new System.Drawing.Size(219, 23);
            this.s1.TabIndex = 49;
            this.s1.UseSystemPasswordChar = false;
            this.s1.Click += new System.EventHandler(this.s1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(331, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 51;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(483, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 38);
            this.button3.TabIndex = 52;
            this.button3.Text = "Add Request";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(16, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 38);
            this.button4.TabIndex = 53;
            this.button4.Text = "Check Estimation";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(16, 546);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 38);
            this.button5.TabIndex = 54;
            this.button5.Text = "Request for Job";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textbox1
            // 
            this.textbox1.Depth = 0;
            this.textbox1.Hint = "";
            this.textbox1.Location = new System.Drawing.Point(625, 68);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox1.Name = "textbox1";
            this.textbox1.PasswordChar = '\0';
            this.textbox1.SelectedText = "";
            this.textbox1.SelectionLength = 0;
            this.textbox1.SelectionStart = 0;
            this.textbox1.Size = new System.Drawing.Size(219, 23);
            this.textbox1.TabIndex = 55;
            this.textbox1.Text = "Enter full name";
            this.textbox1.UseSystemPasswordChar = false;
            this.textbox1.Click += new System.EventHandler(this.textbox1_Click);
            this.textbox1.Enter += new System.EventHandler(this.textbox1_Enter);
            this.textbox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox1_KeyPress);
            this.textbox1.Leave += new System.EventHandler(this.textbox1_Leave);
            // 
            // textbox2
            // 
            this.textbox2.Depth = 0;
            this.textbox2.Hint = "";
            this.textbox2.Location = new System.Drawing.Point(625, 118);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox2.Name = "textbox2";
            this.textbox2.PasswordChar = '\0';
            this.textbox2.SelectedText = "";
            this.textbox2.SelectionLength = 0;
            this.textbox2.SelectionStart = 0;
            this.textbox2.Size = new System.Drawing.Size(219, 23);
            this.textbox2.TabIndex = 56;
            this.textbox2.Text = "Enter email";
            this.textbox2.UseSystemPasswordChar = false;
            this.textbox2.Click += new System.EventHandler(this.textbox2_Click);
            this.textbox2.Enter += new System.EventHandler(this.textbox2_Enter);
            this.textbox2.Leave += new System.EventHandler(this.textbox2_Leave);
            // 
            // textbox3
            // 
            this.textbox3.Depth = 0;
            this.textbox3.Hint = "";
            this.textbox3.Location = new System.Drawing.Point(625, 175);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox3.Name = "textbox3";
            this.textbox3.PasswordChar = '\0';
            this.textbox3.SelectedText = "";
            this.textbox3.SelectionLength = 0;
            this.textbox3.SelectionStart = 0;
            this.textbox3.Size = new System.Drawing.Size(219, 23);
            this.textbox3.TabIndex = 57;
            this.textbox3.Text = "Enter contact number";
            this.textbox3.UseSystemPasswordChar = false;
            this.textbox3.Click += new System.EventHandler(this.textbox3_Click);
            this.textbox3.Enter += new System.EventHandler(this.textbox3_Enter);
            this.textbox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox3_KeyPress);
            this.textbox3.Leave += new System.EventHandler(this.textbox3_Leave);
            // 
            // textbox4
            // 
            this.textbox4.Depth = 0;
            this.textbox4.Hint = "";
            this.textbox4.Location = new System.Drawing.Point(625, 228);
            this.textbox4.Margin = new System.Windows.Forms.Padding(4);
            this.textbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox4.Name = "textbox4";
            this.textbox4.PasswordChar = '\0';
            this.textbox4.SelectedText = "";
            this.textbox4.SelectionLength = 0;
            this.textbox4.SelectionStart = 0;
            this.textbox4.Size = new System.Drawing.Size(219, 23);
            this.textbox4.TabIndex = 58;
            this.textbox4.Text = "Enter address line 1";
            this.textbox4.UseSystemPasswordChar = false;
            this.textbox4.Enter += new System.EventHandler(this.textbox4_Enter);
            this.textbox4.Leave += new System.EventHandler(this.textbox4_Leave);
            // 
            // textbox5
            // 
            this.textbox5.Depth = 0;
            this.textbox5.Hint = "";
            this.textbox5.Location = new System.Drawing.Point(625, 274);
            this.textbox5.Margin = new System.Windows.Forms.Padding(4);
            this.textbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox5.Name = "textbox5";
            this.textbox5.PasswordChar = '\0';
            this.textbox5.SelectedText = "";
            this.textbox5.SelectionLength = 0;
            this.textbox5.SelectionStart = 0;
            this.textbox5.Size = new System.Drawing.Size(219, 23);
            this.textbox5.TabIndex = 59;
            this.textbox5.Text = "Enter address line 2";
            this.textbox5.UseSystemPasswordChar = false;
            this.textbox5.Enter += new System.EventHandler(this.textbox5_Enter);
            this.textbox5.Leave += new System.EventHandler(this.textbox5_Leave);
            // 
            // textbox6
            // 
            this.textbox6.Depth = 0;
            this.textbox6.Hint = "";
            this.textbox6.Location = new System.Drawing.Point(625, 322);
            this.textbox6.Margin = new System.Windows.Forms.Padding(4);
            this.textbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox6.Name = "textbox6";
            this.textbox6.PasswordChar = '\0';
            this.textbox6.SelectedText = "";
            this.textbox6.SelectionLength = 0;
            this.textbox6.SelectionStart = 0;
            this.textbox6.Size = new System.Drawing.Size(219, 23);
            this.textbox6.TabIndex = 60;
            this.textbox6.Text = "Enter city";
            this.textbox6.UseSystemPasswordChar = false;
            this.textbox6.Enter += new System.EventHandler(this.textbox6_Enter);
            this.textbox6.Leave += new System.EventHandler(this.textbox6_Leave);
            // 
            // textbox7
            // 
            this.textbox7.Depth = 0;
            this.textbox7.Hint = "";
            this.textbox7.Location = new System.Drawing.Point(625, 370);
            this.textbox7.Margin = new System.Windows.Forms.Padding(4);
            this.textbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox7.Name = "textbox7";
            this.textbox7.PasswordChar = '\0';
            this.textbox7.SelectedText = "";
            this.textbox7.SelectionLength = 0;
            this.textbox7.SelectionStart = 0;
            this.textbox7.Size = new System.Drawing.Size(219, 23);
            this.textbox7.TabIndex = 61;
            this.textbox7.Text = "Enter Company name";
            this.textbox7.UseSystemPasswordChar = false;
            this.textbox7.Enter += new System.EventHandler(this.textbox7_Enter);
            this.textbox7.Leave += new System.EventHandler(this.textbox7_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Fire Detection System",
            "Hydrant",
            "Alarms",
            "Request for trainee program"});
            this.comboBox1.Location = new System.Drawing.Point(625, 421);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 27);
            this.comboBox1.TabIndex = 63;
            this.comboBox1.Text = "Select service type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(776, 493);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(86, 38);
            this.button6.TabIndex = 64;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(371, 468);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(86, 38);
            this.button7.TabIndex = 65;
            this.button7.Text = "Table Load";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textbox7);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.s1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.requestDetails);
            this.Name = "requests";
            this.Size = new System.Drawing.Size(1022, 596);
            this.Load += new System.EventHandler(this.requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid requestDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private MaterialSkin.Controls.MaterialSingleLineTextField s1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}
