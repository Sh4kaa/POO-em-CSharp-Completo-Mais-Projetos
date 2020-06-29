﻿using aluguelcarro.Entities;
using System;

namespace aluguelcarro.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            double basicPayment = 0.0;
            if(duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // preço por hora arredondado pra cima vezes a duração em horas
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays); // preço em dias arredondado pra cima
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
