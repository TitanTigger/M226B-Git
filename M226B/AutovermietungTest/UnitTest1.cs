using M226B_Autovermietung_v2._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace AutovermietungTest
{
    [TestClass]
    public class UnitTest1
    {
        //1. Kann nicht auf die Methoden im Programm cs zugreifen aich mit instanz etc.
        //2. Weiss nicht wie methoden die void sind zu testen.
        //3. Hab enicht viele Methoden zum testen / die sinn machen zum testen.
        [TestMethod]
        public void Mechanic_IsNotNull()
        {
            string filename = @"daten.json";

            string JSONstrings = File.ReadAllText(filename);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            Business business = JsonConvert.DeserializeObject<Business>(JSONstrings, settings);

            //Assert.ThrowsException(Mechanic.CheckUp(business.Mechanics[0], business.Rentals[0]));
        }
    }
}
