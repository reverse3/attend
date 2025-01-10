using MySql.Data.MySqlClient;   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static WindowsFormsApp1.Dashboard;

namespace WindowsFormsApp1
{
    public partial class AddStudentForm : Form
    {
        private int sectionid;  // Correct variable name with lowercase id

        public AddStudentForm(int sectionId)  // Correct constructor accepting the ID
        {
            InitializeComponent();
            sectionid = sectionId;  // Properly assigning the value to the class-level variable
            LoadStudents();
        }

        // Load students for the selected section
        private void LoadStudents()
        {
            string connstring = "Server=localhost;Database=attendance;Uid=root;";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sqlQuery = "SELECT student_id, student_name, section_id FROM students WHERE section_id = @section_id";
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@section_id", sectionid);
                    listBoxStudents.Items.Clear();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Properly formatting to display Student ID first, then Name, then Section ID
                            string studentInfo = $"Student ID: {reader["student_id"]}, " +
                                                 $"Name: {reader["student_name"]}, " +
                                                 $"Section ID: {reader["section_id"]}";
                            listBoxStudents.Items.Add(studentInfo);
                        }
                    }
                }
            }
        }



        private void btnDeleteStudent_Click_1(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem is ComboBoxItem selectedStudent)
            {
                int studentId = selectedStudent.StudentId;

                string connstring = "Server=localhost;Database=attendance;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                    string sqlDelete = "DELETE FROM students WHERE student_id = @student_id";
                    using (MySqlCommand cmd = new MySqlCommand(sqlDelete, con))
                    {
                        cmd.Parameters.AddWithValue("@student_id", studentId);
                        cmd.ExecuteNonQuery();
                        LoadStudents();  // Refresh the student list
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
        public class ComboBoxItem
        {
            public int SectionId { get; set; }
            public int StudentId { get; set; }
            public string StudentName { get; set; }

            public override string ToString()
            {
                return $"Section ID: {SectionId}, Student ID: {StudentId}, Name: {StudentName}";
            }
        }




        private void buttonClose_Click(object sender, EventArgs e)
        {
         
        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connstring = "Server=localhost;Database=attendance;Uid=root;";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    // Insert new student and automatically generate student_id
                    string sqlInsert = "INSERT INTO students (student_name, section_id) VALUES (@student_name, @section_id)";
                    using (MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, con))
                    {
                        cmdInsert.Parameters.AddWithValue("@student_name", txtStudentName.Text);
                        cmdInsert.Parameters.AddWithValue("@section_id", sectionid);

                        cmdInsert.ExecuteNonQuery();
                        MessageBox.Show("Student Added Successfully!");

                        // Refresh list to display the new student with their ID
                        LoadStudents();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hides the Add Student Form without closing it completely
        }
    }
}
