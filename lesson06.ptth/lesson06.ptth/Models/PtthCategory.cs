using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson06.ptth.Models
{
    public class PtthCategory
    {
        [Key]
        public int PtthId { get; set; }
        public string PtthCategoryName { get; set; }

        // Thuộc tính quan hệ
        public virtual ICollection<PtthBook> PtthBooks { get; set; }
    }
}