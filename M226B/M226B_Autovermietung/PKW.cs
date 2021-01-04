using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class PKW : Vehicle
    {
        public string Weight { get; set; }

        public PKW(string Serialnumber, string Brand, string Model, string Price, string Weight)
            :base(Serialnumber, Brand, Model, Price)
        {
            this.Weight = Weight;
            
        }
    }
}
