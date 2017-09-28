namespace WindowsFormsApplication4
{
    partial class inventry_rejectitems
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description_reject = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.type_reject = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.item_reject = new MetroFramework.Controls.MetroComboBox();
            this.brand_reject = new MetroFramework.Controls.MetroComboBox();
            this.quantity_reject = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.reason = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.date = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
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
            this.button1.Location = new System.Drawing.Point(791, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Reject";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Description";
            // 
            // description_reject
            // 
            this.description_reject.AutoScroll = true;
            this.description_reject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description_reject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.description_reject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.description_reject.HintForeColor = System.Drawing.Color.Empty;
            this.description_reject.HintText = "";
            this.description_reject.isPassword = false;
            this.description_reject.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.description_reject.LineIdleColor = System.Drawing.Color.Gray;
            this.description_reject.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.description_reject.LineThickness = 3;
            this.description_reject.Location = new System.Drawing.Point(266, 376);
            this.description_reject.Margin = new System.Windows.Forms.Padding(4);
            this.description_reject.Name = "description_reject";
            this.description_reject.Size = new System.Drawing.Size(493, 33);
            this.description_reject.TabIndex = 28;
            this.description_reject.Text = "Description";
            this.description_reject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.description_reject.Enter += new System.EventHandler(this.description_reject_Enter);
            this.description_reject.Leave += new System.EventHandler(this.description_reject_Leave);
            // 
            // type_reject
            // 
            this.type_reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.type_reject.FormattingEnabled = true;
            this.type_reject.ItemHeight = 23;
            this.type_reject.Items.AddRange(new object[] {
            "Fire Ditection",
            "Hydrent",
            "Extingulshers"});
            this.type_reject.Location = new System.Drawing.Point(266, 20);
            this.type_reject.Name = "type_reject";
            this.type_reject.Size = new System.Drawing.Size(258, 29);
            this.type_reject.TabIndex = 50;
            this.type_reject.UseSelectable = true;
            this.type_reject.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Item";
            // 
            // item_reject
            // 
            this.item_reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.item_reject.FormattingEnabled = true;
            this.item_reject.ItemHeight = 23;
            this.item_reject.Location = new System.Drawing.Point(266, 80);
            this.item_reject.Name = "item_reject";
            this.item_reject.Size = new System.Drawing.Size(258, 29);
            this.item_reject.TabIndex = 52;
            this.item_reject.UseSelectable = true;
            // 
            // brand_reject
            // 
            this.brand_reject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.brand_reject.FormattingEnabled = true;
            this.brand_reject.ItemHeight = 23;
            this.brand_reject.Location = new System.Drawing.Point(266, 136);
            this.brand_reject.Name = "brand_reject";
            this.brand_reject.Size = new System.Drawing.Size(258, 29);
            this.brand_reject.TabIndex = 54;
            this.brand_reject.UseSelectable = true;
            // 
            // quantity_reject
            // 
            this.quantity_reject.BorderColorFocused = System.Drawing.Color.Blue;
            this.quantity_reject.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity_reject.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.quantity_reject.BorderThickness = 3;
            this.quantity_reject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quantity_reject.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quantity_reject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quantity_reject.isPassword = false;
            this.quantity_reject.Location = new System.Drawing.Point(266, 247);
            this.quantity_reject.Margin = new System.Windows.Forms.Padding(4);
            this.quantity_reject.Name = "quantity_reject";
            this.quantity_reject.Size = new System.Drawing.Size(73, 44);
            this.quantity_reject.TabIndex = 55;
            this.quantity_reject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // reason
            // 
            this.reason.AutoScroll = true;
            this.reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reason.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reason.HintForeColor = System.Drawing.Color.Empty;
            this.reason.HintText = "";
            this.reason.isPassword = false;
            this.reason.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.reason.LineIdleColor = System.Drawing.Color.Gray;
            this.reason.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.reason.LineThickness = 3;
            this.reason.Location = new System.Drawing.Point(266, 316);
            this.reason.Margin = new System.Windows.Forms.Padding(4);
            this.reason.Name = "reason";
            this.reason.Size = new System.Drawing.Size(493, 33);
            this.reason.TabIndex = 57;
            this.reason.Text = "Reason";
            this.reason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reason.OnValueChanged += new System.EventHandler(this.reason_OnValueChanged);
            this.reason.Enter += new System.EventHandler(this.reason_Enter);
            this.reason.Leave += new System.EventHandler(this.reason_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 56;
            this.label6.Text = "Reason";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 58;
            this.label7.Text = "Date";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.HintForeColor = System.Drawing.Color.Empty;
            this.date.HintText = "";
            this.date.isPassword = false;
            this.date.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineIdleColor = System.Drawing.Color.Gray;
            this.date.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineThickness = 3;
            this.date.Location = new System.Drawing.Point(266, 192);
            this.date.Margin = new System.Windows.Forms.Padding(4);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(242, 33);
            this.date.TabIndex = 59;
            this.date.Text = "YYYY-MM-DD";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.date.OnValueChanged += new System.EventHandler(this.date_OnValueChanged);
            this.date.Enter += new System.EventHandler(this.date_Enter);
            this.date.Leave += new System.EventHandler(this.date_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(791, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 38);
            this.button2.TabIndex = 60;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(18, 416);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(873, 35);
            this.bunifuSeparator1.TabIndex = 61;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(38, 446);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(732, 173);
            this.bunifuCustomDataGrid1.TabIndex = 62;
            this.bunifuCustomDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // inventry_rejectitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantity_reject);
            this.Controls.Add(this.brand_reject);
            this.Controls.Add(this.item_reject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.type_reject);
            this.Controls.Add(this.description_reject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "inventry_rejectitems";
            this.Size = new System.Drawing.Size(1011, 635);
            this.Load += new System.EventHandler(this.rejectitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox description_reject;
        private MetroFramework.Controls.MetroComboBox type_reject;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox item_reject;
        private MetroFramework.Controls.MetroComboBox brand_reject;
        private Bunifu.Framework.UI.BunifuMetroTextbox quantity_reject;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox date;
        private System.Windows.Forms.Button button2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
