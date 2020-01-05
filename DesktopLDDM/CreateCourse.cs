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
using DataLayer.TableDataGateway;
using DataLayer;

namespace DesktopLDDM
{
    public partial class CreateCourse : Form
    {
        SqlConnection connection;
        string c_name;
        char c_level;
        int c_capacity;
        int c_class;
        int c_number;
        public class ComboboxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        public CreateCourse()
        {
            InitializeComponent();
            connection = DBConnector.GetInstance().GetConnection();
            DataTable lectors = LectorDataGateway.Find(connection);
            foreach (DataRow row in lectors.Rows)
            {
                lector.Items.Add(new ComboboxItem()
                {
                    Text = row["last_name"].ToString(),
                });
            } 
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            c_number = int.Parse(course_id.Text);
            c_name = name.Text;
            c_level = char.Parse(level.Text);
            string c_lector = lector.Text;
            c_capacity = int.Parse(capacity.Text);
            c_class = int.Parse(room.Text);

            CourseDataGateway.Insert(connection,c_number,c_name, c_level, c_capacity, c_class);
        }
    }
}
