namespace TaskManager
{
    partial class createEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adminbtn = new System.Windows.Forms.RadioButton();
            this.userbtn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.createbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(189, 51);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(203, 24);
            this.idtext.TabIndex = 1;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(189, 93);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(203, 24);
            this.passtext.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Password";
            // 
            // adminbtn
            // 
            this.adminbtn.AutoSize = true;
            this.adminbtn.Location = new System.Drawing.Point(189, 184);
            this.adminbtn.Name = "adminbtn";
            this.adminbtn.Size = new System.Drawing.Size(67, 21);
            this.adminbtn.TabIndex = 6;
            this.adminbtn.TabStop = true;
            this.adminbtn.Text = "Admin";
            this.adminbtn.UseVisualStyleBackColor = true;
            this.adminbtn.CheckedChanged += new System.EventHandler(this.adminbtn_CheckedChanged);
            // 
            // userbtn
            // 
            this.userbtn.AutoSize = true;
            this.userbtn.Location = new System.Drawing.Point(282, 180);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(56, 21);
            this.userbtn.TabIndex = 7;
            this.userbtn.TabStop = true;
            this.userbtn.Text = "User";
            this.userbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(189, 255);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(86, 36);
            this.createbtn.TabIndex = 9;
            this.createbtn.Text = "Create";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // createEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 343);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userbtn);
            this.Controls.Add(this.adminbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.idtext);
            this.Controls.Add(this.label1);
            this.Name = "createEmployee";
            this.Text = "createEmployee";
            this.Load += new System.EventHandler(this.createEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton adminbtn;
        private System.Windows.Forms.RadioButton userbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createbtn;
    }
}