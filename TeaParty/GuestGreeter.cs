using System.Text;

namespace TeaParty
{
    public class GuestGreeter
    {
        public string Greet(Guest guest)
        {
            var greeting = new StringBuilder();
            greeting.Append("Hello ");

            if (guest.IsKnighted)
            {
                greeting.Append("Sir.");
            }
            else
            {
                greeting.Append(guest.IsMale ? "Mr." : "Ms.");
            }

            greeting.Append(" ");
            greeting.Append(guest.Surname);
            return greeting.ToString();
        }
    }
}
