using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Model
{
    [Table("Table_W_PatientReferredType")]
    public class PatientReferrelTypeModel
    {
        [Key]
        [Column(Order = 0)]
        public int ReferredTypeId { get; set; }
        public string ReferredTypeName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
