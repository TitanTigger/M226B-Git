using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;

namespace M226B_Autovermietung_v2._0
{
    public class Client : IIdentifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Client(string Firstname, string Lastname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;          
        }
    }
}