using ProblemTwo.Models;

namespace CalculateFeesTesting
{
    public class Tests
    {
        private CalculateFees _mnc { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _mnc = new CalculateFees();
        }

        [Test]
        public void TestWeightBelow2MileBelow500()
        {
            double expectedFee = 1.10;
            double actualFee = _mnc.getCalculateFees(1.5, 300);

            Assert.AreEqual(expectedFee, actualFee, 0.01);
        }

        [Test]
        public void TestWeightBelow6Mile500to1000()
        {
            double expectedFee = 4.40;
            double actualFee = _mnc.getCalculateFees(4, 750);

            Assert.AreEqual(expectedFee, actualFee, 0.01);
        }

        [Test]
        public void TestWeightBelow10MileAbove1000()
        {
            double expectedFee = 18.5;
            double actualFee = _mnc.getCalculateFees(8, 2200);

            Assert.AreEqual(expectedFee, actualFee, 0.01);
        }

        [Test]
        public void TestWeightAbove10MileAbove1000()
        {
            double expectedFee = 24;
            double actualFee = _mnc.getCalculateFees(12, 2200);

            Assert.AreEqual(expectedFee, actualFee, 0.01);
        }
    }
}