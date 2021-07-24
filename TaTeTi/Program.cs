using System;

namespace TaTeTi
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int jugador = 2;
            int ingreso = 0;
            bool ingresoCorrecto = true;

            CreaTablero();
            Console.Read();

            do
            {
                //especificando a que jugador le corresponde el turno
                if (jugador == 2)
                {
                    jugador = 1;
                } else if (jugador == 1)
                {
                    jugador = 2;
                }

                switch (jugador)
                {
                    case 1:
                        switch (ingreso)
                        {
                            case 1: tableroJuego[0,0] = 'X'; break;
                            case 2: tableroJuego[0,1] = 'X'; break;
                            case 3: tableroJuego[0,2] = 'X'; break;
                            case 4: tableroJuego[1,0] = 'X'; break;
                            case 5: tableroJuego[1,1] = 'X'; break;
                            case 6: tableroJuego[1,2] = 'X'; break;
                            case 7: tableroJuego[2,0] = 'X'; break;
                            case 8: tableroJuego[2,1] = 'X'; break;
                            case 9: tableroJuego[2,1] = 'X'; break;

                        }break;//fin switch ingreso


                }



            } while (true);
            
        }

        //Método para identificar Jugador


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
