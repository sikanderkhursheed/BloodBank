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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Main().Show();
            Hide();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsPatient P = new ClsPatient();
            P.Patient_Name = txtName.Text;
            P.Patient_Age=Convert.ToInt32(txtAge.Text);

            if (rdbMale.Checked == true)
            {
                P.Patient_Gender = rdbMale.Text;
            }
            else if (rdbFemale.Checked == true)
            {
                P.Patient_Gender = rdbFemale.Text;
            }

            P.Patient_BloodGroup = txtGroup.Text;
            P.Patient_Phone = Convert.ToInt32(txtContact.Text);
            P.Patient_Address = txtAddress.Text;
            P.Requested_Date = Convert.ToDateTime(datetime.Text);
            P.Patient_Disease=txtDisease.Text;
            try
            {
                P.insert();
                MessageBox.Show("Info inserted");

                dataGridView1.DataSource = new ClsPatient.PatientDAL().GetAllPAtients();
                dataGridView1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Kindly check your data..");
            }
            txtPatientId.Text = new ClsPatient.PatientDAL().GetPatientId();
            txtName.Text = "";
            txtAge.Text = "";
            txtGroup.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtContact.Text = "";
            txtAddress.Text = "";
            txtDisease.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientId.Text = new ClsPatient.PatientDAL().GetPatientId();
            txtName.Text = "";
            txtAge.Text = "";
            txtGroup.Text = "";
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
            txtContact.Text = "";
            txtAddress.Text = "";
            txtDisease.Text = "";
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            DB.getinstance();
            txtPatientId.Text = new ClsPatient.PatientDAL().GetPatientId();

            dataGridView1.DataSource = new ClsPatient.PatientDAL().GetAllPAtients();
            dataGridView1.Enabled = true;

        }

        private void Links_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsPatient Ptn = new ClsPatient();
            Ptn.Patient_Id=Convert.ToInt32(txtId.Text);
            Ptn.Patient_Name=txtPName.Text;
            Ptn.Patient_Age=Convert.ToInt32(txtPAge.Text);
           if (btnMale.Checked == true)
            {
               Ptn.Patient_Gender=btnMale.Text;
            }
           else if (btnFemale.Checked == true)
            {
                Ptn.Patient_Gender=btnFemale.Text;
            }
            Ptn.Patient_BloodGroup=txtBG.Text;
            Ptn.Patient_Phone=Convert.ToInt32(txtPContact.Text);
            Ptn.Patient_Address=txtPAddress.Text;
            Ptn.Requested_Date=Convert.ToDateTime(date.Text);
            Ptn.Patient_Disease = txtPDisease.Text;

            try
            {
                
                Ptn.update();
                MessageBox.Show("Patient Updated.");
                
                dataGridView1.DataSource = new ClsPatient.PatientDAL().GetAllPAtients();
                dataGridView1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            txtId.Text = "";
            txtPName.Text = "";
            txtPAge.Text = "";
            txtBG.Text = "";
            btnMale.Checked = false;
            btnFemale.Checked = false;
            txtPContact.Text = "";
            txtPAddress.Text = "";
            txtPDisease.Text = "";

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string gender = new ClsPatient.PatientDAL().GetGenderByID(Convert.ToInt32(txtId.Text));
           
            DB.getinstance();
             if (txtId.Text == "")
            {
            }
            else
            {
                txtPName.Text = new ClsPatient.PatientDAL().GetNameByID(Convert.ToInt32(txtId.Text));
                txtPAge.Text = new ClsPatient.PatientDAL().GetAgeByID(Convert.ToInt32(txtId.Text));
                if (gender == "Male")
                {
                    btnFemale.Checked = false;
                    btnMale.Checked = true;
                }
                else if (gender == "Female")
                {
                    btnMale.Checked = false;
                    btnFemale.Checked = true;
                }
                txtBG.Text = new ClsPatient.PatientDAL().GetBGByID(Convert.ToInt32(txtId.Text));
                txtPContact.Text = new ClsPatient.PatientDAL().GetPhoneByID(Convert.ToInt32(txtId.Text));
                txtPAddress.Text = new ClsPatient.PatientDAL().GetAddressByID(Convert.ToInt32(txtId.Text));
                date.Text = new ClsPatient.PatientDAL().GetDateByID(Convert.ToInt32(txtId.Text));
                txtPDisease.Text = new ClsPatient.PatientDAL().GetDiseaseByID(Convert.ToInt32(txtId.Text));

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            ClsPatient patient = new ClsPatient();
            patient.Patient_Id=Convert.ToInt32(txtDelete.Text);
           try
            {
                patient.delet();
                MessageBox.Show("Patient deleted succesffully.");
                dataGridView2.DataSource = null;

                dataGridView1.DataSource = new ClsPatient.PatientDAL().GetAllPAtients();
                dataGridView1.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Patient Can't be deleted.");
            }
            txtDelete.Text = "";
        }

        private void txtDelete_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodTable().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPName.Text = "";
            txtPAge.Text = "";
            txtBG.Text = "";
            btnMale.Checked = false;
            btnFemale.Checked = false;
            txtPContact.Text = "";
            txtPAddress.Text = "";
            txtPDisease.Text = "";

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Patient().Show();
            Hide();
        }

        private void txtDelete_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (txtDelete.Text == "")
                {
                    dataGridView2 = null;
                }
                else
                {
                    dataGridView2.DataSource = new ClsPatient.PatientDAL().GetPatientById(Convert.ToInt32(txtDelete.Text));
                }
                }
            catch {
                MessageBox.Show("Invalid");
                  }
            
        }

        private void pageView_Click(object sender, EventArgs e)
        {
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new BloodBank().Show();
            Hide();
        }

        private void pageAdd_Click(object sender, EventArgs e)
        {

        }
        }
    }
