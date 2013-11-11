using System.Text;

namespace TeaParty
{
    public class GuestGreeter
    {
        public string Greet(string surname, bool isMale, bool isKnighted)
        {
            var greeting = new StringBuilder();
            greeting.Append("Hello ");

            if (isKnighted)
            {
                greeting.Append("Sir.");
            }
            else
            {
                greeting.Append(isMale ? "Mr." : "Ms.");
            }

            greeting.Append(" ");
            greeting.Append(surname);
            return greeting.ToString();
        }
    }
}
