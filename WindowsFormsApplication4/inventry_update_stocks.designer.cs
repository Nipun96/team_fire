namespace WindowsFormsApplication4
{
    partial class inventry_update_stocks
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
            this.button1 = new System.Windows.Forms.Button();
            this.quantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.unitPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.sellingPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.warranty = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.button3 = new System.Windows.Forms.Button();
            this.itemName = new MetroFramework.Controls.MetroComboBox();
            this.supplier = new MetroFramework.Controls.MetroComboBox();
            this.stockNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.type = new MetroFramework.Controls.MetroComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.brand = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.itemId_ = new System.Windows.Forms.Label();
            this.itemId = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.date = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.button5 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
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
            this.button1.Location = new System.Drawing.Point(751, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add Items";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // quantity
            // 
            this.quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantity.ForeColor = System.Drawing.Color.DimGray;
            this.quantity.HintForeColor = System.Drawing.Color.Empty;
            this.quantity.HintText = "";
            this.quantity.isPassword = false;
            this.quantity.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.quantity.LineIdleColor = System.Drawing.Color.Gray;
            this.quantity.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.quantity.LineThickness = 3;
            this.quantity.Location = new System.Drawing.Point(195, 266);
            this.quantity.Margin = new System.Windows.Forms.Padding(4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(217, 33);
            this.quantity.TabIndex = 22;
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quantity.OnValueChanged += new System.EventHandler(this.quantity_OnValueChanged);
            this.quantity.Enter += new System.EventHandler(this.quantity_Enter);
            this.quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_KeyPress);
            this.quantity.Leave += new System.EventHandler(this.quantity_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(81, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Item";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Supplier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unit Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // unitPrice
            // 
            this.unitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.unitPrice.ForeColor = System.Drawing.Color.DimGray;
            this.unitPrice.HintForeColor = System.Drawing.Color.Empty;
            this.unitPrice.HintText = "";
            this.unitPrice.isPassword = false;
            this.unitPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.unitPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.unitPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.unitPrice.LineThickness = 3;
            this.unitPrice.Location = new System.Drawing.Point(629, 149);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(242, 33);
            this.unitPrice.TabIndex = 34;
            this.unitPrice.Text = "Unit Price";
            this.unitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.unitPrice.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged);
            this.unitPrice.Enter += new System.EventHandler(this.unitPrice_Enter);
            this.unitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitPrice_KeyPress);
            this.unitPrice.Leave += new System.EventHandler(this.unitPrice_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(751, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 38);
            this.button2.TabIndex = 35;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sellingPrice
            // 
            this.sellingPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sellingPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.sellingPrice.ForeColor = System.Drawing.Color.DimGray;
            this.sellingPrice.HintForeColor = System.Drawing.Color.Empty;
            this.sellingPrice.HintText = "";
            this.sellingPrice.isPassword = false;
            this.sellingPrice.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.sellingPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.sellingPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.sellingPrice.LineThickness = 3;
            this.sellingPrice.Location = new System.Drawing.Point(629, 207);
            this.sellingPrice.Margin = new System.Windows.Forms.Padding(4);
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.Size = new System.Drawing.Size(242, 33);
            this.sellingPrice.TabIndex = 37;
            this.sellingPrice.Text = "Selling Price";
            this.sellingPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sellingPrice.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            this.sellingPrice.Enter += new System.EventHandler(this.sellingPrice_Enter);
            this.sellingPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sellingPrice_KeyPress);
            this.sellingPrice.Leave += new System.EventHandler(this.sellingPrice_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Selling Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(503, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "Warranty";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // warranty
            // 
            this.warranty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.warranty.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.warranty.ForeColor = System.Drawing.Color.DimGray;
            this.warranty.HintForeColor = System.Drawing.Color.Empty;
            this.warranty.HintText = "";
            this.warranty.isPassword = false;
            this.warranty.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.warranty.LineIdleColor = System.Drawing.Color.Gray;
            this.warranty.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.warranty.LineThickness = 3;
            this.warranty.Location = new System.Drawing.Point(629, 266);
            this.warranty.Margin = new System.Windows.Forms.Padding(4);
            this.warranty.Name = "warranty";
            this.warranty.Size = new System.Drawing.Size(242, 33);
            this.warranty.TabIndex = 38;
            this.warranty.Text = "Warranty";
            this.warranty.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.warranty.OnValueChanged += new System.EventHandler(this.warrenty_OnValueChanged);
            this.warranty.Enter += new System.EventHandler(this.warranty_Enter);
            this.warranty.Leave += new System.EventHandler(this.warranty_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Type";
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MintCream;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.MintCream;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(39, 408);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(679, 233);
            this.bunifuCustomDataGrid1.TabIndex = 43;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(751, 443);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 38);
            this.button3.TabIndex = 44;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // itemName
            // 
            this.itemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemName.FormattingEnabled = true;
            this.itemName.ItemHeight = 23;
            this.itemName.Items.AddRange(new object[] {
            "Select an item"});
            this.itemName.Location = new System.Drawing.Point(195, 217);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(217, 29);
            this.itemName.TabIndex = 45;
            this.itemName.UseSelectable = true;
            this.itemName.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // supplier
            // 
            this.supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.supplier.FormattingEnabled = true;
            this.supplier.ItemHeight = 23;
            this.supplier.Items.AddRange(new object[] {
            "ABC",
            "PQR",
            "Dinuka and sons",
            "Anupama and sons"});
            this.supplier.Location = new System.Drawing.Point(195, 333);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(217, 29);
            this.supplier.TabIndex = 46;
            this.supplier.UseSelectable = true;
            this.supplier.SelectedIndexChanged += new System.EventHandler(this.metroComboBox2_SelectedIndexChanged);
            // 
            // stockNo
            // 
            this.stockNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stockNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.stockNo.ForeColor = System.Drawing.Color.DimGray;
            this.stockNo.HintForeColor = System.Drawing.Color.Empty;
            this.stockNo.HintText = "";
            this.stockNo.isPassword = false;
            this.stockNo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.stockNo.LineIdleColor = System.Drawing.Color.Gray;
            this.stockNo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.stockNo.LineThickness = 3;
            this.stockNo.Location = new System.Drawing.Point(195, 149);
            this.stockNo.Margin = new System.Windows.Forms.Padding(4);
            this.stockNo.Name = "stockNo";
            this.stockNo.Size = new System.Drawing.Size(217, 33);
            this.stockNo.TabIndex = 48;
            this.stockNo.Text = "Stock No";
            this.stockNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stockNo.OnValueChanged += new System.EventHandler(this.stockNo_OnValueChanged);
            this.stockNo.Enter += new System.EventHandler(this.stockNo_Enter);
            this.stockNo.Leave += new System.EventHandler(this.stockNo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 47;
            this.label3.Text = "Stock No";
            // 
            // type
            // 
            this.type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.type.FormattingEnabled = true;
            this.type.ItemHeight = 23;
            this.type.Items.AddRange(new object[] {
            "Fire Ditection",
            "Hydrent",
            "Extingulshers"});
            this.type.Location = new System.Drawing.Point(195, 99);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(217, 29);
            this.type.TabIndex = 49;
            this.type.UseSelectable = true;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(519, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Date";
            // 
            // brand
            // 
            this.brand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brand.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.brand.ForeColor = System.Drawing.Color.DimGray;
            this.brand.HintForeColor = System.Drawing.Color.Empty;
            this.brand.HintText = "";
            this.brand.isPassword = false;
            this.brand.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.brand.LineIdleColor = System.Drawing.Color.Gray;
            this.brand.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.brand.LineThickness = 3;
            this.brand.Location = new System.Drawing.Point(629, 323);
            this.brand.Margin = new System.Windows.Forms.Padding(4);
            this.brand.Name = "brand";
            this.brand.Size = new System.Drawing.Size(242, 33);
            this.brand.TabIndex = 53;
            this.brand.Text = "Brand";
            this.brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.brand.Enter += new System.EventHandler(this.brand_Enter);
            this.brand.Leave += new System.EventHandler(this.brand_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 52;
            this.label10.Text = "Brand";
            // 
            // itemId_
            // 
            this.itemId_.AutoSize = true;
            this.itemId_.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemId_.ForeColor = System.Drawing.Color.Red;
            this.itemId_.Location = new System.Drawing.Point(75, 59);
            this.itemId_.Name = "itemId_";
            this.itemId_.Size = new System.Drawing.Size(74, 23);
            this.itemId_.TabIndex = 54;
            this.itemId_.Text = "Item Id";
            this.itemId_.Visible = false;
            // 
            // itemId
            // 
            this.itemId.ForeColor = System.Drawing.Color.Red;
            this.itemId.Location = new System.Drawing.Point(195, 51);
            this.itemId.Name = "itemId";
            this.itemId.Size = new System.Drawing.Size(217, 31);
            this.itemId.TabIndex = 55;
            this.itemId.UseVisualStyleBackColor = true;
            this.itemId.Visible = false;
            this.itemId.Click += new System.EventHandler(this.itemId_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Silver;
            this.button4.Location = new System.Drawing.Point(751, 575);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 38);
            this.button4.TabIndex = 56;
            this.button4.Text = "View";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.date.ForeColor = System.Drawing.Color.DimGray;
            this.date.HintForeColor = System.Drawing.Color.Empty;
            this.date.HintText = "";
            this.date.isPassword = false;
            this.date.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineIdleColor = System.Drawing.Color.Gray;
            this.date.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineThickness = 3;
            this.date.Location = new System.Drawing.Point(629, 99);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(242, 33);
            this.date.TabIndex = 57;
            this.date.Text = "YYYY-MM-DD";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.date.OnValueChanged += new System.EventHandler(this.date_OnValueChanged);
            this.date.Enter += new System.EventHandler(this.date_Enter);
            this.date.Leave += new System.EventHandler(this.date_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(23, 372);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(984, 30);
            this.bunifuSeparator1.TabIndex = 58;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(751, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 38);
            this.button5.TabIndex = 59;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // inventry_update_stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.itemId);
            this.Controls.Add(this.itemId_);
            this.Controls.Add(this.brand);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.type);
            this.Controls.Add(this.stockNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplier);
            this.Controls.Add(this.itemName);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.warranty);
            this.Controls.Add(this.sellingPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.unitPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Name = "inventry_update_stocks";
            this.Size = new System.Drawing.Size(1038, 654);
            this.Load += new System.EventHandler(this.addItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox quantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox unitPrice;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sellingPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox warranty;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.Button button3;
        private MetroFramework.Controls.MetroComboBox itemName;
        private MetroFramework.Controls.MetroComboBox supplier;
        private Bunifu.Framework.UI.BunifuMaterialTextbox stockNo;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox type;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox brand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label itemId_;
        private System.Windows.Forms.Button itemId;
        private System.Windows.Forms.Button button4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox date;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}
