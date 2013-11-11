using NUnit.Framework;

namespace TeaParty
{
    [TestFixture]
    public sealed class GuestGreeterTests
    {
        [TestCase("Austen")]
        [TestCase("Jones")]
        public void AWomanIsGreetedAsMs(string surname)
        {
            var guest = new Guest(surname, false, false);
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(guest);
            Assert.That(greeting, Is.EqualTo("Hello Ms. " + surname));
        }

        [TestCase("Orwell")]
        [TestCase("Jones")]
        public void AManIsGreetedAsMr(string surname)
        {
            var guest = new Guest(surname, true, false);
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(guest);
            Assert.That(greeting, Is.EqualTo("Hello Mr. " + surname));
        }

        [Test]
        public void ASirIsGreetedAsSir()
        {
            var guest = new Guest("Newton", true, true);
            var guestGreeter = new GuestGreeter();
            string greeting = guestGreeter.Greet(guest);
            Assert.That(greeting, Is.EqualTo("Hello Sir. Newton"));
        }
    }
}
