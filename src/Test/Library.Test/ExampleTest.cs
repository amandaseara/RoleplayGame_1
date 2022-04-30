using NUnit.Framework;
using Roleplay;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dañoHacha()
        {
            Hacha hacha = new Hacha();
            int dañoHacha = hacha.GetDaño();
            int expected = 100;
            Assert.AreEqual(expected, dañoHacha);
        }

    }


}