using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_TestType")]
    public class TestType
    {
        [Key]
        [Column(Order = 0)]
        public int TestTypeId { get; set; }

        public string TesttypeName { get; set; }

        public string Descrp { get; set; }

        public bool IsActive { get; set; }

        public int? CreatedBy { get; set; }

        public Nullable<DateTime> CreatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public Nullable<DateTime> UpdatedOn { get; set; }


    }
}
