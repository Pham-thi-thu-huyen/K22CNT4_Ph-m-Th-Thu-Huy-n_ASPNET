using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace lesson06.ptth.Models
{
    public class PtthBookStore:DbContext
    {
        public PtthBookStore() : base("PtthBookStoreConnectionString") { }

        //Khai báo các thuộc tính tương ứng với các bảng trong csdl
        public DbSet<PtthCategory> PtthCategories { get; set; }
        public DbSet<PtthBook> PtthBooks { get; set; }
    }
}