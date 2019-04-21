using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_dz1._7
{
    public partial class Form1 : Form
    {
        private TimeSpan result;
        public Form1()
        {
            InitializeComponent();
        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            DateTime data = dtpData.Value;
            DateTime now = DateTime.Now;
            result = data - now;
        }

        private void rdbGod_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGod.Checked == true)
            {
                txbResult.Text = (result.Days / 365.0).ToString();
            }
        }

        private void rdbMesaz_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMesaz.Checked == true)
            {
                txbResult.Text = (result.Days / 30.0).ToString();
            }
        }

        private void rdbDen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDen.Checked == true)
            {
                txbResult.Text = (result.Days).ToString();
            }
        }

        private void rdbMinuta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMinuta.Checked == true)
            {
                txbResult.Text = (result.TotalMinutes).ToString();
            }
        }

        private void rdbSecunda_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSecunda.Checked == true)
            {
                txbResult.Text = (result.TotalSeconds).ToString();
            }
        }
    }
}