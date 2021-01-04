using M226B_Autovermietung;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ch.gibz.m226b.autovermietung
{
    class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Users\maxbr\OneDrive\Desktop\M226B\Theorie\01_Datenspeicherung\Programm Daten.txt";

            WriteData(Path);
        }

        public static Repository CreateData()
        {
            Insurance insurance1 = new Insurance("Safe AG");
            List<Client> clients = new List<Client>();
            clients.Add(new Client("Max", "Braten", insurance1, "Max Braten"));
            clients.Add(new Client("Cedric", "Weiss", insurance1, "Cedric Weiss"));

            List<Vehicle> fahrzeug = new List<Vehicle>();
            fahrzeug.Add(new Vehicle("923148723", "BMW", "i3", "100'000CHF"));
            fahrzeug.Add(new Vehicle("236677823", "Audi", "r69", "60'000CHF"));
            fahrzeug.Add(new Vehicle("324534234", "Ferrari", "La Ferrari", "6'000'000CHF"));

            List<Mechanic> mechanics = new List<Mechanic>();
            mechanics.Add(new Mechanic("Hugentobler", "MC5678", fahrzeug));

            Repository repo = new Repository()
            {
                clients = clients,
                mechanic = mechanics,
                vehicle = fahrzeug,
            };

            SerializeJson(repo);
            DeSerializeJson(repo);

            return repo;
        }

        public static void WriteData(string Path)
        {
            CreateData();

            using (StreamWriter sw = new StreamWriter(Path))
            {
                sw.WriteLine("Daten vom programm Autovermietung");
                sw.WriteLine("----------------------------------");

                sw.WriteLine("Client");
                foreach (var client in CreateData().clients)
                {
                    sw.WriteLine($"Name: {client.Firstname} {client.Lastname}");
                    sw.WriteLine("Insurance: " + client.Insurance.Name);
                    sw.WriteLine();
                }

                foreach (var mechanic in CreateData().mechanic)
                {
                    sw.WriteLine("Mechanic");
                    sw.WriteLine("Name: " + mechanic.Firstname + mechanic.Lastname);
                }
           
                foreach (var vehicle in CreateData().vehicle)
                {
                    sw.WriteLine($"Assigned Vehicle: {vehicle.Brand} {vehicle.Model} | {vehicle.Price}");
                }
            }
        }

        

        public static void SerializeJson(Repository repo)
        {
            try
            {

            }
            catch (Exception)
            {
          
                throw;
            }
            finally
            {

            }
            string JsonString = JsonConvert.SerializeObject(repo);
            File.WriteAllText("daten.json", JsonString);
        }
        public static void DeSerializeJson(Repository repo)
        {
            string JsonContent = File.ReadAllText("daten.json");
            Repository deser = JsonConvert.DeserializeObject<Repository>(JsonContent);
        }
    }
}
