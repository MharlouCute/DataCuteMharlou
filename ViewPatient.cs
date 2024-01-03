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
    public partial class ViewPatient : Form
    {
        public ViewPatient()
        {
            InitializeComponent();
            DTPBirthdate.MaxDate = DateTime.Now;
        }
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

        public void load()
        {
            DGVPatient.Rows.Clear();

            DGVPatient.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVPatient.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "ID", "Name", "Gender", "Birthdate","Civil Status", "Address", "Phone Number" };

            DGVPatient.ColumnCount = 7;

            for (int a = 0; a < columnNames.Length; a++)
            {
                DGVPatient.Columns[a].Name = columnNames[a];
            }

            string query = "SELECT * FROM tblpatient WHERE statusA = '1' AND status = 'NOT'";
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
                       
                        DGVPatient.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void ViewPatient_Load(object sender, EventArgs e)
        {
            load();
        }

        private void DGVPatient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedrow;
                selectedrow = e.RowIndex;
                DataGridViewRow row = DGVPatient.Rows[selectedrow];

                Connection.IdContent = row.Cells[0].Value.ToString();


                string query = "SELECT * FROM tblpatient WHERE patientID = '" + Connection.IdContent + "'";

                using (MySqlConnection connect = new MySqlConnection(Connection.ConnectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connect))
                    {
                        command.CommandTimeout = 60;

                        try
                        {
                            connect.Open();

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {

                                        LblId.Text = reader.GetString(0);
                                        TbxName.Text = reader.GetString(1);
                                        CbxGender.Text = reader.GetString(2);
                                        DTPBirthdate.Text = reader.GetString(3);
                                        CbxCivilStatus.Text = reader.GetString(4);
                                        TbxAddress.Text = reader.GetString(5);
                                        TbxContact.Text = reader.GetString(6);
                                        
                                    }
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Query error: " + x.Message);
                        }
                    }
                }


            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            PatientMenu pm = new PatientMenu();
            this.Hide();
            pm.Show();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string query = "UPDATE tblpatient SET statusA = '0' WHERE patientID = '" + Connection.IdContent + "'";
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
                    MessageBox.Show("Successfully Deleted");
                    TbxName.Clear();
                    TbxAddress.Clear();
                    TbxContact.Clear();
                    CbxGender.ResetText();
                    CbxCivilStatus.ResetText();
                    DTPBirthdate.ResetText();
                    LblId.Text = "id";
                    load();

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
            load();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
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
                string query = "UPDATE tblpatient SET name = '" + TbxName.Text + "', gender = '" + CbxGender.Text + "', birthdate = '" + DTPBirthdate.Text + "', civilStatus = '" + CbxCivilStatus.Text + "', address = '" + TbxAddress.Text + "', contact = " + TbxContact.Text + " WHERE patientID = " + Connection.IdContent + "";
                MySqlConnection connect = new MySqlConnection(Connection.ConnectionString);
                MySqlCommand command = new MySqlCommand(query, connect);
                command.CommandTimeout = 60;

                try
                {
                    connect.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successfully Updated");
                        TbxName.Clear();
                        TbxAddress.Clear();
                        TbxContact.Clear();
                        CbxGender.ResetText();
                        CbxCivilStatus.ResetText();
                        DTPBirthdate.ResetText();
                        LblId.Text = "id";
                        load();
                    }
                }
                catch (Exception x)
                {
                    MessageBox.Show("Query error: " + x.Message);
                }
                finally
                {
                    connect.Close();
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
