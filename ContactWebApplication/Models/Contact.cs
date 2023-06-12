using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContactWebApplication.Models
{
    [Table("contact_mst_table")]
    public class Contact
    {
        [Column("cont_id")]
        public int ContactId { get; set; }
        [Column("cont_first_name")]
        public string FirstName { get; set; }
        [Column("cont_last_name")]
        public string LastName { get; set; }
        [Column("cont_email")]
        public string Email { get; set; }
        [Column("cont_phone_number")]
        public string PhoneNumber { get; set; }
        [Column("cont_address")]
        public string Address { get; set; }
        [Column("cont_city")]
        public string City { get; set; }
        [Column("cont_state")]
        public string State { get; set; }
        [Column("cont_country")]
        public string Country { get; set; }
        [Column("cont_postal_code")]
        public string PostalCode { get; set; }
    }
}