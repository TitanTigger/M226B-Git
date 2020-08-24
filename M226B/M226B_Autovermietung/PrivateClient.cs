using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class PrivateClient : Client
    {
        public string Adress { get; set; }
        public PrivateClient(string Firstname, string Lastname, Gender Gender, Insurance Insurance, Client_advisor ClientAdvisor, List<Rental> RentalHistory, Rental CurrentRental, string Adress)
            : base(Firstname, Lastname, Gender, Insurance, ClientAdvisor, RentalHistory, CurrentRental)
        {
            this.Adress = Adress;
        }
    }
}
