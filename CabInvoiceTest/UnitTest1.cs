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
    }
}