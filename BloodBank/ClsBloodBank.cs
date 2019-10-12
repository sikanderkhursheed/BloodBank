using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank
{
    class ClsBloodBank
    {
        public int BranchId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public class BBDAL
        {
            SqlConnection conn;
            SqlCommand cmd;
            SqlDataAdapter dad;

            public DataTable GetAllBB()
            {
                conn = DB.getinstance();
                dad = new SqlDataAdapter("Select * from BloodBank", conn);
                DataTable dtBloodbank = new DataTable();
                dad.Fill(dtBloodbank);

                return dtBloodbank;
            }

            public DataTable Reports() {
                conn = DB.getinstance();
                dad = new SqlDataAdapter("SELECT d.Date, d.Donor_id, d.Donor_Name, d.Donor_BloodGroup, b.Branchid, b.City from Donor d, BloodBank b", conn);
                DataTable dtBloodbank = new DataTable();
                dad.Fill(dtBloodbank);

                return dtBloodbank;
            }
        }
    }
}
