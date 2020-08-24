using System;
using System.Collections.Generic;
using System.Text;

namespace ch.gibz.m226b.autovermietung
{
    class Business
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Vehicle> Vehicle { get; set; }

    }
}
