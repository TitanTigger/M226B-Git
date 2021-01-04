using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class BuissnesClient : Client
    {
        public string Firma { get; set; }

        public BuissnesClient(string Firstname, string Lastname, Insurance Insurance, Rental CurrentRental, string Firma, string displayname)
            : base(Firstname, Lastname, Insurance, displayname)
        {
            this.Firma = Firma;
        }
    }
}
