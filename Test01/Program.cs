using System; //импорт пространства имен

namespace Test01
{
    class Program // объявление класса
    {
        static void Main(string[] args)  // объявление метода
        {
            int x = 12 * 30; // оператор 1
            Console.WriteLine(x); // оператор 2

            Console.WriteLine(FeetToInches(156540));
            Console.WriteLine(FeetToInches(1500));
            Console.WriteLine(FeetToInches(1125));

            Console.WriteLine
                (5 + 6 + 4 + 7 + 5 + 8 + 5 + 4 + 4 + 7 + 77 + 7 + 5 + 8);


            Console.ReadLine();
        } //конец метода

        static int FeetToInches (int feet)
        {
            int inches = feet * 12;
            return inches;
        }


    } // конец класса
}
