using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.TableDataGateway;
using DataLayer;

using DDM;
using System.Data.SqlClient;

namespace DesktopL
{
    public partial class Courses : Form
    {
        DataTable courses = null;
        public Courses()
        {
            InitializeComponent();
            updateCourses();
        }
        private void updateCourses(string x = null)
        {
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            courses = CourseDataGateway.Find(connection);
            string level;
            DataTable lector;
            foreach (DataRow row in courses.Rows)
            {
                level = row["difficulty"].ToString();
                switch(level)
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
            
                }
                lector = LectorDataGateway.FindByID(connection,(int)row["lector_idlector"]);
                string[] r = { row["course_name"].ToString(), lector.Rows[0]["first_name"].ToString() + " " + lector.Rows[0]["last_name"].ToString(), level };
                listView1.Items.Add(new ListViewItem(r));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateCourse cc = new CreateCourse();
            cc.ShowDialog();
            this.Close();
        }
    }
}
