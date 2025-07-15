namespace ReverseDigits
{
    internal class Program
    {
        //자연수 뒤집어 배열로 만들기
        //https://school.programmers.co.kr/learn/courses/30/lessons/12932
        static void Main(string[] args)
        {
            int num = 12345;
            int[] results = Solution(num);
            foreach (int i in results)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] Solution(long n)
        {
            int length = n.ToString().Length;
            int[] answer = new int[length];
            long currentNumber = n;
            for(int i = 0; i < length; i++)
            {
                answer[i] = (int)(currentNumber % 10);
                currentNumber /= 10;
            }

            return answer;
        }
    }
}
