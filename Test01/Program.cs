using System; //импорт пространства имен
using System.Security.Cryptography.X509Certificates;

namespace Test01
{
    class Program // объявление класса
    {
        public class Panda
        {
            public string Name;
            public static int Population;
            public Panda(string n)
            {
                Name = n;
                Population = Population + 1;
            }
        }


        static void Main(string[] args)// объявление метода
        {
            Panda p1 = new Panda("Панда По");
            Panda p2 = new Panda("Панда Ру");

            Console.WriteLine(p1.Name);
            Console.WriteLine(p2.Name);

            Console.WriteLine(Panda.Population);


        }
   

    } // конец класса
}
