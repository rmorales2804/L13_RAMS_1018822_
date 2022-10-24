using System;

namespace L13_RAMS_1018822_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] p = new string[5];
            int[] e = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresar el nombre de la persona: ");
                p[i] = (Console.ReadLine());
                Console.Write("Ingrese la edad de la persona: ");
                e[i] = int.Parse(Console.ReadLine());
            }

            for (int edad = 0; edad < 5; edad++)
            {
                if (e[edad]>=18)
                {
                    Console.Write(" El nombre es: " 
                        + p[edad]);
                    Console.Write(" La edad es de: "
                        + e[edad]);
                }
            }
            Console.ReadLine();
        }
    }
}
