using ClassLibraryNunit;

namespace TestNunit
{
    [TestFixture]
    public class Tests
    {
        Arithmetic arithmetic;
        [SetUp]

        public void Setup()
        {
            arithmetic = new Arithmetic();
        }

        [Test]
        public void AddTest()
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.Add(3, 5);
            int expected = 8;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void AddWithNUll()
        {
            Arithmetic arihmetic = new Arithmetic();
            Assert.Throws<ArgumentNullException>(() => arithmetic.Add(2, null));
        }
        [Test]
        public void SubTest()
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.substract(6, 5);
            int expected = 1;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void SubWithNull()
        {
            Arithmetic arihmetic = new Arithmetic();
            Assert.Throws<ArgumentNullException>(() => arithmetic.substract(2, null));
        }
        [Test]
        public void MultiplyTest()
        {
            Arithmetic arithmetic = new Arithmetic();
            int result = arithmetic.multiply(3, 5);
            int expected = 15;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void MultiplyWithNull()
        {
            Arithmetic arihmetic = new Arithmetic();
            Assert.Throws<ArgumentNullException>(() => arithmetic.multiply(2, null));
        }
        [Test]
        public void DivideTest()
        {
            Arithmetic arithmetic = new Arithmetic();
            double result = arithmetic.divide(30, 5);
            double expected = 6;
            Assert.That(result, Is.EqualTo(expected));
        }
        [Test]
        public void DivideWithNull()
        {
            Arithmetic arithmetic = new Arithmetic();
            Assert.Throws<ArgumentNullException>(() => arithmetic.divide(2, null));
        }
        [TearDown]
        public void Completed()
        {
            arithmetic = null;
        }
    }

}