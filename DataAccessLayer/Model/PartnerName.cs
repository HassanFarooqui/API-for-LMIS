using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Table_W_PartnerName")]
    public class PartnerName
    {
        [Key]
        [Column(Order = 0)]
        public int ReferringPartnerID { get; set; }
        public string ReferringPartnerName { get; set; }
        public int? GenderID { get; set; }
        public string PhoneNo { get; set; }
        public string CNIIC { get; set; }
        public string clinicName { get; set; }
        public string ClinicNo { get; set; }
        public string ClinicAddress { get; set; }
        public string PMDCNumber { get; set; }
        public string BankAccNO { get; set; }
        public bool IsActive { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public int? Updatedby { get; set; }


    }
}
