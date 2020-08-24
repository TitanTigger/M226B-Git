using System.Collections.Generic;

namespace ch.gibz.m226b.autovermietung
{
    public class Customer
    {
        public string CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public Rental CurrentRental { get; set; }
        public List<Rental> AllRentals { get; set; }


    }
}