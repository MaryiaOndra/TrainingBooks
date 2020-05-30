using System; //импорт пространства имен

namespace Test01
{
    class Program // объявление класса
    {
        static void Main(string[] args)  // объявление метода
        {
            string message = "Верни мне мой ";
            string upperMessage = message.ToUpper();
            Console.WriteLine(upperMessage);

            int x = 2007;
            message = message + x;
            Console.WriteLine(message);

            Console.ReadLine();

       
        } //конец метода



    } // конец класса
}
