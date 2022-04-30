using NUnit.Framework;
using clases;

namespace Test.Library
{


    public class ExampleTest
    {

        [Test]
        public void dañoArco()
        {
            Arco arco = new Arco();
            int dañoArco = arco.GetDaño();
            int expected = 100;
            Assert.AreEqual(expected, dañoArco);
        }

    }


}