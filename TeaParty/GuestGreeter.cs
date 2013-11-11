namespace TeaParty
{
    public class GuestGreeter
    {
        public string Greet(string surname, bool isMale)
        {
            if (isMale)
            {
                return "Hello Mr. " + surname;
            }
            else
            {
                return "Hello Ms. " + surname;
            }
        }
    }
}
