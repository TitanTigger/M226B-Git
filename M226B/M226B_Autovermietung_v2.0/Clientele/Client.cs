using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;

namespace M226B_Autovermietung_v2._0
{
    public class Client : IIdentifier
    {
        public string id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public ClientAdvisor ClientAdvisor { get; set; }
        public List<Rental> RentalHistory { get; set; } = new List<Rental>();
        public Rental CurrentRental { get; set; }
        //Text to be shown for Drop boxes etc.
        public string DisplayText { get; set; }

        public Client(string Firstname, string Lastname, string displayname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.DisplayText = displayname;
        }
    }
}