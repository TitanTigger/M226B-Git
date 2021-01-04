using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class LKW : Vehicle
    {
        public string Weight { get; set; }
        public string Height { set; get; }

        public LKW(string Serialnumber, string Brand, string Model, string Price,  string Weight, string Height)
           : base(Serialnumber, Brand, Model, Price)
        {
            this.Weight = Weight;
            this.Height = Height;
        }
    }
}
