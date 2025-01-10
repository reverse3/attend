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
using static WindowsFormsApp1.AddStudentForm;

namespace WindowsFormsApp1
{

    public partial class Dashboard : Form
    {
        private int teacherNum;
        private int loggedInTeacherNum;

        public Dashboard(int teacherNum)
        {
            InitializeComponent();
            this.loggedInTeacherNum = teacherNum;
            LoadSections();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadSections();
        }

        public void LoadSections()
        {
            string connstring = "Server=localhost;Database=attendance;Uid=root;";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sqlQuery = "SELECT section_name, section_id FROM section WHERE TeacherNum = @teacherNum";
                using (MySqlCommand cmd = new MySqlCommand(sqlQuery, con))
                {
                    cmd.Parameters.AddWithValue("@teacherNum", loggedInTeacherNum);
                    listBoxSections.Items.Clear(); // Clear any previous items
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ComboBoxItem item = new ComboBoxItem
                            {
                                Text = reader["section_name"].ToString(),
                                Value = reader["section_id"].ToString() // Store section_id as Value
                            };
                            listBoxSections.Items.Add(item);
                        }
                    }
                }
            }
            lblwelcome.Text = $"Welcome, Teacher {teacherNum}!";
        }

        // Open the AddStudentForm with the selected section
        private void OpenAddStudentForm(int sectionId)
        {
            AddStudentForm addStudentForm = new AddStudentForm(sectionId);
            addStudentForm.ShowDialog();
        }




        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btnTakeAttendance_Click(object sender, EventArgs e)
        {
            AddAttendanceForm attendanceForm = new AddAttendanceForm(loggedInTeacherNum);
            attendanceForm.ShowDialog();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            ViewAttendanceForm viewAttendanceForm = new ViewAttendanceForm(loggedInTeacherNum);
            viewAttendanceForm.ShowDialog();
        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = new AddSectionForm(this, loggedInTeacherNum);
            addSectionForm.ShowDialog();
        }
        private void listBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSections.SelectedItem != null)
            {
                ComboBoxItem selectedSection = (ComboBoxItem)listBoxSections.SelectedItem;
                int selectedSectionId = Convert.ToInt32(selectedSection.Value);
                // Open the Student Management Form for the selected section
                OpenAddStudentForm(selectedSectionId);
            }
        }

        private void btnOpenAddStudentForm_Click(object sender, EventArgs e)
        {
            if (listBoxSections.SelectedItem != null)
            {
                ComboBoxItem selectedSection = (ComboBoxItem)listBoxSections.SelectedItem;
                int sectionID = Convert.ToInt32(selectedSection.Value);
                AddStudentForm studentForm = new AddStudentForm(sectionID);
                studentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a section first.");
            }
        }

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text; // This will display the section name in the ListBox
            }
        }


    }
}
