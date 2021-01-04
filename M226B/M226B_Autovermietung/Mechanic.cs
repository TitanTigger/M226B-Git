using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class Mechanic : Staff
    {
        public List<Vehicle> assignedVehicle { get; set; }
        public Mechanic(string Lastname, string StaffId, List<Vehicle> assignedVehicle)
            : base(Lastname, StaffId)
        {
            this.assignedVehicle = assignedVehicle;
        }
    }
}
