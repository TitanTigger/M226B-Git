using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class LKW : Vehicle
    {
        public string Weight { get; set; }
        public string Height { set; get; }

        public LKW(string Serialnumber, string Name, string Brand, string Model, DateTime ManufactureDate, string Price, string KmAmount, string Weight, string Height)
           : base(Serialnumber, Name, Brand, Model, ManufactureDate, Price, KmAmount)
        {
            this.Weight = Weight;
            this.Height = Height;

        }
    }
}
