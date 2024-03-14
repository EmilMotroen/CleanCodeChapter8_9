using Chapter9;

namespace TestSerialDate
{
    [TestClass]
    public class TestSerialDate
    {
        [TestMethod]
        public void TestAddMonths()
        {
            SerialDate d1 = SerialDate.CreateInstance(31, 5, 2004);
            SerialDate d2 = SerialDate.AddMonths(1, d1);

            Assert.AreEqual(30, d2.GetDayOfMonth());
            Assert.AreEqual(6, d2.GetMonth());
            Assert.AreEqual(2004, d2.GetYYYY());
        }
    }
}