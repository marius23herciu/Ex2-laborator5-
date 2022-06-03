using System;

namespace Ex2_laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 2
            //Scrieti un program care sa verifice daca un sir de caractere citit de la
            //tastatura este sau nu palindrom.

            Console.WriteLine("Introduceti un text:");
            string sir = Console.ReadLine();

            bool palindrom = VerificarePalindrom(sir);
            if (palindrom == true)
            {
                Console.WriteLine("Textul introdus este palindrom");
            }
            else
            {
                Console.WriteLine("Textul introdus NU este palindrom");
            }
        }
        static bool VerificarePalindrom(string sir)
        {
            bool result = true;
            int endIndex = sir.Length - 1;
            for (int i = 0; i < sir.Length / 2; i++)
            {
                if (sir[i] != sir[endIndex])
                {
                    result = false;
                    break;
                }
                endIndex--;
            }
            return result;
        }
    }
}
