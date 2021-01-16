using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Rental : IIdentifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Client Client { get; set; }
        public Vehicle Vehicle { get; set; }
        public ClientAdvisor Advisor { get; set; }
        public string price { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public Rental(Client Client, Vehicle Vehicle, ClientAdvisor Advisor, string totalprice, DateTime RentalDate, DateTime ReturnDate)
        {
            this.price = totalprice;
            this.Client = Client;
            this.Vehicle = Vehicle;
            this.Advisor = Advisor;
            this.RentalDate = RentalDate;
            this.ReturnDate = ReturnDate;
        }
    }
}
