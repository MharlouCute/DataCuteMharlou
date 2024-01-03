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

namespace DentalClinic
{
    public partial class RecordForm : Form
    {
        public RecordForm()
        {
            InitializeComponent();
        }

        public void load(string query, DataGridView dgv)
        {
            dgv.Rows.Clear();

            dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVPatient.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "ID", "Name", "Gender", "Birthdate", "Civil Status", "Address", "Phone Number" };

            dgv.ColumnCount = 7;

            for (int a = 0; a < columnNames.Length; a++)
            {
                dgv.Columns[a].Name = columnNames[a];
            }

            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);
            command.CommandTimeout = 60;

            try
            {
                connect.Open();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        dgv.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tblpatient WHERE statusA = '1' AND status = 'NOT'";
            string query2 = "SELECT * FROM tblpatient WHERE statusA = '1' AND status = 'DONE'";

            load(query, DGVPatient);
            load(query2, DGVCheckUp);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            this.Hide();
            frm.Show();
        }
    }
}
