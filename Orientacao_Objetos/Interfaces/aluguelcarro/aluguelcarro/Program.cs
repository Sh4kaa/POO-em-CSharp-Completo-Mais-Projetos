﻿using aluguelcarro.Entities;
using System;
using System.Globalization;
using aluguelcarro.Services;


namespace aluguelcarro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            //start
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.Parse(Console.ReadLine());
            //return
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
