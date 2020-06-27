using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_TestList")]
    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }

        public int? TestTypeId { get; set; }
        public decimal? TestCharges { get; set; }

        public double? TestDiscPerc { get; set; }

        public double? TestDiscAmount { get; set; }

        public double? NetCharges { get; set; }

        public bool IsActive { get; set; }

        public int? CreatedBy { get; set; }

        public Nullable<DateTime> CreatedOn { get; set; }

        public int? UpdateBy { get; set; }
        public Nullable<DateTime> UpdateOn { get; set; }
    }
}
