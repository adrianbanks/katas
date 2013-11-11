using NUnit.Framework;

namespace TeaParty
{
    [TestFixture]
    public sealed class GuestGreeterTests
    {
        [Test]
        public void AWomanIsGreetedAsMs()
        {
            var guestGreeter = new GuestGreeter();
            guestGreeter.Greet("Austen", false);
        }
    }
}
