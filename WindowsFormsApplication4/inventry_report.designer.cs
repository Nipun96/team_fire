namespace WindowsFormsApplication4
{
    partial class inventry_report
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
            this.button1 = new System.Windows.Forms.Button();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(736, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Product",
        "Sales",
        ""};
            this.bunifuDropdown1.Location = new System.Drawing.Point(210, 76);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.bunifuDropdown1.selectedIndex = -1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(217, 35);
            this.bunifuDropdown1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Report Type";
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.button1);
            this.Name = "report";
            this.Size = new System.Drawing.Size(939, 581);
            this.Load += new System.EventHandler(this.report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label label1;
    }
}
