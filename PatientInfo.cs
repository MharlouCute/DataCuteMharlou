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
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
            DTPBirthdate.MaxDate = DateTime.Now;
        }

        int id = 1;
        DateTime currentDate = DateTime.Now;
        bool number = false;

        public void testingP()
        {
            int desiredLength = 11;

            if (TbxContact.Text.Length != desiredLength)
            {
                number = true;
            }
            else
            {
                number = false;
            }
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            string query = "SELECT count(*) from tblpatient";
            MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connect);

            connect.Open();
            long rowCount = (long)command.ExecuteScalar();
            connect.Close();
            if (rowCount == 0)
            {
                LblId.Text = id.ToString();
            }
            else
            {
                string query2 = "SELECT patientID from tblpatient order by patientID desc limit 1;";
                MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command2 = new MySqlCommand(query2, connect2);
                connect2.Open();
                id = (int)command2.ExecuteScalar();
                id += 1;
                LblId.Text = id.ToString();
                connect2.Close();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PatientMenu pm = new PatientMenu();
            this.Hide();
            pm.Show();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            testingP();

            if (number == true)
            {
                number = false;
                MessageBox.Show("Invalid Phone Number", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxContact.Clear();

            }
            else
            {
                string query = "INSERT INTO tblpatient(patientID,name,gender,birthdate,civilStatus,address,contact,statusA,status) VALUES (" + LblId.Text + ",'" + TbxName.Text + "','" + CbxGender.Text + "','" + DTPBirthdate.Text + "','" + CbxCivilStatus.Text + "','" + TbxAddress.Text + "'," + TbxContact.Text + ",'1', 'NOT')";
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);
                command.CommandTimeout = 60;

                try
                {
                    connect.Open();

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                    }
                    else
                    {

                        MessageBox.Show("Successfully Save");
                        TbxName.Clear();
                        TbxAddress.Clear();
                        TbxContact.Clear();
                        CbxGender.ResetText();
                        CbxCivilStatus.ResetText();
                        DTPBirthdate.ResetText();
                        id++;
                        LblId.Text = id.ToString();


                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
            }
        }

        private void DTPBirthdate_ValueChanged(object sender, EventArgs e)
        {
            if (DTPBirthdate.Value > DateTime.Now)
            {
                DTPBirthdate.Value = DateTime.Now;
            }
        }
    }
}
