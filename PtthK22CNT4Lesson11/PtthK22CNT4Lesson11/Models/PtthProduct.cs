﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PtthK22CNT4Lesson11.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PtthProduct
    {
        [Display(Name = "Mã sản phẩm")]
        public string Ptthid2210900030 { get; set; }
        public string PtthProName { get; set; }
        public Nullable<int> PtthQty { get; set; }
        public Nullable<double> PtthPrice { get; set; }
        public Nullable<int> PtthCateId { get; set; }
        public Nullable<bool> PtthActive { get; set; }
    }
}
