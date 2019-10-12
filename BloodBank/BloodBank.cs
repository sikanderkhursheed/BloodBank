using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class BloodBank : Form
    {
        public BloodBank()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Patient().Show();
            Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodTable().Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Main().Show();
            Hide();
        }

        private void BloodBank_Load(object sender, EventArgs e)
        {

            DB.getinstance();
            DGBB.DataSource = new ClsBloodBank.BBDAL().GetAllBB();
            DGBB.Enabled= true;

            DGReports.DataSource = new ClsBloodBank.BBDAL().Reports();
            DGReports.Enabled= true;
      
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodBank().Show();
            Hide();
        }

        private void LogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().Show();
            Hide();
        }

        private void DGReports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
