using ContactWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContactWebApplication.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactEntity _context = new ContactEntity();

        [HttpGet]
        public ActionResult ContactList()
        {
            var listofData = _context.contact_mst_table.ToList().OrderByDescending(x=>x.cont_id); 

            return View(listofData); 
        } 

        // GET: Contact/Create
        [HttpGet]
        public ActionResult CreateContact()
        { 
            return View();
        }

        // POST: Contact/Create
        [HttpPost]
        public ActionResult CreateContact(contact_mst_table model)
        {
            try
            {
                contact_mst_table table = new contact_mst_table();
                table.cont_first_name = model.cont_first_name;
                table.cont_last_name = model.cont_last_name;
                table.cont_email = model.cont_email;
                table.cont_city = model.cont_city;
                table.cont_address = model.cont_address;
                table.cont_state = model.cont_state;
                table.cont_country = model.cont_country;
                table.cont_postal_code = model.cont_postal_code;
                table.cont_phone_number = model.cont_phone_number;
                _context.contact_mst_table.Add(table);
                _context.SaveChanges(); 
                return RedirectToAction("ContactList");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET: Contact/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.contact_mst_table.Where(x => x.cont_id == id).FirstOrDefault();
            
            return View(data);
        }

        // POST: Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(contact_mst_table model)
        {
            try
            {
                var data = _context.contact_mst_table.Where(x => x.cont_id == model.cont_id).FirstOrDefault();
                if (data != null)
                { 
                    data.cont_first_name = model.cont_first_name;
                    data.cont_last_name = model.cont_last_name;
                    data.cont_email = model.cont_email;
                    data.cont_city = model.cont_city;
                    data.cont_address = model.cont_address;
                    data.cont_state = model.cont_state;
                    data.cont_country = model.cont_country;
                    data.cont_postal_code = model.cont_postal_code;
                    data.cont_phone_number = model.cont_phone_number;
                    _context.SaveChanges();
                }


                return RedirectToAction("ContactList");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
         
    }
}
