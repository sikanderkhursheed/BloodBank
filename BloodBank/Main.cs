using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBank
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tabPage1_BackgroundImageChanged(object sender, EventArgs e)
        {


        }

        private void Tabs_Paint(object sender, PaintEventArgs e)
        {

        }

     private void btnClear_Click(object sender, EventArgs e)
    {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsDonor D = new ClsDonor();
            D.Delete = Convert.ToInt32(txtDelete.Text);

            try
            {
                D.delete();
                MessageBox.Show("Donor deleted succesffully.");
                dataGridView1.DataSource = null;

                dataGridView2.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
                dataGridView2.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Donor Can't be deleted.");
            }
            txtDelete.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new Main().Show();
            Hide();     
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDonorAddreess_Click(object sender, EventArgs e)
        {

        }

        private void lblDonorAge_Click(object sender, EventArgs e)
        {

        }

        private void lblDonorName_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsDonor D = new ClsDonor();
            D.Donor_Name = txtDonorName.Text;
            D.Donor_Age = Convert.ToInt32(txtDonorAge.Text);
            D.Donor_BloodGroup = txtBloodGroup.Text;
            if (rdbMale.Checked == true)
            {
                D.Donor_Gender = rdbMale.Text;
            }
            else if (rdbFemale.Checked == true)
            {
                D.Donor_Gender = rdbFemale.Text;
            }
            D.Donor_Phone = Convert.ToInt32(txtDonorContact.Text);
            D.Donor_Address = txtAddress.Text;
            D.Donor_Id = Convert.ToInt32(txtDonorId.Text);
            D.Branch_Id = Convert.ToInt32(txtBranch.Text);
           
            try
            {
                D.insert();
                MessageBox.Show("Info inserted");

                txtDonorId.Text = new ClsDonor.DonorDAL().GetDonorId();
                txtDonorName.Text = "";
                txtDonorAge.Text = "";
                txtBloodGroup.Text = "";
                txtBloodGroup.Text = "";
                rdbMale.Checked = false;
                rdbFemale.Checked = false;
                txtDonorContact.Text = "";
                txtAddress.Text = "";
                txtBranch.Text = "";

                dataGridView2.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
                dataGridView2.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Kindly check your data..");
            }
            
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtDonorId.Text = new ClsDonor.DonorDAL().GetDonorId();
            txtDonorName.Text = "";
            txtDonorAge.Text = "";
            txtBloodGroup.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtDonorContact.Text = "";
            txtAddress.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pageDonor_Click(object sender, EventArgs e)
        {
            DB.getinstance();
            txtDonorId.Text = new ClsDonor.DonorDAL().GetDonorId();
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDelete.Text == "")
                {
                    dataGridView1.DataSource = null;
                }
                else
                {
                    dataGridView1.DataSource = new ClsDonor.DonorDAL().GetDonorById(Convert.ToInt32(txtDelete.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid");
            }
  
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //dataGridView2.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
            //dataGridView2.Enabled = true;
        }

        private void txtBG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtBG.Text == "All")
            {
                dataGridView3.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
            }
            else if (txtBG.Text == "")
            {
                dataGridView3.DataSource = null;
            }
            else { 
            dataGridView3.DataSource = new ClsDonor.DonorDAL().GetDDonorsByBG(txtBG.Text);
            }
          }
        

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if (textBox1.Text=="")
           {
               dataGridView4.DataSource = null;
           }
           else{
            dataGridView4.DataSource = new ClsDonor.DonorDAL().GetDonorById(Convert.ToInt32(textBox1.Text));
           }
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

            DB.getinstance();
            txtDonorId.Text = new ClsDonor.DonorDAL().GetDonorId();

            dataGridView2.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
            dataGridView2.Enabled = true;
        }

        private void txtDonorId_TextChanged_1(object sender, EventArgs e)
        {
                    }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Patient().Show();
            Hide();
        }

        private void txtDonorContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtDonorAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDonorPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblDonorGender_Click(object sender, EventArgs e)
        {

        }

        private void lblBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void lblDonorAge_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDonorName_Click_1(object sender, EventArgs e)
        {

        }

        private void lblDonorId_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsDonor Donor = new ClsDonor();

            Donor.Id =Convert.ToInt32( txtId.Text);
            Donor.Name = txtName.Text;
            Donor.Age = Convert.ToInt32(txtAge.Text);
            Donor.BloodGroup = bg.Text;
            if (btnMale.Checked == true)
            {
                Donor.Gender = btnMale.Text;
            }
            else if (btnFemale.Checked == true)
            {
                Donor.Gender = btnFemale.Text;
            }
            Donor.Phone = Convert.ToInt32(txtContact.Text);
            Donor.Address = txtDAddress.Text;
            try
            {
                Donor.update();
            MessageBox.Show("Donor Updated.");

            dataGridView2.DataSource = new ClsDonor.DonorDAL().GetAllDonor();
            dataGridView2.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            bg.Text = "";
            btnMale.Checked = false;
            btnFemale.Checked = false;
            txtContact.Text = "";
            txtDAddress.Text = "";

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            DB.getinstance();
            string name2 = new ClsDonor.DonorDAL().GetGenderById(Convert.ToInt32(txtId.Text));
            if (txtId.Text == "")
            {
            }
            else
            {
                txtName.Text = new ClsDonor.DonorDAL().GetNameById(Convert.ToInt32(txtId.Text));
                txtAge.Text = new ClsDonor.DonorDAL().GetAgeById(Convert.ToInt32(txtId.Text));
                bg.Text = new ClsDonor.DonorDAL().GetBGById(Convert.ToInt32(txtId.Text));
                if (name2 == "Male")
                {
                    btnFemale.Checked = false;
                    btnMale.Checked = true;
                }
                else if (name2 == "Female")
                {
                    btnMale.Checked = false;
                    btnFemale.Checked = true;
                }
                txtContact.Text = new ClsDonor.DonorDAL().GetPhoneById(Convert.ToInt32(txtId.Text));
                txtDAddress.Text = new ClsDonor.DonorDAL().GetAddressById(Convert.ToInt32(txtId.Text));
            
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtAge.Text = "";
            bg.Text = "";
            btnMale.Checked = false;
            btnFemale.Checked = false;
            txtContact.Text = "";
            txtDAddress.Text = "";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodTable().Show();
            Hide();
        }

        private void Heading_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Main().Show();
            Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodBank().Show();
            Hide();
        }

        private void pageUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
