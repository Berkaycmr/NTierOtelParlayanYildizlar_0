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

        public override string ToString()
        {
            return $"Adı : {FirstName} Soyadı : {LastName} Telefonu : {PhoneNumber}";
        }

        //Relational Properties

        public virtual List<Booking> Bookings { get; set; }
    }
}
