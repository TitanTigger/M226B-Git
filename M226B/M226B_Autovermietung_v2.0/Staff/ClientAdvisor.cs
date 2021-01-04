using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class ClientAdvisor : Staff
    {
        public List<Client> Clients { get; set; }
        public ClientAdvisor(string Lastname, string StaffId, List<Client> Clients)
            : base(Lastname, StaffId)
        {
            this.Clients = Clients;
        }
    }
}
