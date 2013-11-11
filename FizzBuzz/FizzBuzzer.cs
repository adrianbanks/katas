namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetAnswer(int i)
        {
            if (i == 0)
            {
                return 0.ToString();
            }

            if (IsFizzBuzz(i))
            {
                return "fizzbuzz";
            }

            if (IsFizz(i))
            {
                return "fizz";
            }

            if (IsBuzz(i))
            {
                return "buzz";
            }

            return i.ToString();
        }

        private static bool IsFizzBuzz(int i)
        {
            return i % 15 == 0;
        }

        private static bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }

        private static bool IsFizz(int i)
        {
            return i % 3 == 0;
        }
    }
}
