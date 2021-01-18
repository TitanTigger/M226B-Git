using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Mechanic : Staff
    {
        public List<Vehicle> assignedVehicle { get; set; }
        public bool busy { get; set; }
        public Mechanic(string Firstname, string Lastname, Guid StaffId, List<Vehicle> assignedVehicle)
            : base(Firstname, Lastname, StaffId)
        {
            this.assignedVehicle = assignedVehicle;
        }

        
        public static void CheckUp(Mechanic mechanic, Rental rental)
        {
            int count = 0;
            //Assign vehicle to two mechanics 
            if (mechanic.busy != true && count == 2)
            {
                count++;
                mechanic.assignedVehicle.Add(rental.Vehicle);
                if (rental.Vehicle.damaged != true)
                {
                    rental.Vehicle.NeedCheckup = false;
                    mechanic.busy = false;
                }
            }
        }
    }
}
