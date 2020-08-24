using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class BuissnesClient : Client
    {
        public string Firma { get; set; }
        public BuissnesClient(string Firstname, string Lastname, Gender Gender, Insurance Insurance, Client_advisor ClientAdvisor, List<Rental> RentalHistory, Rental CurrentRental, string Firma)
            : base(Firstname, Lastname, Gender, Insurance, ClientAdvisor, RentalHistory, CurrentRental)
        {
            this.Firma = Firma;
        }
    }
}
