using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ch.gibz.m226b.autovermietung;

namespace M226B_Autovermietung
{
    class Repository
    {
        public Business business = new Business();

        public List<Client> clients = new List<Client>();

        public List<Mechanic> mechanic = new List<Mechanic>();

        public List<Vehicle> vehicle = new List<Vehicle>();

    }


}
