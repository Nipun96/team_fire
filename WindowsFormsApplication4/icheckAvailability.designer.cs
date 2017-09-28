namespace WindowsFormsApplication4
{
    partial class icheckAvailability
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.orderId_check = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.itemNameCheck = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.requiredCheck = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.availableCheck = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.status_check = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(74, 118);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(351, 256);
            this.bunifuCustomDataGrid1.TabIndex = 24;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // orderId_check
            // 
            this.orderId_check.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderId_check.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderId_check.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderId_check.HintForeColor = System.Drawing.Color.Empty;
            this.orderId_check.HintText = "";
            this.orderId_check.isPassword = false;
            this.orderId_check.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderId_check.LineIdleColor = System.Drawing.Color.Gray;
            this.orderId_check.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderId_check.LineThickness = 3;
            this.orderId_check.Location = new System.Drawing.Point(257, 57);
            this.orderId_check.Margin = new System.Windows.Forms.Padding(4);
            this.orderId_check.Name = "orderId_check";
            this.orderId_check.Size = new System.Drawing.Size(379, 33);
            this.orderId_check.TabIndex = 23;
            this.orderId_check.Text = "Order Id";
            this.orderId_check.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderId_check.OnValueChanged += new System.EventHandler(this.orderId_check_OnValueChanged);
            this.orderId_check.Enter += new System.EventHandler(this.orderId_check_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Order Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Item";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, -24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Edit Text (for main menu)";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(665, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication4.Properties.Resources.VisualEditor___Icon___Search_big1;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(643, 57);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 33);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 52;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // itemNameCheck
            // 
            this.itemNameCheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemNameCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemNameCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemNameCheck.HintForeColor = System.Drawing.Color.Empty;
            this.itemNameCheck.HintText = "";
            this.itemNameCheck.isPassword = false;
            this.itemNameCheck.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemNameCheck.LineIdleColor = System.Drawing.Color.Gray;
            this.itemNameCheck.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.itemNameCheck.LineThickness = 3;
            this.itemNameCheck.Location = new System.Drawing.Point(593, 118);
            this.itemNameCheck.Margin = new System.Windows.Forms.Padding(4);
            this.itemNameCheck.Name = "itemNameCheck";
            this.itemNameCheck.Size = new System.Drawing.Size(202, 33);
            this.itemNameCheck.TabIndex = 53;
            this.itemNameCheck.Text = "Item ";
            this.itemNameCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // requiredCheck
            // 
            this.requiredCheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.requiredCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.requiredCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.requiredCheck.HintForeColor = System.Drawing.Color.Empty;
            this.requiredCheck.HintText = "";
            this.requiredCheck.isPassword = false;
            this.requiredCheck.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.requiredCheck.LineIdleColor = System.Drawing.Color.Gray;
            this.requiredCheck.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.requiredCheck.LineThickness = 3;
            this.requiredCheck.Location = new System.Drawing.Point(593, 159);
            this.requiredCheck.Margin = new System.Windows.Forms.Padding(4);
            this.requiredCheck.Name = "requiredCheck";
            this.requiredCheck.Size = new System.Drawing.Size(202, 33);
            this.requiredCheck.TabIndex = 54;
            this.requiredCheck.Text = "Required Quantity";
            this.requiredCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.requiredCheck.OnValueChanged += new System.EventHandler(this.requiredCheck_OnValueChanged);
            // 
            // availableCheck
            // 
            this.availableCheck.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.availableCheck.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.availableCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.availableCheck.HintForeColor = System.Drawing.Color.Empty;
            this.availableCheck.HintText = "";
            this.availableCheck.isPassword = false;
            this.availableCheck.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.availableCheck.LineIdleColor = System.Drawing.Color.Gray;
            this.availableCheck.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.availableCheck.LineThickness = 3;
            this.availableCheck.Location = new System.Drawing.Point(593, 200);
            this.availableCheck.Margin = new System.Windows.Forms.Padding(4);
            this.availableCheck.Name = "availableCheck";
            this.availableCheck.Size = new System.Drawing.Size(202, 33);
            this.availableCheck.TabIndex = 55;
            this.availableCheck.Text = "Available Quantity";
            this.availableCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.availableCheck.OnValueChanged += new System.EventHandler(this.availableCheck_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 56;
            this.label2.Text = "Required";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 57;
            this.label3.Text = "Available";
            // 
            // status_check
            // 
            this.status_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_check.ForeColor = System.Drawing.Color.Red;
            this.status_check.Location = new System.Drawing.Point(502, 256);
            this.status_check.Name = "status_check";
            this.status_check.Size = new System.Drawing.Size(293, 31);
            this.status_check.TabIndex = 58;
            this.status_check.Text = "Out Of Stock";
            this.status_check.UseVisualStyleBackColor = true;
            this.status_check.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 20);
            this.textBox1.TabIndex = 59;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(502, 372);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(134, 20);
            this.textBox2.TabIndex = 60;
            // 
            // checkAvailability
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 527);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.status_check);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.availableCheck);
            this.Controls.Add(this.requiredCheck);
            this.Controls.Add(this.itemNameCheck);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.orderId_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "checkAvailability";
            this.Text = "checkAvailability";
            this.Load += new System.EventHandler(this.checkAvailability_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox orderId_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox itemNameCheck;
        private Bunifu.Framework.UI.BunifuMaterialTextbox requiredCheck;
        private Bunifu.Framework.UI.BunifuMaterialTextbox availableCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button status_check;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}