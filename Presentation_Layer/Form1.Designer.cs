namespace PRG272_Project.Presentation_Layer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIHlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GViewBtn = new System.Windows.Forms.Button();
            this.SFormBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.SIDLabel = new System.Windows.Forms.Label();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.Courselabel = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblFormStatus = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.SIHlabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 53);
            this.panel1.TabIndex = 0;
            // 
            // SIHlabel
            // 
            this.SIHlabel.AutoSize = true;
            this.SIHlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIHlabel.Location = new System.Drawing.Point(60, 11);
            this.SIHlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SIHlabel.Name = "SIHlabel";
            this.SIHlabel.Size = new System.Drawing.Size(340, 37);
            this.SIHlabel.TabIndex = 1;
            this.SIHlabel.Text = "Student Information Hub";
            this.SIHlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GViewBtn
            // 
            this.GViewBtn.BackColor = System.Drawing.Color.Black;
            this.GViewBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GViewBtn.ForeColor = System.Drawing.Color.White;
            this.GViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GViewBtn.Location = new System.Drawing.Point(115, 403);
            this.GViewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GViewBtn.Name = "GViewBtn";
            this.GViewBtn.Size = new System.Drawing.Size(682, 70);
            this.GViewBtn.TabIndex = 2;
            this.GViewBtn.Text = "Data Gridview";
            this.GViewBtn.UseVisualStyleBackColor = false;
            // 
            // SFormBTN
            // 
            this.SFormBTN.BackColor = System.Drawing.Color.Black;
            this.SFormBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFormBTN.ForeColor = System.Drawing.Color.White;
            this.SFormBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SFormBTN.Location = new System.Drawing.Point(16, 52);
            this.SFormBTN.Margin = new System.Windows.Forms.Padding(4);
            this.SFormBTN.Name = "SFormBTN";
            this.SFormBTN.Size = new System.Drawing.Size(861, 68);
            this.SFormBTN.TabIndex = 2;
            this.SFormBTN.Text = "Student Form";
            this.SFormBTN.UseVisualStyleBackColor = false;
            this.SFormBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.DateOfBirth,
            this.Course});
            this.dataGridView1.Location = new System.Drawing.Point(115, 487);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(678, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 6;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 125;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.HeaderText = "Age";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 125;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.MinimumWidth = 6;
            this.Course.Name = "Course";
            this.Course.Width = 125;
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Black;
            this.AdminBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.Location = new System.Drawing.Point(1056, 52);
            this.AdminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(861, 68);
            this.AdminBtn.TabIndex = 4;
            this.AdminBtn.UseVisualStyleBackColor = false;
            // 
            // SIDLabel
            // 
            this.SIDLabel.AutoSize = true;
            this.SIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDLabel.Location = new System.Drawing.Point(287, 143);
            this.SIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SIDLabel.Name = "SIDLabel";
            this.SIDLabel.Size = new System.Drawing.Size(95, 23);
            this.SIDLabel.TabIndex = 6;
            this.SIDLabel.Text = "Student ID:";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(287, 179);
            this.FnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(91, 23);
            this.FnameLabel.TabIndex = 7;
            this.FnameLabel.Text = "FirstName:";
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(287, 213);
            this.LnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(90, 23);
            this.LnameLabel.TabIndex = 8;
            this.LnameLabel.Text = "LastName:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(287, 246);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(44, 23);
            this.dobLabel.TabIndex = 9;
            this.dobLabel.Text = "Age:";
            // 
            // Courselabel
            // 
            this.Courselabel.AutoSize = true;
            this.Courselabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courselabel.Location = new System.Drawing.Point(287, 281);
            this.Courselabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Courselabel.Name = "Courselabel";
            this.Courselabel.Size = new System.Drawing.Size(67, 23);
            this.Courselabel.TabIndex = 10;
            this.Courselabel.Text = "Course:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(401, 139);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(132, 22);
            this.txtStudentID.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(401, 175);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(401, 209);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 13;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(401, 277);
            this.txtCourse.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourse.Multiline = true;
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(132, 24);
            this.txtCourse.TabIndex = 15;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(115, 323);
            this.addbutton.Margin = new System.Windows.Forms.Padding(4);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(135, 28);
            this.addbutton.TabIndex = 16;
            this.addbutton.Text = "Add Student";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(287, 376);
            this.statuslabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(104, 23);
            this.statuslabel.TabIndex = 23;
            this.statuslabel.Text = "Form Status:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(291, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 28);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(484, 324);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(135, 28);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Update Student";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblFormStatus
            // 
            this.lblFormStatus.AutoSize = true;
            this.lblFormStatus.Location = new System.Drawing.Point(446, 383);
            this.lblFormStatus.Name = "lblFormStatus";
            this.lblFormStatus.Size = new System.Drawing.Size(0, 16);
            this.lblFormStatus.TabIndex = 27;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(401, 246);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 22);
            this.txtAge.TabIndex = 28;
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(662, 324);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(135, 28);
            this.btnReport.TabIndex = 29;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(906, 850);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblFormStatus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.Courselabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.LnameLabel);
            this.Controls.Add(this.FnameLabel);
            this.Controls.Add(this.SIDLabel);
            this.Controls.Add(this.AdminBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GViewBtn);
            this.Controls.Add(this.SFormBTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SIHlabel;
        private System.Windows.Forms.Button GViewBtn;
        private System.Windows.Forms.Button SFormBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AdminBtn;
        private System.Windows.Forms.Label SIDLabel;
        private System.Windows.Forms.Label FnameLabel;
        private System.Windows.Forms.Label LnameLabel;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label Courselabel;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFormStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnReport;
    }
}