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


        //Array que contiene variables del juego
        static char[,] tableroJuego =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }
        };

        //Método crea el tablero
        public static void CreaTablero()
        {
            Console.WriteLine("_________________");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  |  {2}",  tableroJuego[0,0], tableroJuego[0,1], tableroJuego[0,2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  |  {2}", tableroJuego[1, 0], tableroJuego[1, 1], tableroJuego[1, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |");
            Console.WriteLine(" {0}   |  {1}  |  {2}", tableroJuego[2, 0], tableroJuego[2, 1], tableroJuego[2, 2]);
            Console.WriteLine("_____|_____|_____");
        }
    }
}
