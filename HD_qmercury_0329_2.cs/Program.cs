using System;

namespace HD_qmercury_0329_2.cs
{
    class Program
    {
        static void Main(string[] args)
        {// while만 이용하여 2단, 4단, 6단 구구단을 출력하는 프로그램을 작성하기

            int i = 2;
            while (i < 7)
            {
                int j = 1;
                while (j < 10)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                    ++j;
                    
                }
                j = 1;
                i = i + 2;
            }
            
        }
    }
}
