using System;

namespace Evaluacion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            int b = 30;
            int c = 78;
            
            //aacb
            Console.WriteLine("{0}{0}{2}{1}",a,b,c);

            //bca
            Console.WriteLine("{1}{2}{0}", a, b, c);

            //bcbc
            Console.WriteLine("{1}{2}{1}{2}", a, b, c);
            
            Console.ReadKey();
        }
    }
}
