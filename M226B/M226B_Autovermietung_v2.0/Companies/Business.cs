using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Business : IIdentifier
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Staff> Staff { get; set; }
       // public List<Vehicle> Vehicle { get; set; }

    }
}
