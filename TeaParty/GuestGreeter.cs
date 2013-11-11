using System.Text;

namespace TeaParty
{
    public class GuestGreeter
    {
        public string Greet(string surname, bool isMale)
        {
            var greeting = new StringBuilder();
            greeting.Append("Hello ");
            greeting.Append(isMale ? "Mr." : "Ms.");
            greeting.Append(" ");
            greeting.Append(surname);
            return greeting.ToString();
        }
    }
}
