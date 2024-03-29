﻿using System;
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
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PatientInfo pi = new PatientInfo();
            this.Hide();
            pi.Show();
        }

        private void BtnView_Click(object sender, EventArgs e)
        {
            ViewPatient viewPatient = new ViewPatient();
            this.Hide();
            viewPatient.Show();
        }
    }
}
