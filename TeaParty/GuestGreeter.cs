namespace TeaParty
{
    public class GuestGreeter
    {
        public string Greet(Guest guest)
        {
            return string.Format("Hello {0} {1}", guest.Salutation, guest.Surname);
        }
    }
}
