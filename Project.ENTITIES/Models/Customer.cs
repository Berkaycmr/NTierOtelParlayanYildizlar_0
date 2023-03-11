using System;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tc { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //Relational Properties

        public List<Booking> Bookings { get; set; }
    }
}
