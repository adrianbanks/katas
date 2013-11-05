using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public sealed class FizzBuzzTests
    {
        [TestCase(0, "0")]
        [TestCase(1, "1")]
        public void ANonFizzBuzzNumberReturnsTheNumber(int number, string output)
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(number);
            Assert.That(answer, Is.EqualTo(output));
        }        

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(-3)]
        public void ANumberDivisibleByThreeReturnsFizz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(number);
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
