using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using System.Data.SqlClient;
using DataLayer.TableDataGateway;
namespace DesktopLDDM
{
    public partial class Find : Form
    {
        private SqlConnection connection;
        public Find()
        {
            InitializeComponent();
            connection = DBConnector.GetInstance().GetConnection();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataTable course = CourseDataGateway.FindCourse(connection,courseName.Text);
            MessageBox.Show(courseName.Text);
        }
    }
}
