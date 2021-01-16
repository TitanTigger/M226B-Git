using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class ClientAdvisor : Staff
    {
        public Dictionary<string, Client> Clients { get; set; }
        public ClientAdvisor(string Firstname, string Lastname, Guid StaffId, Dictionary<string, Client> Clients)
            : base(Firstname, Lastname, StaffId)
        {
            this.Clients = Clients;
        }
    }
}
