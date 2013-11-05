using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public sealed class FizzBuzzTests
    {
        [Test]
        public void ZeroReturnsZero()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(0);
            Assert.That(answer, Is.EqualTo("0"));
        }        
        
        [Test]
        public void OneReturnsOne()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(1);
            Assert.That(answer, Is.EqualTo("1"));
        }

        [Test]
        public void ANumberDivisibleByThreeReturnsFizz()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(3);
            Assert.That(answer, Is.EqualTo("fizz"));
        }

        [Test]
        public void ANumberDivisibleByFiveReturnsBuzz()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(5);
            Assert.That(answer, Is.EqualTo("buzz"));
        }

        [Test]
        public void ANumberDivisibleByBothThreeAndFiveReturnsFizzBuzz()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(15);
            Assert.That(answer, Is.EqualTo("fizzbuzz"));
        }
    }
}
