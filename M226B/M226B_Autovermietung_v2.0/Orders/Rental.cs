using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Rental
    {
        public Client Client { get; set; }
        //public Vehicle Vehicle { get; set; }
        public string Numberplate { get; set; }
        public string Price { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
