﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class Mechanic : Staff
    {
        public List<Vehicle> assignedVehicle { get; set; }
        public Mechanic(string Firstname, string Lastname, Gender Gender, string StaffId, List<Vehicle> assignedVehicle)
            : base(Firstname, Lastname, Gender, StaffId)
        {
            this.assignedVehicle = assignedVehicle;
        }
    }
}
