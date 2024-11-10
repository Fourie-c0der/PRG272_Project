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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SIHlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GViewBtn = new System.Windows.Forms.Button();
            this.SFormBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminBtn = new System.Windows.Forms.Button();
            this.SIDLabel = new System.Windows.Forms.Label();
            this.FnameLabel = new System.Windows.Forms.Label();
            this.LnameLabel = new System.Windows.Forms.Label();
            this.dobLabel = new System.Windows.Forms.Label();
            this.Courselabel = new System.Windows.Forms.Label();
            this.SIDTextbox = new System.Windows.Forms.TextBox();
            this.FnameTextbox = new System.Windows.Forms.TextBox();
            this.LnameTextbox = new System.Windows.Forms.TextBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.CourseTextbox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.Viewallbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.Totalbtn = new System.Windows.Forms.Button();
            this.avgagebtn = new System.Windows.Forms.Button();
            this.reportbtn = new System.Windows.Forms.Button();
            this.statuslabel = new System.Windows.Forms.Label();
            this.statustextbox = new System.Windows.Forms.TextBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1450, 43);
            this.panel1.TabIndex = 0;
            // 
            // SIHlabel
            // 
            this.SIHlabel.AutoSize = true;
            this.SIHlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIHlabel.Location = new System.Drawing.Point(45, 9);
            this.SIHlabel.Name = "SIHlabel";
            this.SIHlabel.Size = new System.Drawing.Size(263, 30);
            this.SIHlabel.TabIndex = 1;
            this.SIHlabel.Text = "Student Information Hub";
            this.SIHlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
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
            this.GViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("GViewBtn.Image")));
            this.GViewBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GViewBtn.Location = new System.Drawing.Point(0, 382);
            this.GViewBtn.Name = "GViewBtn";
            this.GViewBtn.Size = new System.Drawing.Size(1450, 57);
            this.GViewBtn.TabIndex = 2;
            this.GViewBtn.Text = "Data Gridview";
            this.GViewBtn.UseVisualStyleBackColor = false;
            // 
            // SFormBTN
            // 
            this.SFormBTN.BackColor = System.Drawing.Color.Black;
            this.SFormBTN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SFormBTN.ForeColor = System.Drawing.Color.White;
            this.SFormBTN.Image = ((System.Drawing.Image)(resources.GetObject("SFormBTN.Image")));
            this.SFormBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SFormBTN.Location = new System.Drawing.Point(12, 42);
            this.SFormBTN.Name = "SFormBTN";
            this.SFormBTN.Size = new System.Drawing.Size(646, 55);
            this.SFormBTN.TabIndex = 2;
            this.SFormBTN.Text = "Student Form";
            this.SFormBTN.UseVisualStyleBackColor = false;
            this.SFormBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 445);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1450, 244);
            this.dataGridView1.TabIndex = 3;
            // 
            // AdminBtn
            // 
            this.AdminBtn.BackColor = System.Drawing.Color.Black;
            this.AdminBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBtn.ForeColor = System.Drawing.Color.White;
            this.AdminBtn.Image = ((System.Drawing.Image)(resources.GetObject("AdminBtn.Image")));
            this.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminBtn.Location = new System.Drawing.Point(792, 42);
            this.AdminBtn.Name = "AdminBtn";
            this.AdminBtn.Size = new System.Drawing.Size(646, 55);
            this.AdminBtn.TabIndex = 4;
            this.AdminBtn.Text = "Admin Panel";
            this.AdminBtn.UseVisualStyleBackColor = false;
            // 
            // SIDLabel
            // 
            this.SIDLabel.AutoSize = true;
            this.SIDLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIDLabel.Location = new System.Drawing.Point(218, 156);
            this.SIDLabel.Name = "SIDLabel";
            this.SIDLabel.Size = new System.Drawing.Size(71, 17);
            this.SIDLabel.TabIndex = 6;
            this.SIDLabel.Text = "Student ID:";
            // 
            // FnameLabel
            // 
            this.FnameLabel.AutoSize = true;
            this.FnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameLabel.Location = new System.Drawing.Point(218, 185);
            this.FnameLabel.Name = "FnameLabel";
            this.FnameLabel.Size = new System.Drawing.Size(70, 17);
            this.FnameLabel.TabIndex = 7;
            this.FnameLabel.Text = "FirstName:";
            // 
            // LnameLabel
            // 
            this.LnameLabel.AutoSize = true;
            this.LnameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LnameLabel.Location = new System.Drawing.Point(218, 213);
            this.LnameLabel.Name = "LnameLabel";
            this.LnameLabel.Size = new System.Drawing.Size(69, 17);
            this.LnameLabel.TabIndex = 8;
            this.LnameLabel.Text = "LastName:";
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(218, 240);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(78, 17);
            this.dobLabel.TabIndex = 9;
            this.dobLabel.Text = "DateOfBirth:";
            // 
            // Courselabel
            // 
            this.Courselabel.AutoSize = true;
            this.Courselabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courselabel.Location = new System.Drawing.Point(218, 268);
            this.Courselabel.Name = "Courselabel";
            this.Courselabel.Size = new System.Drawing.Size(52, 17);
            this.Courselabel.TabIndex = 10;
            this.Courselabel.Text = "Course:";
            // 
            // SIDTextbox
            // 
            this.SIDTextbox.Location = new System.Drawing.Point(304, 153);
            this.SIDTextbox.Name = "SIDTextbox";
            this.SIDTextbox.Size = new System.Drawing.Size(100, 20);
            this.SIDTextbox.TabIndex = 11;
            // 
            // FnameTextbox
            // 
            this.FnameTextbox.Location = new System.Drawing.Point(304, 182);
            this.FnameTextbox.Name = "FnameTextbox";
            this.FnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.FnameTextbox.TabIndex = 12;
            // 
            // LnameTextbox
            // 
            this.LnameTextbox.Location = new System.Drawing.Point(304, 210);
            this.LnameTextbox.Name = "LnameTextbox";
            this.LnameTextbox.Size = new System.Drawing.Size(100, 20);
            this.LnameTextbox.TabIndex = 13;
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(304, 237);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(175, 20);
            this.DOB.TabIndex = 14;
            this.DOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CourseTextbox
            // 
            this.CourseTextbox.Location = new System.Drawing.Point(304, 265);
            this.CourseTextbox.Multiline = true;
            this.CourseTextbox.Name = "CourseTextbox";
            this.CourseTextbox.Size = new System.Drawing.Size(100, 20);
            this.CourseTextbox.TabIndex = 15;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(303, 302);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(101, 23);
            this.addbutton.TabIndex = 16;
            this.addbutton.Text = "Add Student";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // Viewallbtn
            // 
            this.Viewallbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewallbtn.Location = new System.Drawing.Point(960, 143);
            this.Viewallbtn.Name = "Viewallbtn";
            this.Viewallbtn.Size = new System.Drawing.Size(140, 42);
            this.Viewallbtn.TabIndex = 17;
            this.Viewallbtn.Text = "View All Students";
            this.Viewallbtn.UseVisualStyleBackColor = true;
            // 
            // updatebtn
            // 
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(960, 186);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(140, 42);
            this.updatebtn.TabIndex = 18;
            this.updatebtn.Text = "Update Students";
            this.updatebtn.UseVisualStyleBackColor = true;
            // 
            // deletebtn
            // 
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Location = new System.Drawing.Point(960, 230);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(140, 42);
            this.deletebtn.TabIndex = 19;
            this.deletebtn.Text = "Remove Students";
            this.deletebtn.UseVisualStyleBackColor = true;
            // 
            // Totalbtn
            // 
            this.Totalbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalbtn.Location = new System.Drawing.Point(1142, 143);
            this.Totalbtn.Name = "Totalbtn";
            this.Totalbtn.Size = new System.Drawing.Size(140, 42);
            this.Totalbtn.TabIndex = 20;
            this.Totalbtn.Text = "Total Students";
            this.Totalbtn.UseVisualStyleBackColor = true;
            // 
            // avgagebtn
            // 
            this.avgagebtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgagebtn.Location = new System.Drawing.Point(1142, 186);
            this.avgagebtn.Name = "avgagebtn";
            this.avgagebtn.Size = new System.Drawing.Size(140, 42);
            this.avgagebtn.TabIndex = 21;
            this.avgagebtn.Text = "Average Age";
            this.avgagebtn.UseVisualStyleBackColor = true;
            // 
            // reportbtn
            // 
            this.reportbtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.Location = new System.Drawing.Point(1142, 229);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(140, 42);
            this.reportbtn.TabIndex = 22;
            this.reportbtn.Text = "Generate Report";
            this.reportbtn.UseVisualStyleBackColor = true;
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statuslabel.Location = new System.Drawing.Point(218, 345);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(80, 17);
            this.statuslabel.TabIndex = 23;
            this.statuslabel.Text = "Form Status:";
            // 
            // statustextbox
            // 
            this.statustextbox.Location = new System.Drawing.Point(303, 342);
            this.statustextbox.Name = "statustextbox";
            this.statustextbox.Size = new System.Drawing.Size(100, 20);
            this.statustextbox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1450, 691);
            this.Controls.Add(this.statustextbox);
            this.Controls.Add(this.statuslabel);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.avgagebtn);
            this.Controls.Add(this.Totalbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.Viewallbtn);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.CourseTextbox);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.LnameTextbox);
            this.Controls.Add(this.FnameTextbox);
            this.Controls.Add(this.SIDTextbox);
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
        private System.Windows.Forms.TextBox SIDTextbox;
        private System.Windows.Forms.TextBox FnameTextbox;
        private System.Windows.Forms.TextBox LnameTextbox;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.TextBox CourseTextbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button Viewallbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button Totalbtn;
        private System.Windows.Forms.Button avgagebtn;
        private System.Windows.Forms.Button reportbtn;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.TextBox statustextbox;
    }
}