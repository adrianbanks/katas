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

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(-5)]
        public void ANumberDivisibleByFiveReturnsBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(number);
            Assert.That(answer, Is.EqualTo("buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(-15)]
        public void ANumberDivisibleByBothThreeAndFiveReturnsFizzBuzz(int number)
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(number);
            Assert.That(answer, Is.EqualTo("fizzbuzz"));
        }
    }
}
