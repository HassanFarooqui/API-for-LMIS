using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_Patientinfo_Master")]
    public class Patient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GuardianName { get; set; }
        public int Age { get; set; }
        public int? GenderID { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public string CNIC { get; set; }
        public bool IsActive { get; set; }
        public int? CreatedBy { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public int? ReferredTypeId { get; set; }
        public int? ReferringPartnerID { get; set; }
        public int? panelID { get; set; }
        public string DepartmentName { get; set; }
        public string EmpReferrenceNo { get; set; }
        public bool? Diabetes { get; set; }
        public bool? TB { get; set; }
        public bool? Hepatitis { get; set; }
        public bool? Fever { get; set; }
        public bool? Other { get; set; }


    }
}
