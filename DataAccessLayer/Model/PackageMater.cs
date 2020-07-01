using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_PackageMaster")]
  public class PackageMater
    {
        [Key]
        [Column(Order = 0)]
        public int PackageMasterId { get; set; }

        public string PackageName { get; set; }

        public bool IsIncentiveAllowed { get; set; }

        public bool IsPartialPackageBookingAllowed { get; set; }

        public bool IsActive { get; set; }

        public int CreatedBy { get; set; }

        public Nullable<DateTime> CreatedOn { get; set; }

        public int UpdatedBy { get; set; }

        public Nullable<DateTime> UpdatedOn { get; set; }
    }
}
