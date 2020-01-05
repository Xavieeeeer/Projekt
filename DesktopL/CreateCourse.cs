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
    public partial class CreateCourse : Form
    {
        DataTable courses=null;
        public CreateCourse()
        {
            InitializeComponent();
        }
        string c_name;
        private char c_level;
        private int c_capacity;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        // Button3 = Create 
        private void button3_Click(object sender, EventArgs e)
        {
            c_name = NameTextBox.Text;
            c_level = char.Parse(Level.Text);
            string c_lector = Lector.Text;
            c_capacity = int.Parse(Capacity.Text);
            SqlConnection connection = DBConnector.GetInstance().GetConnection();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_name = NameTextBox.Text;
            c_level = char.Parse(Level.Text);
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            if (CourseDataGateway.CourseIsValid(c_name, c_level, connection))
            {
                NameTextBox.BackColor = Color.Green;
                Level.BackColor = Color.Green;
                NameTextBox.ForeColor = Color.White;
                Level.ForeColor = Color.White;
            }
            else
                MessageBox.Show("spatne");
        }
    }
}
