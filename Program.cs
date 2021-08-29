using System;

namespace OperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("value of a :" + a);

            a++;
            Console.WriteLine("value of a :" + a);

            ++a;
            Console.WriteLine("value of a :" + a);

            a--;
            Console.WriteLine("value of a :" + a);

            --a;
            Console.WriteLine("value of a :" + a);


            int b = 10;
            int c = 20;
            Console.WriteLine("Bitwise Operator");
            int d = b & c;
            Console.WriteLine("& AND :" + d);
            int e = b | c;
            Console.WriteLine("| OR :" + e);
            int f = b ^ c;
            Console.WriteLine("^ XOR :" + f);
            int g = ~b;
            Console.WriteLine("~ complement :" + g);
            int h = b <<3;
            
            Console.WriteLine("<< binarry left shift :" + d);
            int i = c>>4;
            Console.WriteLine(">> binary right shift :" + i);

            Console.WriteLine("Assignment Operator");
            int j = a + b;
            a += b;
            b -= c;
            c *= d;
            d /= e;
            e %= f;
            f <<= 2;
            g >>= 3;
            h &= 2;
            i ^= 2;
            j |= 2;
            Console.WriteLine("a += :" + a);
            Console.WriteLine("b -= :" + b);
            Console.WriteLine("c *= :" + c);
            Console.WriteLine("d /= :" + d);
            Console.WriteLine("e %= :" + e);
            Console.WriteLine("f <<= 2:" + f);
            Console.WriteLine("g >>= 3:" + g);
            Console.WriteLine("h &= 2:" + h);
            Console.WriteLine("i ^= :" + i);
            Console.WriteLine("j |= :" + j);
        }
    }
}
