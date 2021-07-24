using System;

namespace TaTeTi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CreaTablero();
            Console.Read();
            
        }
        //Método crea el tablero
        public static void CreaTablero()
        {
            Console.WriteLine("_________________");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  | {2}",  1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  | {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  | {2}", 1, 2, 3);
            Console.WriteLine("_____|_____|_____");
        }
    }
}
