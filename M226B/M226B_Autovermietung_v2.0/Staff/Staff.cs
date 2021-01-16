using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public abstract class Staff
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool isBusy { get; set; }

        public Staff(string Firstname, string Lastname, Guid StaffId)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Id = StaffId;

        }
    }
}
