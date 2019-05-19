namespace TaskManager
{
    partial class projects_data
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.Project_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgv_show
            // 
            this.dgv_show.AllowUserToAddRows = false;
            this.dgv_show.AllowUserToDeleteRows = false;
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Project_name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_show.Location = new System.Drawing.Point(2, 3);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.ReadOnly = true;
            this.dgv_show.RowTemplate.Height = 26;
            this.dgv_show.Size = new System.Drawing.Size(579, 417);
            this.dgv_show.TabIndex = 3;
            this.dgv_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Project_name
            // 
            this.Project_name.HeaderText = "Project_name";
            this.Project_name.Name = "Project_name";
            this.Project_name.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Task_id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task_Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Employee_Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // projects_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_show);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "projects_data";
            this.Text = "projects_data";
            this.Load += new System.EventHandler(this.projects_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn Project_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}