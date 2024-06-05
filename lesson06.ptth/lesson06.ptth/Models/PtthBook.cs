using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson06.ptth.Models
{
    public class PtthBook
    {
        [Key]
        public int PtthId { get; set; }
        public string PtthBookId { get; set; }
        public string PtthTitle { get; set; }
        public string PtthAuthor { get; set; }
        public string PtthYear { get; set; }
        public string PtthPulisher { get; set; }
        public string PtthPicture { get; set; }
        public int PtthCategoryId { get; set; }
        // Thuộc tính quan hệ

        public virtual PtthCategory PtthCategory { get; set; }
    }
}