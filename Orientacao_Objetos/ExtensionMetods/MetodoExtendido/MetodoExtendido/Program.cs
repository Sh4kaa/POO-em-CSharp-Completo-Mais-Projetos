using MetodoExtendido.Extensions;
using System;


namespace MetodoExtendido
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 07, 22, 13, 10, 45);

            Console.WriteLine(dt.ElapsedTime());

        }
    }
}
