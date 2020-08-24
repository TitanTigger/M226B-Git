using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    public class Rental
    {
        public string Place { get; set; }
        public Client Client { get; set; }
        public Vehicle Vehicle { get; set; }
        public string Numberplate { get; set; }
        public string Price { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Client_advisor ClientAdvisor { get; set; }
    }
}
