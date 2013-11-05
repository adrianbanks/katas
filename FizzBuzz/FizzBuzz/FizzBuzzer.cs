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

            return i.ToString();
        }
    }
}
