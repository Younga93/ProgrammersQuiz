namespace SumOfFactors
{
    internal class Program
    {
        //약수의 합
        //https://school.programmers.co.kr/learn/courses/30/lessons/12928
        static void Main(string[] args)
        {
            Console.WriteLine(Solution(12));
        }
        public static int Solution(int n)
        {
            int answer = 0;

            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    answer += i;
            }

            return answer;
        }
    }
}
