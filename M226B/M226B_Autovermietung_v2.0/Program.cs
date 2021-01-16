using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Serialization;
using Newtonsoft.Json;
using static System.Net.Mime.MediaTypeNames;

namespace M226B_Autovermietung_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check if Json file is empty
            string moqData = File.ReadAllText("daten.json");
            if (moqData == "")
            {
                //create example data
                moq.moqData();
            }
            //Read content of Json file
            Business business = ReadJson();

            /*ENTER AUTOHAUS */
            Rental completedRental;
            ClientAdvisor selectedAdvisor;
            Client currentClient;
            Vehicle selectedVehicle;
            bool choosing = true;

            Console.WriteLine("1: Id like to rent a vehicle");
            Console.WriteLine("2: Id like to return an already rented a vehicle");
            Console.WriteLine("3: Id like to view my order history");

            while (choosing == true)
            {
                switch (Console.ReadLine())
                {
                    //RENT
                    case "1":
                        Console.WriteLine("To Rent a Vehicle Please fill out this Form");

                        Console.WriteLine("Firstname: ");
                        string firstname = Console.ReadLine();

                        Console.WriteLine("Lastname: ");
                        string lastname = Console.ReadLine();

                        Console.WriteLine("Username: ");
                        string username = Console.ReadLine();

                        Thread.Sleep(2000);
                        Console.Clear();
                        if (business.Clients.ContainsKey(username))
                        {
                            currentClient = business.Clients[username];
                            Console.WriteLine($"Welcome Back {username}");
                        }
                        else
                        {
                            business.Clients.Add(username, new Client(firstname, lastname));
                            currentClient = business.Clients[username];
                            Console.WriteLine($"This is your first time {username}");
                        }

                        Console.WriteLine("Now you can choose an advisor who will help you pick your vehicle");

                        int advisorNum = 0;
                        foreach (var advisor in business.ClientAdvisors)
                        {
                            advisorNum++;
                            Console.WriteLine($"{advisorNum} = {advisor.Firstname} {advisor.Lastname}");
                        }
                        Console.WriteLine("Please enter the number of the Advisor as displayed above");

                        selectedAdvisor = null;
                        while (selectedAdvisor == null)
                        {
                            try
                            {
                                string advisorInput = Console.ReadLine();
                                //Convert user input into integer value
                                int advisorKey = Convert.ToInt32(advisorInput);
                                //Select from array (-1 since 1 = 0 in array)
                                selectedAdvisor = business.ClientAdvisors[advisorKey - 1];
                                selectedAdvisor.isBusy = true;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Please choose a valid option...");
                            }
                        }


                        Console.WriteLine("You Selected");
                        Console.WriteLine(selectedAdvisor.Lastname);

                        Thread.Sleep(2000);
                        Console.Clear();

                        Console.WriteLine($"{selectedAdvisor.Lastname} will help you choose a vehicle now");
                        Console.WriteLine($"Please select a vehicle Class type LKW or PKW correctly");

                        choosing = true;
                        while (choosing == true)
                        {
                            switch (Console.ReadLine().ToUpper())
                            {
                                case "LKW":
                                    int vehicleNum = 0;
                                    foreach (var vehicle in business.Vehicles)
                                    {
                                        vehicleNum++;
                                        if (vehicle.Rented != true && vehicle.VehicleClass == VehicleClass.LKW && vehicle.damaged == false)
                                        {
                                            Console.WriteLine($"{vehicleNum} = {vehicle.Brand} {vehicle.Model} - {vehicle.Price} CHF");
                                        }
                                    }
                                    choosing = false;
                                    break;

                                case "PKW":
                                    int vehicleNumPKW = 0;
                                    foreach (var vehicle in business.Vehicles)
                                    {
                                        vehicleNumPKW++;
                                        if (vehicle.Rented != true && vehicle.VehicleClass == VehicleClass.PKW && vehicle.damaged == false)
                                        {
                                            Console.WriteLine($"{vehicleNumPKW} = {vehicle.Brand} {vehicle.Model} - {vehicle.Price} CHF");
                                        }
                                    }
                                    choosing = false;
                                    break;

                                default:
                                    Console.WriteLine("Please Type a valid Vehicle class");
                                    break;
                            }
                        }

                        selectedVehicle = null;
                        while (selectedVehicle == null)
                        {
                            try
                            {
                                string vehicleInput = Console.ReadLine();
                                //Convert user input into integer value
                                int vehicleKey = Convert.ToInt32(vehicleInput);
                                //Select from array (-1 since 1 = 0 in array)
                                selectedVehicle = business.Vehicles[vehicleKey - 1];
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                Console.WriteLine("Please enter a valid number");
                            }

                        }



                        Console.WriteLine("You Selected");
                        Console.WriteLine($"{selectedVehicle.Brand} {selectedVehicle.Model} for a daily Price of {selectedVehicle.Price}");

                        Thread.Sleep(2000);
                        Console.Clear();

                        DateTime startDate = DateTime.MinValue;
                        DateTime returnDate = DateTime.MinValue;
                        Console.WriteLine("Now Please enter the date you would like to rent this Vehicle for");
                        Console.WriteLine("You can enter NOW if youd like to rent it for today");
                        choosing = true;
                        while (choosing == true)
                        {
                            try
                            {
                                string startDateInput = Console.ReadLine();
                                if (startDateInput.ToUpper() == "NOW")
                                {
                                    startDate = DateTime.Now;
                                    choosing = false;
                                }
                                else
                                {
                                    startDate = Convert.ToDateTime(startDateInput).ToUniversalTime();
                                    choosing = false;
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("please enter a valid date try dd.mm.yyyy or any date format");
                            }
                        }

                        Console.WriteLine();

                        Console.WriteLine("Now please enter the number of days you would like to rent this vehicle");
                        string daysAmountInput = "";

                        while (daysAmountInput == "")
                        {
                            try
                            {
                                daysAmountInput = Console.ReadLine();
                                returnDate = startDate.AddDays(Convert.ToInt32(daysAmountInput));
                            }
                            catch (FormatException)
                            {
                                daysAmountInput = "";
                                Console.WriteLine("Please enter a correct amount of day example 7");
                            }
                        }

                        Console.WriteLine($"You are renting {selectedVehicle.Brand} {selectedVehicle.Model} for a daily Price of {selectedVehicle.Price} for {daysAmountInput} Days");

                        Thread.Sleep(2000);
                        Console.Clear();
                        string pricenumber = Regex.Match(selectedVehicle.Price, @"\d+").Value;
                        int totalPrice = Convert.ToInt32(pricenumber) * Convert.ToInt32(daysAmountInput);

                        Console.WriteLine("Heres your Invoice");
                        Console.WriteLine($"Order Completion Date {DateTime.Now}");
                        Console.WriteLine($"Client Credentials {firstname} {lastname} {username}");
                        Console.WriteLine($"Vehicle you ordered {selectedVehicle.Brand} {selectedVehicle.Model}");
                        Console.WriteLine($"Rental period: {startDate} until {returnDate}");
                        Console.WriteLine($"Payment Info: Total = {totalPrice} CHF");
                        Console.WriteLine($"Thanks for choosing {business.Names}");
                        Console.WriteLine($"");

                        Console.WriteLine($"please select which payment method youd like to use to pay the total of {totalPrice} CHF");
                        Console.WriteLine("1 = Credit Card");
                        Console.WriteLine("2 = Cash");
                        string paymentMethod = "unpayed";
                        choosing = true;
                        while (choosing == true)
                        {
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    paymentMethod = "Credit Card";
                                    Console.WriteLine($"You Succesfully payed {totalPrice} CHF");
                                    choosing = false;
                                    break;

                                case "2":
                                    paymentMethod = "Cash";
                                    Console.WriteLine("Please enter the amount of money you are paying");
                                    string amountPayed = Console.ReadLine();
                                    Console.WriteLine($"Payment succesful, heres your Change {Convert.ToInt32(amountPayed) - totalPrice} CHF");
                                    choosing = false;
                                    break;

                                default:
                                    Console.WriteLine("Enter a valid option please");
                                    break;
                            }
                        }

                        Thread.Sleep(2000);
                        Console.Clear();

                        selectedAdvisor.isBusy = false;
                        selectedVehicle.Rented = true;
                        completedRental = new Rental(currentClient, selectedVehicle, selectedAdvisor, $"{totalPrice}CHF", startDate, returnDate);
                        business.Rentals.Add(completedRental);
                        Console.WriteLine("Heres your Receipt");
                        Console.WriteLine($"Order Completion Date {DateTime.Now}");
                        Console.WriteLine($"Client Credentials {firstname} {lastname} {username}");
                        Console.WriteLine($"Vehicle you ordered {selectedVehicle.Brand} {selectedVehicle.Model}");
                        Console.WriteLine($"Rental period: {startDate} until {returnDate}");
                        Console.WriteLine($"Payment Info: Total = {totalPrice} CHF Payment Method: {paymentMethod}");
                        Console.WriteLine($"Thanks for choosing {business.Names}");
                        Console.WriteLine($"Heres your keys, Have a nice drive");

                        choosing = false;
                        break;

                    //RETURN
                    case "2":
                        Console.WriteLine("Please enter your username");
                        try
                        {
                            currentClient = business.Clients[Console.ReadLine()];
                        }
                        catch (KeyNotFoundException ex)
                        {
                            currentClient = null;
                            Console.WriteLine("Username does Not exist");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                        }

                        Thread.Sleep(2000);
                        Console.Clear();


                        Rental userActiveRental = null;
                        foreach (var rental in business.Rentals)
                        {
                            if (rental.Client.Id == currentClient.Id && rental.Vehicle.Rented == true)
                            {
                                userActiveRental = rental;
                            }
                        }

                        if (userActiveRental != null)
                        {
                            Console.WriteLine("Here are all your Active orders");
                            Console.WriteLine($"{userActiveRental.Vehicle.Id}");
                            Console.WriteLine($"{userActiveRental.Vehicle.Brand} {userActiveRental.Vehicle.Model}");
                            Console.WriteLine($"Rented on: {userActiveRental.RentalDate}");
                            Console.WriteLine($"To be returned by: {userActiveRental.ReturnDate}");
                            userActiveRental.Vehicle.Rented = false;
                            selectedVehicle = userActiveRental.Vehicle;
                            Console.WriteLine($"Vehicle has ben returned...");
                        }
                        else
                        {
                            Console.WriteLine("You have no active rentals");
                        }

                        // Rückgabe Check
                        if ((userActiveRental.RentalDate - userActiveRental.ReturnDate).TotalDays == 7)
                        {
                            Console.WriteLine("Please park youre vehicle at a service checkup spot");
                            userActiveRental.Vehicle.NeedCheckup = true;
                            foreach (var mechanic in business.Mechanics)
                            {
                                if (mechanic.busy != true)
                                {
                                    mechanic.assignedVehicle.Add(userActiveRental.Vehicle);
                                }
                            }
                        }

                        break;

                    case "3":
                        Console.WriteLine("Please enter your username");
                        try
                        {
                            currentClient = business.Clients[Console.ReadLine()];
                        }
                        catch (KeyNotFoundException ex)
                        {
                            currentClient = null;
                            Console.WriteLine("Username does Not exist");
                            Thread.Sleep(2000);
                            Environment.Exit(0);
                        }

                        Thread.Sleep(2000);
                        Console.Clear();

                        List<Rental> rentalHistory = new List<Rental>();
                        foreach (var rental in business.Rentals)
                        {
                            if (rental.Client.Id == currentClient.Id)
                            {
                                rentalHistory.Add(rental);
                            }
                        }
                        if (rentalHistory.Count > 0)
                        {
                            Console.WriteLine("RENTAL HISTORY");
                            foreach (var rental in rentalHistory)
                            {
                                Console.WriteLine($"RentalDate: {rental.RentalDate}");
                                Console.WriteLine($"Vehicle you ordered {rental.Vehicle.Brand} {rental.Vehicle.Model}");
                                Console.WriteLine($"Rental period: {rental.RentalDate} until {rental.ReturnDate}");
                                Console.WriteLine($"Payment Info: Total = {rental.price} CHF");
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("You have no Rentals...");
                        }
                        choosing = false;

                        break;

                    default:
                        Console.WriteLine("Please select a valid option");
                        break;

                }
                string businessJsonString = JsonConvert.SerializeObject(business, Formatting.Indented);
                File.WriteAllText("daten.json", businessJsonString);
            }
            
        }
        // Deserielize the Json File into business class
        static Business ReadJson()
        {
            string filename = @"daten.json";

            string JSONstrings = File.ReadAllText(filename);

            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            Business business = JsonConvert.DeserializeObject<Business>(JSONstrings, settings);

            return business;
        }
    }
}
