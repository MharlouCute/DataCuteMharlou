using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DentalClinic
{
    public partial class AddCheckUpcs : Form
    {
        public AddCheckUpcs()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm am = new MainForm();
            this.Hide();
            am.Show();
        }

        public void load()
        {
            DGVPatient.Rows.Clear();

            DGVPatient.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(DGVPatient.Font, System.Drawing.FontStyle.Bold);
            string[] columnNames = new string[] { "ID", "Name", "Gender", "Birthdate", "Civil Status", "Address", "Phone Number" };

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

                        DGVPatient.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
        }

        private void AddCheckUpcs_Load(object sender, EventArgs e)
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

        int dcleanings = 500;
        int dexam = 500;
        int filling = 700;
        int crowns = 2500;
        int bridges = 3000;
        int dentures = 500;
        int braces = 3000;
        int retain = 2000;
        int white = 3000;
        int veneers = 1000;
        int tooth = 1000;

        private void BtnDone_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO checkup(patientID,name,type,cost,cash) VALUES ("+LblId.Text + ",'" + TbxName.Text + "','" + CbxType.Text + "'," + TbxCost.Text + "," + TbxCash.Text +")";
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

                    MessageBox.Show("Successfully Done");
                    TbxName.Clear();
                    CbxType.ResetText();
                    TbxCost.Clear();
                    TbxCash.Clear();
                    LblChange.ResetText();
                    LblId.Text = "ID";
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

            string query2 = "UPDATE tblpatient SET status = 'DONE' WHERE patientID = '" + Connection.IdContent + "'";
            MySqlConnection connect2 = new MySqlConnection(Connection.ConnectionString);
            MySqlCommand command2 = new MySqlCommand(query2, connect2);
            command2.CommandTimeout = 60;


            try
            {
                connect2.Open();

                MySqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                {
                }
                else
                {
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Query error: " + x.Message);
            }
            load();
        }

        private void CbxType_MouseLeave(object sender, EventArgs e)
        {
          
            if (CbxType.Text == "Dental Cleanings")
            {
                TbxCost.Text = dcleanings.ToString();
            }
            else if(CbxType.Text == "Dental Exams")
            {
                TbxCost.Text = dexam.ToString();
            }
            else if (CbxType.Text == "Fillings")
            {
                TbxCost.Text = filling.ToString();
            }
            else if (CbxType.Text == "Crowns")
            {
                TbxCost.Text = crowns.ToString();
            }
            else if (CbxType.Text == "Bridges")
            {
                TbxCost.Text = bridges.ToString();
            }
            else if (CbxType.Text == "Dentures")
            {
                TbxCost.Text = dentures.ToString();
            }
            else if (CbxType.Text == "Braces")
            {
                TbxCost.Text = braces.ToString();
            }
            else if (CbxType.Text == "Retainers")
            {
                TbxCost.Text = retain.ToString();
            }
            else if (CbxType.Text == "Teeth Whitening")
            {
                TbxCost.Text = white.ToString();
            }
            else if (CbxType.Text == "Veneers")
            {
                TbxCost.Text = veneers.ToString();
            }
            else if (CbxType.Text == "Tooth Extractions")
            {
                TbxCost.Text = tooth.ToString();
            }
        }

        private void TbxCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if(!char.IsDigit(num) && num != 8 && num != 46)
            {
                e.Handled = true;
            }
        }

        private void TbxCash_KeyDown(object sender, KeyEventArgs e)
        {
            double cost = 0;
            double cash = 0;

            if (e.KeyCode == Keys.Enter)
            {

                if (TbxCash.Text == "")
                {
                    MessageBox.Show("Enter a Money", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cost = int.Parse(TbxCost.Text);
                    cash = int.Parse(TbxCash.Text);


                    if (cash >= cost)
                    {
                        double change = cash - cost;
                        LblChange.ForeColor = Color.Black;
                        LblChange.Text = change.ToString();
                    }
                    else
                    {
                        LblChange.ForeColor = Color.Red;
                        LblChange.Text = "Insufficient Amount of Money";
                    }
                }
            }
        }

        private void CbxType_TextChanged(object sender, EventArgs e)
        {
            if (CbxType.Text == "Dental Cleanings")
            {
                TbxCost.Text = dcleanings.ToString();
            }
            else if (CbxType.Text == "Dental Exams")
            {
                TbxCost.Text = dexam.ToString();
            }
            else if (CbxType.Text == "Fillings")
            {
                TbxCost.Text = filling.ToString();
            }
            else if (CbxType.Text == "Crowns")
            {
                TbxCost.Text = crowns.ToString();
            }
            else if (CbxType.Text == "Bridges")
            {
                TbxCost.Text = bridges.ToString();
            }
            else if (CbxType.Text == "Dentures")
            {
                TbxCost.Text = dentures.ToString();
            }
            else if (CbxType.Text == "Braces")
            {
                TbxCost.Text = braces.ToString();
            }
            else if (CbxType.Text == "Retainers")
            {
                TbxCost.Text = retain.ToString();
            }
            else if (CbxType.Text == "Teeth Whitening")
            {
                TbxCost.Text = white.ToString();
            }
            else if (CbxType.Text == "Veneers")
            {
                TbxCost.Text = veneers.ToString();
            }
            else if (CbxType.Text == "Tooth Extractions")
            {
                TbxCost.Text = tooth.ToString();
            }
        }
    }
}
