using System.Collections.Generic;

namespace ch.gibz.m226b.autovermietung
{
    public class Client
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }
        public Insurance Insurance { get; set; }
        public Client_advisor ClientAdvisor { get; set; }
        public List<Rental> RentalHistory { get; set; }
        public Rental CurrentRental { get; set; }

        public Client(string Firstname, string Lastname, Gender Gender, Insurance Insurance, Client_advisor ClientAdvisor, List<Rental> RentalHistory, Rental CurrentRental)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Gender = Gender;
            this.Insurance = Insurance;
            this.ClientAdvisor = ClientAdvisor;
            this.RentalHistory = RentalHistory;
            this.CurrentRental = CurrentRental;
        }
    }
}