namespace WindowsFormsApplication4
{
    partial class vsr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Services = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Serv_No = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.vNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Note = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sCost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Next_Milage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Current_Milage = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rep_Id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label13 = new System.Windows.Forms.Label();
            this.vId = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.vehicleNo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.rNote = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Rep_Cost = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.V_Id = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Vehicle ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Service ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Vehicle No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 451);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Note";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.V_Id);
            this.groupBox1.Controls.Add(this.Services);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.Serv_No);
            this.groupBox1.Controls.Add(this.vNo);
            this.groupBox1.Controls.Add(this.Note);
            this.groupBox1.Controls.Add(this.sCost);
            this.groupBox1.Controls.Add(this.Next_Milage);
            this.groupBox1.Controls.Add(this.Current_Milage);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(54, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 547);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // Services
            // 
            this.Services.FormattingEnabled = true;
            this.Services.Items.AddRange(new object[] {
            "Full wash",
            "Body wash"});
            this.Services.Location = new System.Drawing.Point(290, 406);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(121, 24);
            this.Services.TabIndex = 61;
            this.Services.SelectedIndexChanged += new System.EventHandler(this.Services_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(60, 397);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 29);
            this.label12.TabIndex = 60;
            this.label12.Text = "Service Type";
            // 
            // Serv_No
            // 
            this.Serv_No.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Serv_No.Depth = 0;
            this.Serv_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Serv_No.Hint = "";
            this.Serv_No.Location = new System.Drawing.Point(208, 107);
            this.Serv_No.MouseState = MaterialSkin.MouseState.HOVER;
            this.Serv_No.Name = "Serv_No";
            this.Serv_No.PasswordChar = '\0';
            this.Serv_No.SelectedText = "";
            this.Serv_No.SelectionLength = 0;
            this.Serv_No.SelectionStart = 0;
            this.Serv_No.Size = new System.Drawing.Size(256, 28);
            this.Serv_No.TabIndex = 59;
            this.Serv_No.UseSystemPasswordChar = false;
            this.Serv_No.Click += new System.EventHandler(this.Serv_No_Click);
            // 
            // vNo
            // 
            this.vNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vNo.Depth = 0;
            this.vNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vNo.Hint = "";
            this.vNo.Location = new System.Drawing.Point(208, 186);
            this.vNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.vNo.Name = "vNo";
            this.vNo.PasswordChar = '\0';
            this.vNo.SelectedText = "";
            this.vNo.SelectionLength = 0;
            this.vNo.SelectionStart = 0;
            this.vNo.Size = new System.Drawing.Size(256, 28);
            this.vNo.TabIndex = 58;
            this.vNo.UseSystemPasswordChar = false;
            // 
            // Note
            // 
            this.Note.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Note.Depth = 0;
            this.Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note.Hint = "";
            this.Note.Location = new System.Drawing.Point(190, 451);
            this.Note.MouseState = MaterialSkin.MouseState.HOVER;
            this.Note.Name = "Note";
            this.Note.PasswordChar = '\0';
            this.Note.SelectedText = "";
            this.Note.SelectionLength = 0;
            this.Note.SelectionStart = 0;
            this.Note.Size = new System.Drawing.Size(256, 28);
            this.Note.TabIndex = 57;
            this.Note.UseSystemPasswordChar = false;
            // 
            // sCost
            // 
            this.sCost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sCost.Depth = 0;
            this.sCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCost.Hint = "";
            this.sCost.Location = new System.Drawing.Point(176, 498);
            this.sCost.MouseState = MaterialSkin.MouseState.HOVER;
            this.sCost.Name = "sCost";
            this.sCost.PasswordChar = '\0';
            this.sCost.SelectedText = "";
            this.sCost.SelectionLength = 0;
            this.sCost.SelectionStart = 0;
            this.sCost.Size = new System.Drawing.Size(256, 28);
            this.sCost.TabIndex = 56;
            this.sCost.UseSystemPasswordChar = false;
            // 
            // Next_Milage
            // 
            this.Next_Milage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Next_Milage.Depth = 0;
            this.Next_Milage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_Milage.Hint = "";
            this.Next_Milage.Location = new System.Drawing.Point(251, 335);
            this.Next_Milage.MouseState = MaterialSkin.MouseState.HOVER;
            this.Next_Milage.Name = "Next_Milage";
            this.Next_Milage.PasswordChar = '\0';
            this.Next_Milage.SelectedText = "";
            this.Next_Milage.SelectionLength = 0;
            this.Next_Milage.SelectionStart = 0;
            this.Next_Milage.Size = new System.Drawing.Size(195, 28);
            this.Next_Milage.TabIndex = 55;
            this.Next_Milage.UseSystemPasswordChar = false;
            // 
            // Current_Milage
            // 
            this.Current_Milage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Current_Milage.Depth = 0;
            this.Current_Milage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Milage.Hint = "";
            this.Current_Milage.Location = new System.Drawing.Point(265, 269);
            this.Current_Milage.MouseState = MaterialSkin.MouseState.HOVER;
            this.Current_Milage.Name = "Current_Milage";
            this.Current_Milage.PasswordChar = '\0';
            this.Current_Milage.SelectedText = "";
            this.Current_Milage.SelectionLength = 0;
            this.Current_Milage.SelectionStart = 0;
            this.Current_Milage.Size = new System.Drawing.Size(181, 28);
            this.Current_Milage.TabIndex = 54;
            this.Current_Milage.UseSystemPasswordChar = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(60, 498);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 334);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Next Milleage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 268);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 29);
            this.label8.TabIndex = 19;
            this.label8.Text = "Current Milleage";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.Rep_Id);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.vId);
            this.groupBox2.Controls.Add(this.vehicleNo);
            this.groupBox2.Controls.Add(this.rNote);
            this.groupBox2.Controls.Add(this.Rep_Cost);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(728, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 547);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Repair";
            // 
            // Rep_Id
            // 
            this.Rep_Id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rep_Id.Depth = 0;
            this.Rep_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rep_Id.Hint = "";
            this.Rep_Id.Location = new System.Drawing.Point(197, 44);
            this.Rep_Id.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rep_Id.Name = "Rep_Id";
            this.Rep_Id.PasswordChar = '\0';
            this.Rep_Id.SelectedText = "";
            this.Rep_Id.SelectionLength = 0;
            this.Rep_Id.SelectionStart = 0;
            this.Rep_Id.Size = new System.Drawing.Size(256, 28);
            this.Rep_Id.TabIndex = 61;
            this.Rep_Id.UseSystemPasswordChar = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 43);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 29);
            this.label13.TabIndex = 60;
            this.label13.Text = "Repair ID";
            // 
            // vId
            // 
            this.vId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vId.Depth = 0;
            this.vId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vId.Hint = "";
            this.vId.Location = new System.Drawing.Point(215, 126);
            this.vId.MouseState = MaterialSkin.MouseState.HOVER;
            this.vId.Name = "vId";
            this.vId.PasswordChar = '\0';
            this.vId.SelectedText = "";
            this.vId.SelectionLength = 0;
            this.vId.SelectionStart = 0;
            this.vId.Size = new System.Drawing.Size(236, 28);
            this.vId.TabIndex = 57;
            this.vId.UseSystemPasswordChar = false;
            // 
            // vehicleNo
            // 
            this.vehicleNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vehicleNo.Depth = 0;
            this.vehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleNo.Hint = "";
            this.vehicleNo.Location = new System.Drawing.Point(208, 176);
            this.vehicleNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.vehicleNo.Name = "vehicleNo";
            this.vehicleNo.PasswordChar = '\0';
            this.vehicleNo.SelectedText = "";
            this.vehicleNo.SelectionLength = 0;
            this.vehicleNo.SelectionStart = 0;
            this.vehicleNo.Size = new System.Drawing.Size(256, 28);
            this.vehicleNo.TabIndex = 56;
            this.vehicleNo.UseSystemPasswordChar = false;
            // 
            // rNote
            // 
            this.rNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rNote.Depth = 0;
            this.rNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rNote.Hint = "";
            this.rNote.Location = new System.Drawing.Point(210, 256);
            this.rNote.MouseState = MaterialSkin.MouseState.HOVER;
            this.rNote.Name = "rNote";
            this.rNote.PasswordChar = '\0';
            this.rNote.SelectedText = "";
            this.rNote.SelectionLength = 0;
            this.rNote.SelectionStart = 0;
            this.rNote.Size = new System.Drawing.Size(256, 28);
            this.rNote.TabIndex = 55;
            this.rNote.UseSystemPasswordChar = false;
            // 
            // Rep_Cost
            // 
            this.Rep_Cost.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Rep_Cost.Depth = 0;
            this.Rep_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rep_Cost.Hint = "";
            this.Rep_Cost.Location = new System.Drawing.Point(197, 464);
            this.Rep_Cost.MouseState = MaterialSkin.MouseState.HOVER;
            this.Rep_Cost.Name = "Rep_Cost";
            this.Rep_Cost.PasswordChar = '\0';
            this.Rep_Cost.SelectedText = "";
            this.Rep_Cost.SelectionLength = 0;
            this.Rep_Cost.SelectionStart = 0;
            this.Rep_Cost.Size = new System.Drawing.Size(256, 28);
            this.Rep_Cost.TabIndex = 54;
            this.Rep_Cost.UseSystemPasswordChar = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 463);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 29);
            this.label11.TabIndex = 19;
            this.label11.Text = "Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vehicle No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Note";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Vehicle ID";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(244, 723);
            this.bunifuCustomDataGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(877, 284);
            this.bunifuCustomDataGrid1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // add1
            // 
            this.add1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.add1.FlatAppearance.BorderSize = 0;
            this.add1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1.ForeColor = System.Drawing.Color.Silver;
            this.add1.Location = new System.Drawing.Point(213, 603);
            this.add1.Margin = new System.Windows.Forms.Padding(4);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(169, 47);
            this.add1.TabIndex = 26;
            this.add1.Text = "add";
            this.add1.UseVisualStyleBackColor = false;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // add2
            // 
            this.add2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.add2.FlatAppearance.BorderSize = 0;
            this.add2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.add2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add2.ForeColor = System.Drawing.Color.Silver;
            this.add2.Location = new System.Drawing.Point(910, 612);
            this.add2.Margin = new System.Windows.Forms.Padding(4);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(169, 47);
            this.add2.TabIndex = 27;
            this.add2.Text = "add";
            this.add2.UseVisualStyleBackColor = false;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // V_Id
            // 
            this.V_Id.DisplayMember = "vehicleID";
            this.V_Id.FormattingEnabled = true;
            this.V_Id.Location = new System.Drawing.Point(265, 34);
            this.V_Id.Name = "V_Id";
            this.V_Id.Size = new System.Drawing.Size(159, 24);
            this.V_Id.TabIndex = 72;
            this.V_Id.ValueMember = "vehicleID";
            this.V_Id.SelectedIndexChanged += new System.EventHandler(this.V_Id_SelectedIndexChanged);
            this.V_Id.TextChanged += new System.EventHandler(this.V_Id_TextChanged);
            this.V_Id.Click += new System.EventHandler(this.V_Id_Click);
            // 
            // vsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "vsr";
            this.Size = new System.Drawing.Size(1362, 1239);
            this.Load += new System.EventHandler(this.vsr_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private MaterialSkin.Controls.MaterialSingleLineTextField Serv_No;
        private MaterialSkin.Controls.MaterialSingleLineTextField vNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField Note;
        private MaterialSkin.Controls.MaterialSingleLineTextField sCost;
        private MaterialSkin.Controls.MaterialSingleLineTextField Next_Milage;
        private MaterialSkin.Controls.MaterialSingleLineTextField Current_Milage;
        private MaterialSkin.Controls.MaterialSingleLineTextField vId;
        private MaterialSkin.Controls.MaterialSingleLineTextField vehicleNo;
        private MaterialSkin.Controls.MaterialSingleLineTextField rNote;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rep_Cost;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox Services;
        private System.Windows.Forms.Button add2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Rep_Id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox V_Id;
    }
}
