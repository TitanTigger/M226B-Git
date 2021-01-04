using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public abstract class Staff : IIdentifier
    {
        public string id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }

        public Staff(string Lastname, string StaffId)
        {
            this.Lastname = Lastname;
            this.id = StaffId;
        }
    }
}
