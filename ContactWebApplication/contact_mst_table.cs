//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class contact_mst_table
    {
      
        public int cont_id { get; set; }
        [Display(Name = "First Name")]
        public string cont_first_name { get; set; }
        [Display(Name = "Last Name")]
        public string cont_last_name { get; set; }
        [Display(Name = "Email")]
        public string cont_email { get; set; }
        [Display(Name = "Phone Number")]
        public string cont_phone_number { get; set; }

        [Display(Name = "Address")]
        public string cont_address { get; set; }
        [Display(Name = "City")]
        public string cont_city { get; set; }
        [Display(Name = "State")]
        public string cont_state { get; set; }
        [Display(Name = "Country")]
        public string cont_country { get; set; }

        [Display(Name = "Postal Code")]
        public string cont_postal_code { get; set; }
    }
}
