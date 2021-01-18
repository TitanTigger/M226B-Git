using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace M226B_Autovermietung_v2._0
{
    class Statistics
    {
        public void CalculateSales(Business business)
        {
            Console.WriteLine("Stats");
            int salesTotal = 0;

            int salesYearly = 0;
            int carSalesYearly = 0;

            int salesMonthly = 0;
            int carSalesMonthly = 0;

            int salesWeekly = 0;
            int carSalesWeekly = 0;

            int salesDaily = 0;
            int carSalesDaily = 0;

            foreach (var rental in business.Rentals)
            {
                string umsatzNumber = Regex.Match(rental.price, @"\d+").Value;
                salesTotal += Convert.ToInt32(umsatzNumber);

                //Sales this Year
                if (rental.RentalDate.Year == DateTime.Today.Year)
                {
                    salesYearly += Convert.ToInt32(umsatzNumber);
                    carSalesYearly++;
                }
                //Sales this Month
                if (rental.RentalDate.Month == DateTime.Today.Month && rental.RentalDate.Year == DateTime.Today.Year)
                {
                    salesMonthly += Convert.ToInt32(umsatzNumber);
                    carSalesMonthly++;
                }
                //Sales this Week
                Calendar cal = DateTimeFormatInfo.CurrentInfo.Calendar;
                DateTime d1 = rental.RentalDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(rental.RentalDate));
                DateTime d2 = DateTime.Today.Date.AddDays(-1 * (int)cal.GetDayOfWeek(DateTime.Today));
                if (d1 == d2)
                {
                    salesWeekly += Convert.ToInt32(umsatzNumber);
                    carSalesWeekly++;
                }
                //Sales Today
                if (rental.RentalDate.Date == DateTime.Now.Date)
                {
                    salesDaily += Convert.ToInt32(umsatzNumber);
                    carSalesDaily++;
                }

            }

            Console.WriteLine($"Cars sold TOTAL: {business.Rentals.Count}");
            Console.WriteLine($"Sales TOTAL: {salesTotal} CHF");
            Console.WriteLine("****************************************");
            Console.WriteLine($"Cars sold This year: {carSalesYearly}");
            Console.WriteLine($"Sales this year: {salesYearly} CHF");
            Console.WriteLine("****************************************");
            Console.WriteLine($"Cars sold This month: {carSalesMonthly}");
            Console.WriteLine($"Sales this month: {salesMonthly} CHF");
            Console.WriteLine("****************************************");
            Console.WriteLine($"Cars sold This Week: {carSalesWeekly}");
            Console.WriteLine($"Sales this Week: {salesWeekly} CHF");
            Console.WriteLine("****************************************");
            Console.WriteLine($"Cars sold today: {carSalesDaily}");
            Console.WriteLine($"Sales today: {salesDaily} CHF");
        }
    }
}
