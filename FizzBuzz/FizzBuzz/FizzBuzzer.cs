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

            string answer = string.Empty;

            if (IsFizz(i))
            {
                answer += "fizz";
            }

            if (IsBuzz(i))
            {
                answer += "buzz";
            }

            return string.IsNullOrEmpty(answer) ? i.ToString() : answer;
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
