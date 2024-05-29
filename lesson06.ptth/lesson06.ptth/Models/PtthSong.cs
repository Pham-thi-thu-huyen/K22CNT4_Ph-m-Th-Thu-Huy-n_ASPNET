using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lesson06.ptth.Models
{
    public class PtthSong
    {
        [Key]
      
        public string Id { get; set; }
        [Required(ErrorMessage ="Hãy nhập tiêu đề")]
        [DisplayName("Tiêu đề")]
        public string PtthTitle { get; set;  }
        [Required(ErrorMessage = "Hãy nhập tác giả")]
        [DisplayName("Tác giả")]
        public string PtthAuthor { get; set; }
        [Required(ErrorMessage = "Hãy nhập nghệ sĩ")]
        [DisplayName("Nghệ sĩ")]
        [StringLength(50, MinimumLength =2, ErrorMessage ="Ptth:Tên nghệ sĩ tối thiểu 2 kí tự, tối đa 50 kí tự")]
        public string PtthArtist { get; set; }
        [Required(ErrorMessage = "Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage ="Ptth: Nhập xuất bản phải có 2 kí tự số")]
        [Range(1900,2024, ErrorMessage ="Ptth: Năm xuất bản trong khoảng 1900-2024")]
        [DisplayName("Năm xuất bản")]
        public int PtthYearRelease { get; set; }



    }
}