using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    public class Vehicle
    {
        public string Serialnumber { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Price { get; set; }
        public string KmAmount { get; set; }

        public Vehicle(string Serialnumber, string Name, string Brand, string Model, DateTime ManufactureDate, string Price, string KmAmount)
        {
            this.Serialnumber = Serialnumber;
            this.Name = Name;
            this.Brand = Brand;
            this.Model = Model;
            this.ManufactureDate = ManufactureDate;
            this.Price = Price;
            this.KmAmount = KmAmount;
        }
    }
}
