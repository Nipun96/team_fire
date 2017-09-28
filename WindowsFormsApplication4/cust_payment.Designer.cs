namespace WindowsFormsApplication4
{
    partial class cust_payment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AcceptedPayment = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.paysearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox3 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox4 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox6 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.paymentTable = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.paymentsearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxest = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AcceptedPayment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AcceptedPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AcceptedPayment.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.AcceptedPayment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AcceptedPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AcceptedPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AcceptedPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcceptedPayment.DoubleBuffered = true;
            this.AcceptedPayment.EnableHeadersVisualStyles = false;
            this.AcceptedPayment.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.AcceptedPayment.HeaderForeColor = System.Drawing.Color.Black;
            this.AcceptedPayment.Location = new System.Drawing.Point(3, 86);
            this.AcceptedPayment.Name = "AcceptedPayment";
            this.AcceptedPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AcceptedPayment.Size = new System.Drawing.Size(467, 178);
            this.AcceptedPayment.TabIndex = 19;
            this.AcceptedPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(528, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Generate Invoice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(383, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 54;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paysearch
            // 
            this.paysearch.Depth = 0;
            this.paysearch.Hint = "";
            this.paysearch.Location = new System.Drawing.Point(145, 57);
            this.paysearch.Margin = new System.Windows.Forms.Padding(4);
            this.paysearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.paysearch.Name = "paysearch";
            this.paysearch.PasswordChar = '\0';
            this.paysearch.SelectedText = "";
            this.paysearch.SelectionLength = 0;
            this.paysearch.SelectionStart = 0;
            this.paysearch.Size = new System.Drawing.Size(219, 23);
            this.paysearch.TabIndex = 52;
            this.paysearch.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 28);
            this.label5.TabIndex = 55;
            this.label5.Text = "Accepted payments";
            // 
            // textbox3
            // 
            this.textbox3.Depth = 0;
            this.textbox3.Hint = "";
            this.textbox3.Location = new System.Drawing.Point(672, 86);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox3.Name = "textbox3";
            this.textbox3.PasswordChar = '\0';
            this.textbox3.SelectedText = "";
            this.textbox3.SelectionLength = 0;
            this.textbox3.SelectionStart = 0;
            this.textbox3.Size = new System.Drawing.Size(219, 23);
            this.textbox3.TabIndex = 69;
            this.textbox3.UseSystemPasswordChar = false;
            this.textbox3.Click += new System.EventHandler(this.textbox3_Click);
            this.textbox3.Enter += new System.EventHandler(this.textbox3_Enter);
            this.textbox3.Leave += new System.EventHandler(this.textbox3_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(523, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 68;
            this.label6.Text = "Customer name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textbox2
            // 
            this.textbox2.Depth = 0;
            this.textbox2.Hint = "";
            this.textbox2.Location = new System.Drawing.Point(672, 139);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox2.Name = "textbox2";
            this.textbox2.PasswordChar = '\0';
            this.textbox2.SelectedText = "";
            this.textbox2.SelectionLength = 0;
            this.textbox2.SelectionStart = 0;
            this.textbox2.Size = new System.Drawing.Size(219, 23);
            this.textbox2.TabIndex = 71;
            this.textbox2.UseSystemPasswordChar = false;
            this.textbox2.Click += new System.EventHandler(this.textbox2_Click);
            this.textbox2.Enter += new System.EventHandler(this.textbox2_Enter);
            this.textbox2.Leave += new System.EventHandler(this.textbox2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(523, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Start Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbox1
            // 
            this.textbox1.Depth = 0;
            this.textbox1.Hint = "";
            this.textbox1.Location = new System.Drawing.Point(672, 194);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox1.Name = "textbox1";
            this.textbox1.PasswordChar = '\0';
            this.textbox1.SelectedText = "";
            this.textbox1.SelectionLength = 0;
            this.textbox1.SelectionStart = 0;
            this.textbox1.Size = new System.Drawing.Size(219, 23);
            this.textbox1.TabIndex = 73;
            this.textbox1.UseSystemPasswordChar = false;
            this.textbox1.Click += new System.EventHandler(this.textbox1_Click);
            this.textbox1.Enter += new System.EventHandler(this.textbox1_Enter);
            this.textbox1.Leave += new System.EventHandler(this.textbox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(523, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "End date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textbox4
            // 
            this.textbox4.Depth = 0;
            this.textbox4.Hint = "";
            this.textbox4.Location = new System.Drawing.Point(672, 279);
            this.textbox4.Margin = new System.Windows.Forms.Padding(4);
            this.textbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox4.Name = "textbox4";
            this.textbox4.PasswordChar = '\0';
            this.textbox4.SelectedText = "";
            this.textbox4.SelectionLength = 0;
            this.textbox4.SelectionStart = 0;
            this.textbox4.Size = new System.Drawing.Size(219, 23);
            this.textbox4.TabIndex = 75;
            this.textbox4.UseSystemPasswordChar = false;
            this.textbox4.Click += new System.EventHandler(this.textbox4_Click);
            this.textbox4.Enter += new System.EventHandler(this.textbox4_Enter);
            this.textbox4.Leave += new System.EventHandler(this.textbox4_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(523, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Amount (Rs.)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(523, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Method";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textbox6
            // 
            this.textbox6.Depth = 0;
            this.textbox6.Hint = "";
            this.textbox6.Location = new System.Drawing.Point(672, 358);
            this.textbox6.Margin = new System.Windows.Forms.Padding(4);
            this.textbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.textbox6.Name = "textbox6";
            this.textbox6.PasswordChar = '\0';
            this.textbox6.SelectedText = "";
            this.textbox6.SelectionLength = 0;
            this.textbox6.SelectionStart = 0;
            this.textbox6.Size = new System.Drawing.Size(219, 23);
            this.textbox6.TabIndex = 79;
            this.textbox6.UseSystemPasswordChar = false;
            this.textbox6.Click += new System.EventHandler(this.textbox6_Click);
            this.textbox6.Enter += new System.EventHandler(this.textbox6_Enter);
            this.textbox6.Leave += new System.EventHandler(this.textbox6_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(523, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 78;
            this.label7.Text = "To be paid";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(522, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 28);
            this.label8.TabIndex = 80;
            this.label8.Text = "New Payment";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(648, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 38);
            this.button3.TabIndex = 81;
            this.button3.Text = "Calculate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.comboBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Other..."});
            this.comboBox1.Location = new System.Drawing.Point(672, 323);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(219, 28);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Enter += new System.EventHandler(this.comboBox1_Enter);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(528, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 38);
            this.button5.TabIndex = 83;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // paymentTable
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paymentTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.paymentTable.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.paymentTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.paymentTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.paymentTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.paymentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentTable.DoubleBuffered = true;
            this.paymentTable.EnableHeadersVisualStyles = false;
            this.paymentTable.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.paymentTable.HeaderForeColor = System.Drawing.Color.Black;
            this.paymentTable.Location = new System.Drawing.Point(4, 358);
            this.paymentTable.Name = "paymentTable";
            this.paymentTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.paymentTable.Size = new System.Drawing.Size(466, 178);
            this.paymentTable.TabIndex = 84;
            this.paymentTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentTable_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 28);
            this.label9.TabIndex = 87;
            this.label9.Text = "Payments";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(383, 318);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(87, 31);
            this.button6.TabIndex = 86;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // paymentsearch
            // 
            this.paymentsearch.Depth = 0;
            this.paymentsearch.Hint = "";
            this.paymentsearch.Location = new System.Drawing.Point(145, 326);
            this.paymentsearch.Margin = new System.Windows.Forms.Padding(4);
            this.paymentsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.paymentsearch.Name = "paymentsearch";
            this.paymentsearch.PasswordChar = '\0';
            this.paymentsearch.SelectedText = "";
            this.paymentsearch.SelectionLength = 0;
            this.paymentsearch.SelectionStart = 0;
            this.paymentsearch.Size = new System.Drawing.Size(219, 23);
            this.paymentsearch.TabIndex = 85;
            this.paymentsearch.UseSystemPasswordChar = false;
            // 
            // textboxest
            // 
            this.textboxest.Depth = 0;
            this.textboxest.Hint = "";
            this.textboxest.Location = new System.Drawing.Point(672, 241);
            this.textboxest.Margin = new System.Windows.Forms.Padding(4);
            this.textboxest.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxest.Name = "textboxest";
            this.textboxest.PasswordChar = '\0';
            this.textboxest.SelectedText = "";
            this.textboxest.SelectionLength = 0;
            this.textboxest.SelectionStart = 0;
            this.textboxest.Size = new System.Drawing.Size(219, 23);
            this.textboxest.TabIndex = 89;
            this.textboxest.UseSystemPasswordChar = false;
            this.textboxest.Click += new System.EventHandler(this.textboxest_Click);
            this.textboxest.Enter += new System.EventHandler(this.textboxest_Enter);
            this.textboxest.Leave += new System.EventHandler(this.textboxest_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(514, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 19);
            this.label10.TabIndex = 88;
            this.label10.Text = "Estimated amount";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(779, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 38);
            this.button4.TabIndex = 90;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.Silver;
            this.button10.Location = new System.Drawing.Point(4, 49);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(40, 31);
            this.button10.TabIndex = 91;
            this.button10.Text = "L";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Silver;
            this.button7.Location = new System.Drawing.Point(17, 323);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 31);
            this.button7.TabIndex = 92;
            this.button7.Text = "L";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // cust_payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textboxest);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.paymentsearch);
            this.Controls.Add(this.paymentTable);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.paysearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AcceptedPayment);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "cust_payment";
            this.Size = new System.Drawing.Size(1533, 825);
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AcceptedPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid AcceptedPayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialSingleLineTextField paysearch;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialSingleLineTextField textbox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid paymentTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private MaterialSkin.Controls.MaterialSingleLineTextField paymentsearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxest;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
    }
}
