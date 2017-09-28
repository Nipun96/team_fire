namespace WindowsFormsApplication4
{
    partial class Dispatch_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.orderIdDispatch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.reasonDispatch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
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
            this.button1.Location = new System.Drawing.Point(669, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 23;
            this.button1.Text = "Dispatch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(92, 220);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(542, 276);
            this.bunifuCustomDataGrid1.TabIndex = 22;
            // 
            // orderIdDispatch
            // 
            this.orderIdDispatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.orderIdDispatch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.orderIdDispatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orderIdDispatch.HintForeColor = System.Drawing.Color.Empty;
            this.orderIdDispatch.HintText = "";
            this.orderIdDispatch.isPassword = false;
            this.orderIdDispatch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderIdDispatch.LineIdleColor = System.Drawing.Color.Gray;
            this.orderIdDispatch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.orderIdDispatch.LineThickness = 3;
            this.orderIdDispatch.Location = new System.Drawing.Point(290, 64);
            this.orderIdDispatch.Margin = new System.Windows.Forms.Padding(4);
            this.orderIdDispatch.Name = "orderIdDispatch";
            this.orderIdDispatch.Size = new System.Drawing.Size(203, 33);
            this.orderIdDispatch.TabIndex = 21;
            this.orderIdDispatch.Text = "Order Id";
            this.orderIdDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.orderIdDispatch.OnValueChanged += new System.EventHandler(this.orderIdDispatch_OnValueChanged);
            this.orderIdDispatch.Enter += new System.EventHandler(this.orderIdDispatch_Enter);
            this.orderIdDispatch.Leave += new System.EventHandler(this.orderIdDispatch_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Order Id";
            // 
            // reasonDispatch
            // 
            this.reasonDispatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reasonDispatch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.reasonDispatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reasonDispatch.HintForeColor = System.Drawing.Color.Empty;
            this.reasonDispatch.HintText = "";
            this.reasonDispatch.isPassword = false;
            this.reasonDispatch.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.reasonDispatch.LineIdleColor = System.Drawing.Color.Gray;
            this.reasonDispatch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.reasonDispatch.LineThickness = 3;
            this.reasonDispatch.Location = new System.Drawing.Point(290, 143);
            this.reasonDispatch.Margin = new System.Windows.Forms.Padding(4);
            this.reasonDispatch.Name = "reasonDispatch";
            this.reasonDispatch.Size = new System.Drawing.Size(203, 33);
            this.reasonDispatch.TabIndex = 25;
            this.reasonDispatch.Text = "Reason";
            this.reasonDispatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.reasonDispatch.OnValueChanged += new System.EventHandler(this.reasonDispatch_OnValueChanged);
            this.reasonDispatch.Enter += new System.EventHandler(this.reasonDispatch_Enter);
            this.reasonDispatch.Leave += new System.EventHandler(this.reasonDispatch_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "reason";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(669, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 38);
            this.button2.TabIndex = 61;
            this.button2.Text = "View Details";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Dispatch_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reasonDispatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.orderIdDispatch);
            this.Controls.Add(this.label1);
            this.Name = "Dispatch_Orders";
            this.Size = new System.Drawing.Size(994, 576);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox orderIdDispatch;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox reasonDispatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}
