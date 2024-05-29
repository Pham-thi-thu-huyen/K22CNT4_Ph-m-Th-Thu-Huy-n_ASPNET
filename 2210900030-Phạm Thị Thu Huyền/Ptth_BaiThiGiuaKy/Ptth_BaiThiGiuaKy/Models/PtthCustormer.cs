using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ptth_BaiThiGiuaKy.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Ptth_BaiThiGiuaKy.Models
{
    public class PtthCustormer
    {
        
        [DisplayName("ID")]

        public string Ptth_2210900030_CustId { get; set; }
        [Required(ErrorMessage ="Ptth:Hãy nhập ID")]
        
        [DisplayName("FullName")]
        public string Ptth_FullName { get; set; }
        [Required(ErrorMessage = "Ptth:Hãy nhập Fullname")]


        [DisplayName("Address")]

        public string Ptth_Address { get; set; }
        [Required(ErrorMessage = "Ptth:Hãy nhập Address")]


        [DisplayName("Email")]

        public string Ptth_Email { get; set; }
        [Required(ErrorMessage = "Ptth:Hãy nhập Email")]


        [DisplayName("Phone")]

        public string Ptth_Phone { get; set; }
        [Required(ErrorMessage = "Ptth:Hãy nhập Phone")]


        [DisplayName("Balance")]

        public int Ptth_Balance { get; set; }

    }
}
