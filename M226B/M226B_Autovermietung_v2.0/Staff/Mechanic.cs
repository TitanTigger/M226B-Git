using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
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
