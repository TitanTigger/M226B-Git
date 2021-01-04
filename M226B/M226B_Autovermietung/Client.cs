using M226B_Autovermietung.Test;
using System.Collections.Generic;

namespace ch.gibz.m226b.autovermietung
{
    public class Client : IGetData
    {

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public Insurance Insurance { get; set; }
        public Client_advisor ClientAdvisor { get; set; }
        public List<Rental> RentalHistory { get; set; } = new List<Rental>();
        public Rental CurrentRental { get; set; }
        public string Id { get; set; }
        public string DisplayText { get; set; }

        public Client(string Firstname, string Lastname, Insurance Insurance, string displayname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Insurance = Insurance;
            this.DisplayText = displayname;
        }
    }
}