using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting.Fundamentals;
using UnitTestProject1_UnitTests;

namespace UnitTestProject1_UnitTests
{
    [TestClass]
    public class ReservationTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var reservation = new Reservation();

            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            Assert.IsTrue(result);

        }
    }
    [TestClass()]
    public class CalculatorTests
    {

        Calculator Calculator = new Calculator();

        [TestMethod()]
        public void AddTest()
        {
            double a = 3f;
            double b = 2f;
            double expectedC = 5f;
            double actualC = Calculator.Add(a, b);
            Assert.AreEqual(expectedC, actualC);
        }
    }
}

