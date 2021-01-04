using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    public class Vehicle
    {
        public string Serialnumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Price { get; set; }
        public string KmAmount { get; set; }

        public Vehicle(string Serialnumber, string Brand, string Model, string Price)
        {
            this.Serialnumber = Serialnumber;
            this.Brand = Brand;
            this.Model = Model;
            this.Price = Price;
        }
    }
}
