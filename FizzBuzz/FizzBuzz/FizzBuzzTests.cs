using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public sealed class FizzBuzzTests
    {
        [Test]
        public void ZeroPrintsZero()
        {
            var fizzBuzzer = new FizzBuzzer();
            string answer = fizzBuzzer.GetAnswer(0);
            Assert.That(answer, Is.EqualTo("0"));
        }
    }
}
