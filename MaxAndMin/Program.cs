namespace MaxAndMin
{
    internal class Program
    {
        //최댓값과 최솟값
        //https://school.programmers.co.kr/learn/courses/30/lessons/12939
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("-1 -2 -3 -4"));
        }

        public static string Solution(string s)
        {
            string[] numbers = s.Split();

            int max = int.Parse(numbers[0]);
            int min = int.Parse(numbers[0]);

            foreach (string number in numbers)
            {
                int num = int.Parse(number);
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return $"{min} {max}";
        }
    }
}
