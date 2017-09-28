namespace WindowsFormsApplication4
{
    partial class inventry_orderdetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sort = new Bunifu.Framework.UI.BunifuDropdown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.date_sort = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.orderId = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.Transparent;
            this.sort.BorderRadius = 3;
            this.sort.DisabledColor = System.Drawing.Color.Gray;
            this.sort.ForeColor = System.Drawing.Color.White;
            this.sort.Items = new string[] {
        "Today",
        "This Month",
        "select Date"};
            this.sort.Location = new System.Drawing.Point(140, 79);
            this.sort.Name = "sort";
            this.sort.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.sort.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.sort.selectedIndex = -1;
            this.sort.Size = new System.Drawing.Size(217, 35);
            this.sort.TabIndex = 19;
            this.sort.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sort";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(698, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "See Order Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(65, 165);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(543, 136);
            this.bunifuCustomDataGrid1.TabIndex = 29;
            // 
            // date_sort
            // 
            this.date_sort.BackColor = System.Drawing.Color.SeaGreen;
            this.date_sort.BorderRadius = 0;
            this.date_sort.ForeColor = System.Drawing.Color.White;
            this.date_sort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_sort.FormatCustom = null;
            this.date_sort.Location = new System.Drawing.Point(587, 78);
            this.date_sort.Name = "date_sort";
            this.date_sort.Size = new System.Drawing.Size(303, 36);
            this.date_sort.TabIndex = 30;
            this.date_sort.Value = new System.DateTime(2017, 8, 29, 8, 58, 48, 389);
            this.date_sort.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Select Date";
            this.label1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(712, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 38);
            this.button3.TabIndex = 33;
            this.button3.Text = "Check Availability";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(145, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Check Availability";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(38, 316);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(852, 30);
            this.bunifuSeparator1.TabIndex = 36;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Issue Items";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(712, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 38);
            this.button2.TabIndex = 38;
            this.button2.Text = "Issue";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(65, 424);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(543, 136);
            this.bunifuCustomDataGrid2.TabIndex = 39;
            // 
            // orderId
            // 
            this.orderId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderId.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderId.ForeColor = System.Drawing.Color.DimGray;
            this.orderId.HintForeColor = System.Drawing.Color.Empty;
            this.orderId.HintText = "";
            this.orderId.isPassword = false;
            this.orderId.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderId.LineIdleColor = System.Drawing.Color.Gray;
            this.orderId.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderId.LineThickness = 3;
            this.orderId.Location = new System.Drawing.Point(391, 363);
            this.orderId.Margin = new System.Windows.Forms.Padding(4);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(217, 33);
            this.orderId.TabIndex = 50;
            this.orderId.Text = "Order Id";
            this.orderId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderId.OnValueChanged += new System.EventHandler(this.stockNo_OnValueChanged);
            this.orderId.Enter += new System.EventHandler(this.stockNo_Enter);
            this.orderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orderId_KeyPress);
            this.orderId.Leave += new System.EventHandler(this.orderId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "Order Id";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication4.Properties.Resources.VisualEditor___Icon___Search_big1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(615, 363);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 51;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(748, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 52;
            // 
            // inventry_orderdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_sort);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.label6);
            this.Name = "inventry_orderdetails";
            this.Size = new System.Drawing.Size(931, 572);
            this.Load += new System.EventHandler(this.orderdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDropdown sort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuDatepicker date_sort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox orderId;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
