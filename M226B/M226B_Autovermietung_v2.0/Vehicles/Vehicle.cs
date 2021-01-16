using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    public class Vehicle : IIdentifier
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public bool NeedCheckup { get; set; }
        public bool damaged { get; set; }
        public bool Rented { get; set; }
        public VehicleClass VehicleClass { get; set; }

        public Vehicle(string Brand, string Model, string Price, VehicleClass VehicleClass)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
            this.VehicleClass = VehicleClass;
        }
    }
}
