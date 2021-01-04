using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    public class Client_advisor : Staff
    {
        public List<Client> Clients { get; set; }
        public Client_advisor(string Lastname, string StaffId, List<Client> Clients)
            : base(Lastname, StaffId)
        {
            this.Clients = Clients;
        }
    }
}
