using System.Net.NetworkInformation;

class Ejercicio4
{
    public static void Juego1()
    {
        Console.WriteLine("Bienvenido al juego de los dados. Este se lanzará 10 veces en total. De cuantas caras es el dado que quieres lanzar?");
        int caras = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cual es el numero que quieres acertar?");
        int acierto = Convert.ToInt32(Console.ReadLine());
        int tiradas = 0;
        int cantidad = 0;
        Random generador = new Random();
        do
        {
            int num = generador.Next(1, caras + 1);
            Console.WriteLine(num);
            tiradas++;
            if (num == acierto)
            {
                cantidad++;
            }
        } while (tiradas < 10);
        if(cantidad!=0){
            Console.WriteLine("Felicidades; acertaste {0} veces", cantidad);
        }
        else
        {
            Console.WriteLine("No acertaste ni una, mejor suerte la proxima");
        }
    }

    public static void Juego2()
    {
        Random generador = new Random();
        int adivinar = generador.Next(1, 101);
        int intentos = 5;
        int pruebas;
        Console.WriteLine("Se ha generado un numero entre 1 y 100");
        do
        {
            Console.WriteLine("tienes " + intentos + " intentos restantes para adivinar");
            pruebas = Convert.ToInt32(Console.ReadLine());
            if (pruebas < adivinar)
            {
                Console.WriteLine("el numero es mayor");
            }
            else if (pruebas > adivinar)
            {
                Console.WriteLine("el numero es menor");
            }
            intentos--;
        } while (pruebas != adivinar && intentos != 0);
        if(adivinar == pruebas)
        {
            Console.WriteLine("Felicidades, has acertado, el numero era " + adivinar);
        }
        else
        {
            Console.WriteLine("Has perdido, mejor suerte la proxima, el numero era " + adivinar);
        }
    }

    public static void Juego3()
    {
        Random generador = new Random();
        int quiniela;
        int contador=0;
        Console.WriteLine("Los numeros de la quiniela son");
        do
        {
            quiniela = generador.Next(1, 101);
            switch (quiniela)
            {
                case >= 1 and <= 60:
                    Console.WriteLine("1");
                    break;

                case >= 61 and <= 75:
                    Console.WriteLine("X");
                    break;

                case >= 76 and <= 100:
                    Console.WriteLine("2");
                    break;
            }
            contador++;
        } while (contador < 14); 
    }

    public static void Main()
    {
        int opcion;
        int volver;
        do
        {
            Console.WriteLine("Bienvenido al menú de juegos, que quiere hacer? {1 = Jugar a los Dados}  {2 = Adivina el Número}  {3 = Jugar a la Quiniela}  {4 = Jugar a todos}  {5 = Salir}");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    do
                    {
                        Juego1();
                        Console.WriteLine("Desea volver a jugar? {1 = NO}");
                        volver = Convert.ToInt32(Console.ReadLine());
                    } while (volver != 1);
                    
                    if (opcion == 4)
                    {
                        goto case 2;
                    }
                    break;
                case 2:
                    do
                    {
                        Juego2();
                        Console.WriteLine("Desea volver a jugar? {1 = NO}");
                        volver = Convert.ToInt32(Console.ReadLine());
                    } while (volver != 1);

                    if (opcion == 4)
                    {
                        goto case 3;
                    }
                    break;
                case 3:
                    do
                    {
                        Juego3();
                        Console.WriteLine("Desea volver a jugar? {1 = NO}");
                        volver = Convert.ToInt32(Console.ReadLine());
                        if (opcion == 4 && volver !=1)
                        {
                            goto case 4;
                        }
                    } while (volver != 1);
                    break;
                case 4:
                    goto case 1;

                    break;
                case 5:
                    Console.WriteLine("Gracias por jugar vuelva pronto");
                    break;
                default:
                    Console.WriteLine("Esa no es una opción");
                    break;
            }   
        } while (opcion != 5);
        
    }
}

