using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketApi.Models
{
    /*Id, creation date and time, and phone number, (governorate, city, district) are drop-down lists 
    making them static no need for a database only the ticket entity*/
    public class Ticket
    {
        public int TicketID { get; set; }
        public DateTime CreationDate { get; set; }
        public string Phone { get; set; }
        public string Governorate { get; set; } //to be changed to foreign key reference the Governorate table when added to database
        public string City { get; set; } //to be changed to foreign key reference the City table when added to database
        public string District { get; set; } //to be changed to foreign key reference the District table when added to database
    }
}
