using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ContactWebApplication.Models
{
    public class ContactEntity : DbContext
    {
        public ContactEntity()
            : base("name=ContactEntity")
        {
        }

     
        public virtual DbSet<contact_mst_table> contact_mst_table { get; set; }
    }
}