namespace WindowsFormsApplication4
{
    partial class inventry_storage
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
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemNameNew = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemTypeNew = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.item_storage = new MetroFramework.Controls.MetroComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.type_storage = new MetroFramework.Controls.MetroComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(736, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "View Item details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Item";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(78, 141);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(554, 287);
            this.bunifuCustomDataGrid1.TabIndex = 26;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(746, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 38);
            this.button2.TabIndex = 27;
            this.button2.Text = "Order Items";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.itemNameNew);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.itemTypeNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(78, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 169);
            this.panel1.TabIndex = 28;
            // 
            // itemNameNew
            // 
            this.itemNameNew.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNameNew.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemNameNew.ForeColor = System.Drawing.Color.DimGray;
            this.itemNameNew.HintForeColor = System.Drawing.Color.Empty;
            this.itemNameNew.HintText = "";
            this.itemNameNew.isPassword = false;
            this.itemNameNew.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemNameNew.LineIdleColor = System.Drawing.Color.Gray;
            this.itemNameNew.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemNameNew.LineThickness = 3;
            this.itemNameNew.Location = new System.Drawing.Point(171, 96);
            this.itemNameNew.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameNew.Name = "itemNameNew";
            this.itemNameNew.Size = new System.Drawing.Size(217, 33);
            this.itemNameNew.TabIndex = 49;
            this.itemNameNew.Text = "Item Name";
            this.itemNameNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.itemNameNew.OnValueChanged += new System.EventHandler(this.itemNameNew_OnValueChanged);
            this.itemNameNew.Enter += new System.EventHandler(this.itemNameNew_Enter);
            this.itemNameNew.Leave += new System.EventHandler(this.itemNameNew_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "Item Name";
            // 
            // itemTypeNew
            // 
            this.itemTypeNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemTypeNew.FormattingEnabled = true;
            this.itemTypeNew.ItemHeight = 23;
            this.itemTypeNew.Items.AddRange(new object[] {
            "Fire Ditection",
            "Hydrent",
            "Extingulshers"});
            this.itemTypeNew.Location = new System.Drawing.Point(171, 25);
            this.itemTypeNew.Name = "itemTypeNew";
            this.itemTypeNew.Size = new System.Drawing.Size(217, 29);
            this.itemTypeNew.TabIndex = 47;
            this.itemTypeNew.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "catagory";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(510, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 38);
            this.button3.TabIndex = 28;
            this.button3.Text = "Add Item to System";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // item_storage
            // 
            this.item_storage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.item_storage.FormattingEnabled = true;
            this.item_storage.ItemHeight = 23;
            this.item_storage.Items.AddRange(new object[] {
            "Select a Catagory First"});
            this.item_storage.Location = new System.Drawing.Point(496, 63);
            this.item_storage.Name = "item_storage";
            this.item_storage.Size = new System.Drawing.Size(217, 29);
            this.item_storage.TabIndex = 48;
            this.item_storage.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 49;
            this.label3.Text = "catagory";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(26, 434);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(909, 30);
            this.bunifuSeparator1.TabIndex = 59;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // type_storage
            // 
            this.type_storage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.type_storage.FormattingEnabled = true;
            this.type_storage.ItemHeight = 23;
            this.type_storage.Items.AddRange(new object[] {
            "Fire Ditection",
            "Hydrent",
            "Extingulshers"});
            this.type_storage.Location = new System.Drawing.Point(150, 63);
            this.type_storage.Name = "type_storage";
            this.type_storage.Size = new System.Drawing.Size(227, 29);
            this.type_storage.TabIndex = 60;
            this.type_storage.UseSelectable = true;
            this.type_storage.SelectedIndexChanged += new System.EventHandler(this.type_storage_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(746, 250);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 38);
            this.button4.TabIndex = 61;
            this.button4.Text = "Summary";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(746, 195);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(155, 28);
            this.radioButton3.TabIndex = 64;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Extingulshers";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(746, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 28);
            this.radioButton2.TabIndex = 63;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hydrent";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(746, 127);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(152, 28);
            this.radioButton1.TabIndex = 62;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fire Ditection";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(658, 111);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(291, 10);
            this.bunifuSeparator2.TabIndex = 65;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(658, 323);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(291, 10);
            this.bunifuSeparator3.TabIndex = 66;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // inventry_storage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.type_storage);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.item_storage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Name = "inventry_storage";
            this.Size = new System.Drawing.Size(962, 633);
            this.Load += new System.EventHandler(this.storage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox itemTypeNew;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox itemNameNew;
        private MetroFramework.Controls.MetroComboBox item_storage;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private MetroFramework.Controls.MetroComboBox type_storage;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
    }
}
