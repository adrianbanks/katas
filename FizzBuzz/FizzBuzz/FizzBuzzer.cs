namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetAnswer(int i)
        {
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
