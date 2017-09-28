namespace WindowsFormsApplication4
{
    partial class eloan
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.amount2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lname2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.empid2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.fname2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Location = new System.Drawing.Point(66, 697);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 47);
            this.button1.TabIndex = 34;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(61, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 41;
            this.label3.Text = "Employee ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(61, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 28);
            this.label1.TabIndex = 43;
            this.label1.Text = "Loan Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(61, 585);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 28);
            this.label2.TabIndex = 44;
            this.label2.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(61, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Last Name";
            // 
            // description2
            // 
            this.description2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.description2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.description2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.description2.HintForeColor = System.Drawing.Color.Empty;
            this.description2.HintText = "";
            this.description2.isPassword = false;
            this.description2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.description2.LineIdleColor = System.Drawing.Color.Gray;
            this.description2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.description2.LineThickness = 3;
            this.description2.Location = new System.Drawing.Point(342, 572);
            this.description2.Margin = new System.Windows.Forms.Padding(5);
            this.description2.Name = "description2";
            this.description2.Size = new System.Drawing.Size(505, 41);
            this.description2.TabIndex = 48;
            this.description2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // amount2
            // 
            this.amount2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.amount2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.amount2.HintForeColor = System.Drawing.Color.Empty;
            this.amount2.HintText = "";
            this.amount2.isPassword = false;
            this.amount2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.amount2.LineIdleColor = System.Drawing.Color.Gray;
            this.amount2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.amount2.LineThickness = 3;
            this.amount2.Location = new System.Drawing.Point(342, 369);
            this.amount2.Margin = new System.Windows.Forms.Padding(5);
            this.amount2.Name = "amount2";
            this.amount2.Size = new System.Drawing.Size(505, 41);
            this.amount2.TabIndex = 49;
            this.amount2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.amount2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // lname2
            // 
            this.lname2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lname2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lname2.HintForeColor = System.Drawing.Color.Empty;
            this.lname2.HintText = "";
            this.lname2.isPassword = false;
            this.lname2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname2.LineIdleColor = System.Drawing.Color.Gray;
            this.lname2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.lname2.LineThickness = 3;
            this.lname2.Location = new System.Drawing.Point(342, 281);
            this.lname2.Margin = new System.Windows.Forms.Padding(5);
            this.lname2.Name = "lname2";
            this.lname2.Size = new System.Drawing.Size(505, 41);
            this.lname2.TabIndex = 50;
            this.lname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lname2.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox3_OnValueChanged_1);
            // 
            // empid2
            // 
            this.empid2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.empid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.empid2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.empid2.HintForeColor = System.Drawing.Color.Empty;
            this.empid2.HintText = "";
            this.empid2.isPassword = false;
            this.empid2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.empid2.LineIdleColor = System.Drawing.Color.Gray;
            this.empid2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.empid2.LineThickness = 3;
            this.empid2.Location = new System.Drawing.Point(342, 98);
            this.empid2.Margin = new System.Windows.Forms.Padding(5);
            this.empid2.Name = "empid2";
            this.empid2.Size = new System.Drawing.Size(505, 41);
            this.empid2.TabIndex = 51;
            this.empid2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.empid2.OnValueChanged += new System.EventHandler(this.empid2_OnValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(61, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "First Name";
            // 
            // fname2
            // 
            this.fname2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fname2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fname2.HintForeColor = System.Drawing.Color.Empty;
            this.fname2.HintText = "";
            this.fname2.isPassword = false;
            this.fname2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname2.LineIdleColor = System.Drawing.Color.Gray;
            this.fname2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.fname2.LineThickness = 3;
            this.fname2.Location = new System.Drawing.Point(342, 189);
            this.fname2.Margin = new System.Windows.Forms.Padding(5);
            this.fname2.Name = "fname2";
            this.fname2.Size = new System.Drawing.Size(505, 41);
            this.fname2.TabIndex = 53;
            this.fname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(61, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 28);
            this.label6.TabIndex = 54;
            this.label6.Text = "Date";
            // 
            // date
            // 
            this.date.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.date.HintForeColor = System.Drawing.Color.Empty;
            this.date.HintText = "";
            this.date.isPassword = false;
            this.date.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineIdleColor = System.Drawing.Color.Gray;
            this.date.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.date.LineThickness = 3;
            this.date.Location = new System.Drawing.Point(342, 479);
            this.date.Margin = new System.Windows.Forms.Padding(5);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(505, 41);
            this.date.TabIndex = 55;
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.date);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fname2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.empid2);
            this.Controls.Add(this.lname2);
            this.Controls.Add(this.amount2);
            this.Controls.Add(this.description2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "loan";
            this.Size = new System.Drawing.Size(1188, 825);
            this.Load += new System.EventHandler(this.loan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox description2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox amount2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox empid2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox date;
    }
}
