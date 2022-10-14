using System;
using System.Collections.Generic;
using System.Linq;

namespace kaspertest
{
    class Program
    {
        // Так как в условии сказано, что все команды точно соответствуют формату,
        // я проверять на корректность переход в дочернюю папку никак не буду,
        // методом исключения это команда такого типа.
        public static int Operate(List<string> ops)
        {
            int distance = 0;
            foreach (var op in ops)
            {
                switch (op)
                {
                    case "../" :
                        if (distance != 0)
                            distance--;
                        break;
                    case "./" :
                        break;
                    default:
                        distance++;
                        break;
                }
            }
            return distance;
        }
        
        static void Main(string[] args)
        {
            List<string> ops = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(Operate(ops));
        }
    }
}