namespace WindowsFormsApplication4
{
    partial class vreserve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.duration = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.projectName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.projectID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.endDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.vehicle_reserve = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_reserve)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "vehicleID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(56, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 24);
            this.comboBox1.TabIndex = 71;
            this.comboBox1.ValueMember = "vehicleID";
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // duration
            // 
            this.duration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.duration.Depth = 0;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Hint = "";
            this.duration.Location = new System.Drawing.Point(699, 218);
            this.duration.MouseState = MaterialSkin.MouseState.HOVER;
            this.duration.Name = "duration";
            this.duration.PasswordChar = '\0';
            this.duration.SelectedText = "";
            this.duration.SelectionLength = 0;
            this.duration.SelectionStart = 0;
            this.duration.Size = new System.Drawing.Size(231, 28);
            this.duration.TabIndex = 70;
            this.duration.UseSystemPasswordChar = false;
            // 
            // projectName
            // 
            this.projectName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.projectName.Depth = 0;
            this.projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectName.Hint = "";
            this.projectName.Location = new System.Drawing.Point(317, 218);
            this.projectName.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectName.Name = "projectName";
            this.projectName.PasswordChar = '\0';
            this.projectName.SelectedText = "";
            this.projectName.SelectionLength = 0;
            this.projectName.SelectionStart = 0;
            this.projectName.Size = new System.Drawing.Size(212, 28);
            this.projectName.TabIndex = 69;
            this.projectName.UseSystemPasswordChar = false;
            // 
            // projectID
            // 
            this.projectID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.projectID.Depth = 0;
            this.projectID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectID.Hint = "";
            this.projectID.Location = new System.Drawing.Point(52, 218);
            this.projectID.MouseState = MaterialSkin.MouseState.HOVER;
            this.projectID.Name = "projectID";
            this.projectID.PasswordChar = '\0';
            this.projectID.SelectedText = "";
            this.projectID.SelectionLength = 0;
            this.projectID.SelectionStart = 0;
            this.projectID.Size = new System.Drawing.Size(196, 28);
            this.projectID.TabIndex = 68;
            this.projectID.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(317, 423);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 47);
            this.button2.TabIndex = 67;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(952, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 47);
            this.button1.TabIndex = 66;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 29);
            this.label6.TabIndex = 58;
            this.label6.Text = "Vehicle ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 29);
            this.label4.TabIndex = 63;
            this.label4.Text = "End Date";
            // 
            // startDate
            // 
            this.startDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.startDate.BorderRadius = 0;
            this.startDate.ForeColor = System.Drawing.Color.White;
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startDate.FormatCustom = null;
            this.startDate.Location = new System.Drawing.Point(329, 87);
            this.startDate.Margin = new System.Windows.Forms.Padding(6);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(235, 52);
            this.startDate.TabIndex = 64;
            this.startDate.Value = new System.DateTime(2017, 8, 25, 0, 2, 10, 317);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(703, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 65;
            this.label5.Text = "Duration";
            // 
            // endDate
            // 
            this.endDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.endDate.BorderRadius = 0;
            this.endDate.ForeColor = System.Drawing.Color.White;
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endDate.FormatCustom = null;
            this.endDate.Location = new System.Drawing.Point(699, 87);
            this.endDate.Margin = new System.Windows.Forms.Padding(6);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(219, 52);
            this.endDate.TabIndex = 61;
            this.endDate.Value = new System.DateTime(2017, 8, 25, 0, 2, 10, 317);
            this.endDate.onValueChanged += new System.EventHandler(this.endDate_onValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Project ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Project Name";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(52, 301);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1075, 26);
            this.bunifuSeparator1.TabIndex = 72;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // vehicle_reserve
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vehicle_reserve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.vehicle_reserve.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.vehicle_reserve.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vehicle_reserve.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vehicle_reserve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.vehicle_reserve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicle_reserve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.projectIDDataGridViewTextBoxColumn,
            this.projectNameDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn});
            this.vehicle_reserve.DoubleBuffered = true;
            this.vehicle_reserve.EnableHeadersVisualStyles = false;
            this.vehicle_reserve.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.vehicle_reserve.HeaderForeColor = System.Drawing.Color.Black;
            this.vehicle_reserve.Location = new System.Drawing.Point(278, 478);
            this.vehicle_reserve.Margin = new System.Windows.Forms.Padding(4);
            this.vehicle_reserve.Name = "vehicle_reserve";
            this.vehicle_reserve.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.vehicle_reserve.Size = new System.Drawing.Size(670, 81);
            this.vehicle_reserve.TabIndex = 73;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "vehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "vehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "startDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "startDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "endDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "endDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // projectIDDataGridViewTextBoxColumn
            // 
            this.projectIDDataGridViewTextBoxColumn.DataPropertyName = "projectID";
            this.projectIDDataGridViewTextBoxColumn.HeaderText = "projectID";
            this.projectIDDataGridViewTextBoxColumn.Name = "projectIDDataGridViewTextBoxColumn";
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "projectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "projectName";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // search
            // 
            this.search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.HintForeColor = System.Drawing.Color.Empty;
            this.search.HintText = "Search vehicle ID";
            this.search.isPassword = false;
            this.search.LineFocusedColor = System.Drawing.Color.Blue;
            this.search.LineIdleColor = System.Drawing.Color.Gray;
            this.search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.search.LineThickness = 3;
            this.search.Location = new System.Drawing.Point(127, 437);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(173, 33);
            this.search.TabIndex = 74;
            this.search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // vreserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.search);
            this.Controls.Add(this.vehicle_reserve);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.projectName);
            this.Controls.Add(this.projectID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "vreserve";
            this.Size = new System.Drawing.Size(1341, 969);
            this.Load += new System.EventHandler(this.reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_reserve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField duration;
        private MaterialSkin.Controls.MaterialSingleLineTextField projectName;
        private MaterialSkin.Controls.MaterialSingleLineTextField projectID;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDatepicker startDate;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker endDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid vehicle_reserve;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox search;
    }
}
