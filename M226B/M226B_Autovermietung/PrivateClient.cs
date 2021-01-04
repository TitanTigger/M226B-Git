using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class PrivateClient : Client
    {
        public string Address { get; set; }
        public PrivateClient(string Firstname, string Lastname, Gender Gender, Insurance Insurance, Client_advisor ClientAdvisor, List<Rental> RentalHistory, Rental CurrentRental, string Address, string DisplayName)
            : base(Firstname, Lastname, Insurance, DisplayName)
        {
            this.Address = Address;
        }
    }
}
