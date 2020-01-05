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
using System.Data.SqlClient;

namespace DesktopLDDM
{
    public partial class Classrooms : Form
    {
        public static string rom = "";
        DataTable classrooms = null;
        public Classrooms(int capacity)
        {
            

            InitializeComponent();
            SqlConnection connection = DBConnector.GetInstance().GetConnection();
            classrooms = ClasroomDataGateway.Find(connection,capacity );
            //Debug.WriteLine(classrooms.capacity);

            foreach (DataRow row in classrooms.Rows)
            {
                string[] r = { "", row["room_number"].ToString(), row["capacity"].ToString() };
                listView1.Items.Add(new ListViewItem(r));
                listView1.CheckBoxes = true;
            }
        }

        private void choosed_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem h in listView1.CheckedItems)
            {
                rom = h.SubItems[1].Text;
            }

            this.Close();
        }
    }
}
