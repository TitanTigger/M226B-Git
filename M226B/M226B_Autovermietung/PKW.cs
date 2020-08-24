using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class PKW : Vehicle
    {
        public string Weight { get; set; }

        public PKW(string Serialnumber, string Name, string Brand, string Model, DateTime ManufactureDate, string Price, string KmAmount, string Weight)
            :base(Serialnumber, Name, Brand, Model, ManufactureDate, Price, KmAmount)
        {
            this.Weight = Weight;
            
        }
    }
}
