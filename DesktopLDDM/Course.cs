using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataLayer;
using DataLayer.TableDataGateway;
namespace DesktopLDDM
{
    public partial class Course : Form
    {
        public Course()
        {
            InitializeComponent();
            updateCourses();
        }

        private DataTable courses;

        private void updateCourses(string x = null)
        {
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            courses = CourseDataGateway.Find(connection);
            string level;
            DataTable classrooms;
            foreach (DataRow row in courses.Rows)
            {
                level = row["difficulty"].ToString();
                switch (level)
                {
                    case "Z":
                        level = "Beginner";
                        break;
                    case "P":
                        level = "Intermediate";
                        break;
                    case "E":
                        level = "Expert";
                        break;
                    default:
                        level = "Begginer";
                        break;
                }
                classrooms = ClasroomDataGateway.FindByID(connection, (int)row["Classroom_classroom_id"]);
                string[] r = { row["course_name"].ToString(), "rekonstrukce:" , level };
                listView1.Items.Add(new ListViewItem(r));
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCourse cc = new CreateCourse();
            cc.ShowDialog();
            this.Close();
        }

        private void FindCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            Find cc = new Find();
            cc.ShowDialog();
            this.Close();
        }
    }
}
