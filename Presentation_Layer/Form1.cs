using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using PRG272_Project.BusinessLogic_Layer;
using PRG272_Project.DataAccess_Layer;
namespace PRG272_Project.Presentation_Layer
{
   
    public partial class Form1 : Form
    {
        private readonly Manager studentManager;
        public Form1()
        {
            InitializeComponent();
            var dataAccess = new FileDataAccess();
            studentManager = new Manager(dataAccess);
            InitializeDataGridView();
            LoadStudents();
            ClearForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    lblFormStatus.Text = "Please select a student to delete.";
                    return;
                }

                var studentId = dataGridView1.SelectedRows[0].Cells["StudentID"].Value.ToString();

                var result = MessageBox.Show(
                    "Are you sure you want to delete this student?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    studentManager.DeleteStudent(studentId);
                    LoadStudents();
                    ClearForm();
                    lblFormStatus.Text = "Student deleted successfully!";
                }
            }
            catch (Exception ex)
            {
                lblFormStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    lblFormStatus.Text = "Student ID is required.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) && string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    lblFormStatus.Text = "Name is required.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtAge.Text) || !int.TryParse(txtAge.Text, out int age))
                {
                    lblFormStatus.Text = "Valid age is required.";
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtCourse.Text))
                {
                    lblFormStatus.Text = "Course is required.";
                    return;
                }

                // Check for duplicate Student ID
                var existingStudents = studentManager.GetAllStudents();
                if (existingStudents.Any(s => s.StudentID == txtStudentID.Text))
                {
                    lblFormStatus.Text = "A student with this ID already exists.";
                    return;
                }

                var student = GetStudentFromForm();
                studentManager.AddStudent(student);
                
                ClearForm();
                LoadStudents();
                
                lblFormStatus.Text = "Student added successfully!";
            }
            catch (Exception ex)
            {
                lblFormStatus.Text = $"Error: {ex.Message}";
            }
        }

        private void ClearForm()
        {
            // Clear all TextBoxes
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtCourse.Clear();

            // Clear any selection in DataGridView
            if (dataGridView1 != null && dataGridView1.CurrentRow != null)
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentRow.Selected = false;
            }

            // Clear the status label
            lblFormStatus.Text = string.Empty;

            // Set focus to the first input field
            txtStudentID.Focus();
        }

        private void LoadStudents()
        {
            try
            {
                var students = studentManager.GetAllStudents();
                dataGridView1.Rows.Clear();

                foreach (var student in students)
                {
                    dataGridView1.Rows.Add(
                        student.StudentID,
                        student.FirstName,
                        student.LastName,
                        student.Age,
                        student.Course
                    );
                }

                // Optional: Update status
                lblFormStatus.Text = $"Loaded {students.Count} students";
            }
            catch (Exception ex)
            {
                lblFormStatus.Text = $"Error loading students: {ex.Message}";
            }
        }

        private Students GetStudentFromForm()
        {
            return new Students
            {
                StudentID = txtStudentID.Text,
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Age = int.Parse(txtAge.Text),
                Course = txtCourse.Text.Trim()
            };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // DEBUG: Print current values
                MessageBox.Show($"Updating student:\nID: {txtStudentID.Text}\nName: {txtFirstName.Text} {txtLastName.Text}\nAge: {txtAge.Text}\nCourse: {txtCourse.Text}");

                // Validate input
                if (string.IsNullOrWhiteSpace(txtStudentID.Text))
                {
                    lblFormStatus.Text = "Please select a student to update.";
                    return;
                }

                // Create the updated student object
                var updatedStudent = new Students
                {
                    StudentID = txtStudentID.Text.Trim(),
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Age = int.Parse(txtAge.Text.Trim()),
                    Course = txtCourse.Text.Trim()
                };

                // Perform the update
                studentManager.UpdateStudent(updatedStudent);

                // Refresh the DataGridView
                LoadStudents();

                // Clear the form
                ClearForm();

                lblFormStatus.Text = "Student updated successfully!";

                // After update
                MessageBox.Show("Update completed. Check the file content.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                txtStudentID.Text = row.Cells["StudentID"].Value.ToString();
                txtFirstName.Text = row.Cells["FirstName"].Value.ToString();
                txtLastName.Text = row.Cells["LastName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                txtCourse.Text = row.Cells["Course"].Value.ToString();
            }
        }

        private void InitializeDataGridView()
        {
            // Clear existing columns
            dataGridView1.Columns.Clear();
            
            // Set properties
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // Add columns
            dataGridView1.Columns.Add("StudentID", "Student ID");
            dataGridView1.Columns.Add("FirstName", "First Name");
            dataGridView1.Columns.Add("LastName", "Last Name");
            dataGridView1.Columns.Add("Age", "Age");
            dataGridView1.Columns.Add("Course", "Course");

            // Wire up the event handler
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Make sure we clicked on a row, not the header
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    
                    // Fill the textboxes with the data from the selected row
                    txtStudentID.Text = row.Cells["StudentID"].Value?.ToString();
                    txtFirstName.Text = row.Cells["FirstName"].Value?.ToString();
                    txtLastName.Text = row.Cells["LastName"].Value?.ToString();
                    txtAge.Text = row.Cells["Age"].Value?.ToString();
                    txtCourse.Text = row.Cells["Course"].Value?.ToString();

                    lblFormStatus.Text = "Student selected for editing";
                }
            }
            catch (Exception ex)
            {
                lblFormStatus.Text = $"Error selecting student: {ex.Message}";
            }
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get students and calculate stats
                var students = studentManager.GetAllStudents();
                int totalStudents = students.Count;
                double averageAge = 0;

                if (totalStudents > 0)
                {
                    averageAge = students.Average(s => s.Age);
                }

                // Use the SaveSummary function through the manager
                studentManager.SaveSummary(totalStudents, averageAge);

                // Show confirmation
                MessageBox.Show($"Report Generated!\n\nTotal Students: {totalStudents}\nAverage Age: {averageAge:F2}", "Success");
                lblFormStatus.Text = "Report generated successfully!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating report: " + ex.Message);
                lblFormStatus.Text = "Error generating report";
            }
        }
    }
}
