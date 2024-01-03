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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnPatient_Click(object sender, EventArgs e)
        {
            PatientMenu show = new PatientMenu();
            this.Hide();
            show.Show();
        }

        private void BtnAppoint_Click(object sender, EventArgs e)
        {
            AddCheckUpcs ac = new AddCheckUpcs();
            this.Hide();
            ac.Show();
        }

        private void BtnRecords_Click(object sender, EventArgs e)
        {
            RecordForm rf = new RecordForm();
            this.Hide();
            rf.Show();
        }

        private void LblLogout_Click(object sender, EventArgs e)
        {
            login ln = new login();
            this.Hide();
            ln.Show();
        }
    }
}
