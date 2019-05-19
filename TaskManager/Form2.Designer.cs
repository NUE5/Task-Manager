namespace TaskManager
{
    partial class Form2
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
            this.send_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.projectname_text_box = new System.Windows.Forms.TextBox();
            this.taskname_text_box = new System.Windows.Forms.TextBox();
            this.taskid_textbox = new System.Windows.Forms.TextBox();
            this.sendto_textbox = new System.Windows.Forms.TextBox();
            this.message_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.select_filder_button = new System.Windows.Forms.Button();
            this.select_folder_text_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // send_button
            // 
            this.send_button.Location = new System.Drawing.Point(720, 577);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(152, 28);
            this.send_button.TabIndex = 0;
            this.send_button.Text = "sendcomment";
            this.send_button.UseVisualStyleBackColor = true;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "projectname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "taskname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "TaskID";
            // 
            // projectname_text_box
            // 
            this.projectname_text_box.Location = new System.Drawing.Point(218, 38);
            this.projectname_text_box.Name = "projectname_text_box";
            this.projectname_text_box.Size = new System.Drawing.Size(114, 22);
            this.projectname_text_box.TabIndex = 4;
            // 
            // taskname_text_box
            // 
            this.taskname_text_box.Location = new System.Drawing.Point(218, 104);
            this.taskname_text_box.Name = "taskname_text_box";
            this.taskname_text_box.Size = new System.Drawing.Size(114, 22);
            this.taskname_text_box.TabIndex = 5;
            // 
            // taskid_textbox
            // 
            this.taskid_textbox.Location = new System.Drawing.Point(218, 163);
            this.taskid_textbox.Name = "taskid_textbox";
            this.taskid_textbox.Size = new System.Drawing.Size(114, 22);
            this.taskid_textbox.TabIndex = 6;
            // 
            // sendto_textbox
            // 
            this.sendto_textbox.Location = new System.Drawing.Point(218, 305);
            this.sendto_textbox.Name = "sendto_textbox";
            this.sendto_textbox.Size = new System.Drawing.Size(310, 22);
            this.sendto_textbox.TabIndex = 0;
            // 
            // message_textbox
            // 
            this.message_textbox.Location = new System.Drawing.Point(218, 352);
            this.message_textbox.Multiline = true;
            this.message_textbox.Name = "message_textbox";
            this.message_textbox.Size = new System.Drawing.Size(470, 220);
            this.message_textbox.TabIndex = 1;
            this.message_textbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "sendto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "message";
            // 
            // select_filder_button
            // 
            this.select_filder_button.Location = new System.Drawing.Point(77, 207);
            this.select_filder_button.Name = "select_filder_button";
            this.select_filder_button.Size = new System.Drawing.Size(247, 28);
            this.select_filder_button.TabIndex = 11;
            this.select_filder_button.Text = "selct folder";
            this.select_filder_button.UseVisualStyleBackColor = true;
            this.select_filder_button.Click += new System.EventHandler(this.select_filder_button_Click);
            // 
            // select_folder_text_box
            // 
            this.select_folder_text_box.Location = new System.Drawing.Point(77, 254);
            this.select_folder_text_box.Name = "select_folder_text_box";
            this.select_folder_text_box.Size = new System.Drawing.Size(310, 22);
            this.select_folder_text_box.TabIndex = 12;
            this.select_folder_text_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 626);
            this.Controls.Add(this.select_folder_text_box);
            this.Controls.Add(this.select_filder_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.message_textbox);
            this.Controls.Add(this.sendto_textbox);
            this.Controls.Add(this.taskid_textbox);
            this.Controls.Add(this.taskname_text_box);
            this.Controls.Add(this.projectname_text_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.send_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox projectname_text_box;
        private System.Windows.Forms.TextBox taskname_text_box;
        private System.Windows.Forms.TextBox taskid_textbox;
        private System.Windows.Forms.TextBox sendto_textbox;
        private System.Windows.Forms.TextBox message_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button select_filder_button;
        private System.Windows.Forms.TextBox select_folder_text_box;
    }
}