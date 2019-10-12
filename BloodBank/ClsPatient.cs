using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    class ClsPatient
    {
        public int Patient_Id { get; set; }
        public string Patient_Name { get; set; }
        public int Patient_Age { get; set; }
        public string Patient_Gender { get; set; }
        public string Patient_BloodGroup { get; set; }
        public int Patient_Phone { get; set; }
        public string Patient_Address { get; set; }
        public DateTime Requested_Date { get; set; }
        public string Patient_Disease { get; set; }
        public class PatientDAL
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter dad;

            public string GetPatientId()
            {

                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select count (*) +1from Patient", conn);
                string id = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return id;
            }
            public DataTable GetAllPAtients()
            {
                conn = DB.getinstance();
                dad = new SqlDataAdapter("Select * from Patient", conn);
                DataTable dtPatients = new DataTable();
                dad.Fill(dtPatients);

                return dtPatients;
            }
            public DataTable GetPatientById(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                DataTable dtPatient = new DataTable();
                dad = new SqlDataAdapter("SELECT * FROM Patient where Patient_Id = @id ", conn);
                dad.SelectCommand.Parameters.AddWithValue("@id", id);
                dad.Fill(dtPatient);
                return dtPatient;
            }
            public string GetNameByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Name from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetAgeByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Age from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetGenderByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Gender from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetBGByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_BloodGroup from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetPhoneByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Phone from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetAddressByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Address from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetDateByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Requested_Date from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
            public string GetDiseaseByID(int id)
            {
                conn = DB.getinstance();
                conn.Open();
                cmd = new SqlCommand("select Patient_Disease from Patient where Patient_Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                string name = Convert.ToString(cmd.ExecuteScalar());
                conn.Close();
                return name;
            }
        }
        public void insert()
        {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("INSERT INTO Patient(Patient_Name,Patient_Age,Patient_Gender,Patient_BloodGroup,Patient_Phone,Patient_Address,Requested_Date,Patient_Disease)VALUES(@name,@age,@gender,@bg,@phone,@address,@date,@disease)", conn);
            cmd.Parameters.AddWithValue("@name", Patient_Name);
            cmd.Parameters.AddWithValue("@age", Patient_Age);
            cmd.Parameters.AddWithValue("@gender", Patient_Gender);
            cmd.Parameters.AddWithValue("@bg", Patient_BloodGroup);
            cmd.Parameters.AddWithValue("@phone", Patient_Phone);
            cmd.Parameters.AddWithValue("@address", Patient_Address);
            cmd.Parameters.AddWithValue("@date", Requested_Date);
            cmd.Parameters.AddWithValue("@disease", Patient_Disease);
            cmd.ExecuteNonQuery();
        }
        public void delet() { 
        
        SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("DELETE Patient WHERE Patient_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", Patient_Id);
            cmd.ExecuteNonQuery();
        }
        public void update() {
            SqlConnection conn;
            conn = DB.getinstance();
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("update Patient SET Patient_Name=@name,Patient_Age=@age,Patient_Gender=@gender,Patient_BloodGroup=@bg,Patient_Phone=@phone,Patient_Address=@address, Requested_Date=@date,Patient_Disease=@disease Where Patient_Id=@id", conn);
            cmd.Parameters.AddWithValue("@id", Patient_Id);
            cmd.Parameters.AddWithValue("@name", Patient_Name); ;
            cmd.Parameters.AddWithValue("@age",Patient_Age);
            cmd.Parameters.AddWithValue("@gender", Patient_Gender);
            cmd.Parameters.AddWithValue("@bg", Patient_BloodGroup);
            cmd.Parameters.AddWithValue("@phone", Patient_Phone);
            cmd.Parameters.AddWithValue("@address", Patient_Address);
            cmd.Parameters.AddWithValue("@date", Requested_Date);
            cmd.Parameters.AddWithValue("@disease",Patient_Disease);

            cmd.ExecuteNonQuery();
         
                   }
    }
}

