using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_PackageDetail")]
   public class PackaDetail
    {
        [Key]
        [Column(Order = 0)]
        public int PackageDetailID { get; set; }
        public int PackageMasterId { get; set; }
        public int TestRegId { get; set; }
        public double TestCharges { get; set; }
        public double TestDiscPerc { get; set; }

        public double TestDiscAmount { get; set; }

        public double NetCharges { get; set; }

        public bool Isactive { get; set; }

        public int CreatedBy { get; set; }

        public Nullable<DateTime> CreatedOn { get; set; }

        public int UpdatedBy { get; set; }

        public Nullable<DateTime> UpdatedOn { get; set; }
    }
}
