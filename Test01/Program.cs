using System; //импорт пространства имен

namespace Test01
{
    class Program // объявление класса
    {
        static void Main(string[] args)  // объявление метода
        {

            bool simpleVar = false;
            if (simpleVar)
                Console.WriteLine("Это не будет выведено");

            int x = 6800;
            bool lessThanAMile = x < 5280;
            if (lessThanAMile)
                Console.WriteLine("Это будет выведено " + x);
 
        } //конец метода

    } // конец класса
}
