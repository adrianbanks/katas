namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetAnswer(int i)
        {
            if (i % 3 == 0)
            {
                return "fizz";
            }

            if (i % 5 == 0)
            {
                return "buzz";
            }

            return i.ToString();
        }
    }
}
