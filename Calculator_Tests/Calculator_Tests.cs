using NUnit.Framework;
using My_Calculator;

public class Calculator_Tests
{
    internal class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            Assert.That(()=>new Calculator(5, 3, '+').Calculate(), Is.EqualTo(8));
        }

        [Test]
        public void TestSubtraction()
        {
            Assert.That(()=> new Calculator(10, 4, '-').Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void TestMultiplication()
        {
            Assert.That(()=> new Calculator(3, 4, '*') .Calculate(), Is.EqualTo(12));
        }

        [Test]
        public void TestDivision()
        {
            Assert.That(()=> new Calculator(10, 2, '/').Calculate(), Is.EqualTo(5));
        }

        [Test]
        public void TestDivisionByZero_ThrowsError()
        {
            Assert.That(() => new Calculator(10, 0, '/').Calculate(), Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void TestInvalidOperator_ThrowsError()
        {
            Assert.That(() => new Calculator(10, 5, '%').Calculate(), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void TestNegativeNumbers()
        {
            Assert.That(()=> new Calculator(-3, -2, '*').Calculate(), Is.EqualTo(6));
        }

        [Test]
        public void TestFloatingPointPrecision()
        {
            Assert.That(()=> new Calculator(10.5, 2.1, '/').Calculate(), Is.EqualTo(5).Within(0.001));
        }

        [Test]
        public void TestZeroOperations()
        {
            Assert.That(()=> new Calculator(0, 5, '+').Calculate(), Is.EqualTo(5));
            Assert.That(()=> new Calculator(0, 5, '*').Calculate(), Is.EqualTo(0));
        }
    }
}