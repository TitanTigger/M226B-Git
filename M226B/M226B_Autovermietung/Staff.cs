using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    public class Staff
    {
        public string StaffId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }

        public Staff(string Firstname, string Lastname, Gender Gender, string StaffId)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Gender = Gender;
            this.StaffId = StaffId;
        }
    }
}
