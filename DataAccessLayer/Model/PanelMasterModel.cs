using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    [Table("Table_W_PanelMaster")]
   public class PanelMasterModel
    {
        [Key]
        [Column(Order = 0)]
        public int PanelMasterId { get; set; }
        public string PanelName { get; set; }
        public bool IsActive { get; set; }
        public Nullable<DateTime> CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public Nullable<DateTime> UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }

    }
}
