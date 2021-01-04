using M226B_Autovermietung_v2._0;
using System;
using System.Collections.Generic;
using System.Text;

namespace M226B_Autovermietung_v2._0
{
    class Vehicle : IIdentifier
    {
        public string id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }
        public bool NeedService { get; set; }
        public bool Rented { get; set; }

        public Vehicle(string id, string Brand, string Model, string Price)
        {
            this.id = id;
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
        }
    }
}
