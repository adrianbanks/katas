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

            if (i % 3 == 0)
            {
                answer += "fizz";
            }

            if (i % 5 == 0)
            {
                answer += "buzz";
            }

            return string.IsNullOrEmpty(answer) ? i.ToString() : answer;
        }
    }
}
