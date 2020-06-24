using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    [Table("Table_W_Gender")]
    public class GenderModel
    {
        [Key]
        [Column(Order = 0)]
        public int GenderID { get; set; }
        public string Description { get; set; }
    }
}
