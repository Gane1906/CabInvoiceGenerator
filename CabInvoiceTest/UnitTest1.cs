using CabInvoiceGenerator;

namespace CabInvoiceTest
{
    public class Tests
    {
        private CabInvoice cabInvoice;
        [SetUp]
        public void Setup()
        {
            this.cabInvoice = new CabInvoice();
        }

        [Test]
        public void GivenDistanceTime_WhenAnalyze_ShouldRetrunFare()
        {
            double totalFare = this.cabInvoice.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }

        [Test]
        public void GivenDistanceAndTimeForMultipleRides_WhenProper_ShouldReturnAverageFAir()
        {
            Ride[] ride = { new Ride(3.0, 5.0), new Ride(2.0, 5.0) };
            double avg= this.cabInvoice.GetMultiplerRides(ride);
            Assert.AreEqual(30.0, avg);
        }
    }
}