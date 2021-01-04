using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace M226B_Autovermietung_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            moq.moqData();

            LoadJson();

            using (FileStream json = new FileStream("daten.json", FileMode.Open))
            {
                Console.WriteLine("Welcome to Car4U");

                Console.WriteLine("Please choose an advisor: ");

                Console.WriteLine("1: Max Lipp");
                Console.WriteLine("2: Josh Weiss");
                Console.WriteLine("3: Franziska Blumental");
                string test = Console.ReadLine();

                switch (test)
                {
                    case "1":
                        Console.WriteLine("Max Lipp kommt gleich");
                        break;

                    case "2":
                        Console.WriteLine("Josh Weiss kommt gleich");
                        break;

                    case "3":
                        Console.WriteLine("Franziska Blumental kommt gleich");
                        break;

                    default:
                        Console.WriteLine("De gits gar ned bruh");
                        break;
                }



            }

        }
        static void LoadJson()
        {
            using (StreamReader r = new StreamReader("daten.json"))
            {
              //  string json = r.ReadToEnd();
            //    List<Vehicle> items = JsonConvert.DeserializeObject<List<Vehicle>>(json);
                
            }
        }
    }
}
