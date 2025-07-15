namespace GetAverage
{
    internal class Program
    {
        //평균 구하기
        //https://school.programmers.co.kr/learn/courses/30/lessons/12944
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 5, 5 };
            Console.WriteLine(Solution(arr1));
            Console.WriteLine(Solution(arr2));
        }

        public static double Solution(int[] arr)
        {
            double answer = 0;
            foreach (int i in arr)
            {
                answer += i;
            }

            return (double)answer / arr.Length;
        }
    }
}
