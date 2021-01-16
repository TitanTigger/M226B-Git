using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;

namespace M226B_Autovermietung_v2._0
{
    class moq
    {
        public static void moqData()
        {
            string jsonString = "";

            //Create new Business which contains everything
            Business business = new Business();

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add( new Vehicle("BMW", "i4", "1200CHF", VehicleClass.PKW));
            vehicles.Add( new Vehicle("AUDI", "R8", "1500CHF", VehicleClass.PKW));
            vehicles.Add( new Vehicle("FORD", "Focus", "1900CHF", VehicleClass.PKW));
            vehicles.Add(new Vehicle("Porsche", "911", "2400CHF", VehicleClass.PKW));
            vehicles.Add(new Vehicle("Ferrari", "488 Spider", "2900CHF", VehicleClass.PKW));
            vehicles.Add(new Vehicle("Honda", "Civic", "900CHF", VehicleClass.PKW));

            vehicles.Add(new Vehicle("Volvo", "BigBoy", "1800CHF", VehicleClass.LKW));
            vehicles.Add(new Vehicle("LEON", "LongBoy", "900CHF", VehicleClass.LKW));
            vehicles.Add(new Vehicle("Sear", "SmolBoy", "900CHF", VehicleClass.LKW));


            Dictionary<string, Client> clients = new Dictionary<string, Client>();
            clients.Add("maxBraten", new Client("Max","Braten"));

            //Create new Staff Memebers
            List<Mechanic> mechanics = new List<Mechanic>();

            mechanics.Add(new Mechanic("Bob", "Baumann", Guid.NewGuid(), vehicles));

            List<ClientAdvisor> advisors = new List<ClientAdvisor>();

            advisors.Add(new ClientAdvisor("Hans", "Blumental", Guid.NewGuid(),  clients));;
            advisors.Add(new ClientAdvisor("Mirko", "Jürgental", Guid.NewGuid(), clients));
            advisors.Add(new ClientAdvisor("Eren", "Yaeger", Guid.NewGuid(), clients));
            advisors.Add(new ClientAdvisor("Levin", "Ackermann", Guid.NewGuid(), clients));

            List<Rental> rentals = new List<Rental>();

            rentals.Add(new Rental(clients["maxBraten"], vehicles[0], advisors[0],"19000CHF" ,DateTime.Now, DateTime.Now.AddDays(7)));

            business.Vehicles = vehicles;
            business.Clients = clients;
            business.ClientAdvisors = advisors;
            business.Mechanics = mechanics;
            business.Rentals = rentals;
            business.Names = "Buy any Car dot com";

            jsonString += JsonConvert.SerializeObject(business, Formatting.Indented);

            File.WriteAllText("daten.json", jsonString);
        }
    }
}
