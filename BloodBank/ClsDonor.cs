using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    class ClsDonor
    {
        public int Donor_Id { get; set; }
        public string Donor_Name { get; set; }
        public int Donor_Age { get; set; }
        public string Donor_BloodGroup { get; set; }
        public string Donor_Gender { get; set; }
        public int Donor_Phone { get; set; }
        public string Donor_Address { get; set; }
        public int Branch_Id { get; set; }
        public int Delete { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public class DonorDAL
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter dad;

            public string GetDonorId()
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select count (*) +1from Donor", conn);
                string id = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return id;
            }
            public DataTable GetAllDonor()
            {
                conn = DB.getinstance();
                dad = new SqlDataAdapter("Select * from Donor", conn);
                DataTable dtDonor = new DataTable();
                dad.Fill(dtDonor);

                return dtDonor;
            }

            public DataTable GetDDonorsByBG(string bg)
            {
                conn = DB.getinstance();
                conn.Open();
                DataTable dtBG = new DataTable();
                dad = new SqlDataAdapter("SELECT * FROM Donor where Donor_BloodGroup LIKE  @bg ", conn);
                dad.SelectCommand.Parameters.AddWithValue("@bg", bg);
                dad.Fill(dtBG);

                return dtBG;
            }
            public DataTable GetDonorById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                DataTable dtDonor = new DataTable();
                dad = new SqlDataAdapter("SELECT * FROM Donor where Donor_Id = @id ", conn);
                dad.SelectCommand.Parameters.AddWithValue("@id", id);
                dad.Fill(dtDonor);
                return dtDonor;
            }
            public string GetNameById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_Name FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;
            }
            public string GetAgeById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_Age FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;

            }
            public string GetBGById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_BloodGroup FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;

            }
            public string GetGenderById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_Gender FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;

            }
            public string GetPhoneById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_Phone FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;

            }
            public string GetAddressById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("SELECT Donor_Address FROM Donor WHERE Donor_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();

                return name;
            }
            //public string GetBIDById(int id)
            //{
            //    conn = DB.getinstance();
            //    conn.Open();
            //    cmd = new SqlCommand("SELECT BranchId FROM Donor WHERE Donor_Id=@id", conn);
            //    cmd.Parameters.AddWithValue("@id", id);
            //    string name = Convert.ToString(cmd.ExecuteScalar());
            //    conn.Close();

            //    return name;
            //}

        }
        public void insert() {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
            SqlCommand cmd2;
            cmd = new SqlCommand("INSERT INTO Donor(Donor_Name,Donor_Age,Donor_BloodGroup,Donor_Gender,Donor_Phone,Donor_Address,Date)VALUES(@name,@age,@bg,@gender,@phone,@address,@date)", conn);
            cmd.Parameters.AddWithValue("@name", Donor_Name);
            cmd.Parameters.AddWithValue("@age", Donor_Age);
            cmd.Parameters.AddWithValue("@bg", Donor_BloodGroup);
            cmd.Parameters.AddWithValue("@gender", Donor_Gender);
            cmd.Parameters.AddWithValue("@phone", Donor_Phone);
            cmd.Parameters.AddWithValue("@address", Donor_Address);
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
            cmd2 = new SqlCommand("INSERT INTO Blood(Donor_Id,BranchId)VALUES(@id,@BID)", conn);
            cmd2.Parameters.AddWithValue("@id", Donor_Id);
            cmd2.Parameters.AddWithValue("@BID", Branch_Id);
            cmd2.ExecuteNonQuery();
        }
        public void delete() {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("DELETE Donor WHERE Donor_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", Delete);
            cmd.ExecuteNonQuery();
        }
        public void update() {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
             cmd = new SqlCommand("update Donor SET Donor_Name=@name,Donor_Age=@age,Donor_BloodGroup=@bg,Donor_Gender=@gender,Donor_Phone=@phone,Donor_Address=@address Where Donor_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@age", Age);
            cmd.Parameters.AddWithValue("@bg", BloodGroup);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@phone", Phone);
            cmd.Parameters.AddWithValue("@address", Address);
           // cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.ExecuteNonQuery();
        }

    }
}