namespace TaskManager
{
    partial class Form1
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
            this.loginbtn = new System.Windows.Forms.Button();
            this.userid = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.useridtext = new System.Windows.Forms.TextBox();
            this.passtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginbtn
            // 
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginbtn.Location = new System.Drawing.Point(213, 188);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 28);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // userid
            // 
            this.userid.AutoSize = true;
            this.userid.Location = new System.Drawing.Point(63, 52);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(53, 17);
            this.userid.TabIndex = 1;
            this.userid.Text = "User ID";
            this.userid.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(63, 99);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(66, 17);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // useridtext
            // 
            this.useridtext.Location = new System.Drawing.Point(166, 52);
            this.useridtext.Name = "useridtext";
            this.useridtext.Size = new System.Drawing.Size(194, 24);
            this.useridtext.TabIndex = 3;
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(166, 108);
            this.passtext.Name = "passtext";
            this.passtext.Size = new System.Drawing.Size(194, 24);
            this.passtext.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(489, 296);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.useridtext);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.loginbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label userid;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox useridtext;
        private System.Windows.Forms.TextBox passtext;
    }
}

