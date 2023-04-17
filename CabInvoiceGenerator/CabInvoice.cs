using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class CabInvoice
    {
        private static readonly double COST_PER_KM = 10.0;
        private static readonly double COST_PER_MINUTE = 1.0;
        private static readonly double MINIMUM_FARE = 5.0;
        private double cabFare = 0;
        public double CalculateFare(double distance, double time)
        {
            this.cabFare = (distance * COST_PER_KM) + (time * COST_PER_MINUTE);
            return Math.Max(this.cabFare, MINIMUM_FARE);
        }
        public double GetMultiplerRides(Ride[] rides)
        {
            double totalRideFare = 0.0;
            foreach (var ride in rides)
            {
                totalRideFare += this.CalculateFare(ride.rideDistance, ride.rideTime);
            }
            InvoiceSummary invoiceSummary = new InvoiceSummary(totalRideFare, rides.Length);
            return invoiceSummary.ReturnAvg();
        }
    }
}
