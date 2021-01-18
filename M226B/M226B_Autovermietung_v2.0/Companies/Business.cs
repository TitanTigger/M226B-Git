using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Business : IIdentifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<Mechanic> Mechanics { get; set; }
        public List<ClientAdvisor> ClientAdvisors { get; set; }
        public List<Rental> Rentals { get; set; }
        public Dictionary<string, Client> Clients { get; set; }
        public List<Vehicle> Vehicles { get; set; }      
    }
}
