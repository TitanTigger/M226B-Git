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
            //Create new Vehicles
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add( new Vehicle("987321649817632", "BMW", "i4", "1200CHF"));
            vehicles.Add( new Vehicle("988321649817632", "AUDI", "R8", "1500CHF"));
            vehicles.Add( new Vehicle("977321649817632", "FORD", "Focus", "1900CHF"));

            List<Client> clients = new List<Client>();
            //Create new Staff
            List<Mechanic> mechanics = new List<Mechanic>();

            mechanics.Add(new Mechanic("Juergental", "921834769821376", vehicles));


            List<ClientAdvisor> advisors = new List<ClientAdvisor>();

            advisors.Add(new ClientAdvisor("hansibluemtal", "91826438132987", clients));
            advisors.Add(new ClientAdvisor("jürgi", "9879809870987098", clients));

            string jsonString0 = JsonConvert.SerializeObject(mechanics, Formatting.Indented);
            jsonString0 += JsonConvert.SerializeObject(advisors, Formatting.Indented);
            jsonString0 += JsonConvert.SerializeObject(vehicles, Formatting.Indented);


            File.WriteAllText("daten.json", jsonString0);

        }
    }
}
