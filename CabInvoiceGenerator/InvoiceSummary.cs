using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        public double totalFare;
        public double averageFair;
        public int noOfRides;
        public InvoiceSummary(double totalFare, int noOfRides)
        {
            this.totalFare = totalFare;
            this.noOfRides = noOfRides;
            this.averageFair = totalFare / noOfRides;
        }
        public double ReturnAvg()
        {
            return this.averageFair;
        }
    }
}
