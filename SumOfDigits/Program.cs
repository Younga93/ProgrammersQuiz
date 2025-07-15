namespace SumOfDigits
{
    internal class Program
    {
        //자릿수 더하기
        //https://school.programmers.co.kr/learn/courses/30/lessons/12931
        static void Main(string[] args)
        {
            int num1 = 123;
            int num2 = 987;

            Console.WriteLine(Solution(num1));
            Console.WriteLine(Solution(num2));
        }
        public static int Solution(int n)
        {
            int answer = 0;
            int currentNumber = n;
            while (currentNumber != 0)
            {
                answer += currentNumber % 10;
                currentNumber /= 10;
            }
            return answer;
        }
    }
}
