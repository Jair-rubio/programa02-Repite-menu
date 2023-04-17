using System;

namespace programa02_Repite_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Aqui es el servicio a clientes
             * de una franquicia de comida rapida
             * se implementara una estructura de seleccion
             * switch y una de repeticion do while
             * 
             */


            // Variable


            // Metodos
            int sel = 0;

            do {Console.WriteLine("Bienvenido a Macnome Alcanza");
            Console.WriteLine("Con que basura empiezas alimentarte hoy");
                Console.WriteLine("El menu es el siguiente");

                Console.WriteLine("1-Hamburguesa de queso");
                Console.WriteLine("2-Hamburguesa doble");
                Console.WriteLine("3-Hamburguesa de pollo");
                Console.WriteLine("4-Hamburguesa vegana");
                Console.WriteLine("5-No quiero pedir nada");
                Console.WriteLine("Cual deseas comer ");
                sel= Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (sel)
                {
                    case 1: 
                        Console.WriteLine("Seleccionaste hamburguesa con queso" +
                        "aderezada ligeramente con salmonela ..... por 35 pesos" +
                        "Puedo darte un combo  1=si  2=no");
                            sel = Convert.ToInt32(Console.ReadLine());
                        if (sel == 1)
                        {
                            Console.WriteLine("Muy bien, Tu orden es" +
                            "Una hamburguesa con queso -1 soda mediana-1orden de paquetaxo" +
                            "El precio a pagar es 222 pesos");
                        }
                        else
                        {
                            Console.WriteLine("Entonces Pague nomas 110 pesos");
                        }

                        break;

                   case 2:
                        Console.WriteLine("Seleccionaste hamburguesa doble" +
                        "aderezada ligeramente con salmonela ..... por 35 pesos" +
                        "Puedo darte un combo  1=si  2=no");
                        sel = Convert.ToInt32(Console.ReadLine());
                        if (sel == 1)
                        {
                            Console.WriteLine("Muy bien, Tu orden es" +
                            "Una hamburguesa con queso -1 soda mediana-1orden de paquetaxo" +
                            "El precio a pagar es 256 pesos");
                        }
                        else
                        {
                            Console.WriteLine("Entonces Pague nomas 125 pesos");
                        }
                        break;



                    case 3:
                        Console.WriteLine("Seleccionaste hamburguesa de pollo" +
                        "aderezada ligeramente con salmonela ..... por 35 pesos" +
                        "Puedo darte un combo  1=si  2=no");
                        sel = Convert.ToInt32(Console.ReadLine());
                        if (sel == 1)
                        {
                            Console.WriteLine("Muy bien, Tu orden es" +
                            "Una hamburguesa con queso -1 soda mediana-1orden de paquetaxo" +
                            "El precio a pagar es 296 pesos");
                        }
                        else
                        {
                            Console.WriteLine("Entonces Pague nomas 150 pesos");
                        }
                        break;


                    case 4:
                        Console.WriteLine("Seleccionaste hamburguesa Vegana" +
                        "aderezada ligeramente con salmonela ..... por 35 pesos" +
                        "Puedo darte un combo  1=si  2=no");
                        sel = Convert.ToInt32(Console.ReadLine());
                        if (sel == 1)
                        {
                            Console.WriteLine("Muy bien, Tu orden es" +
                            "Una hamburguesa con queso -1 soda mediana-1orden de paquetaxo" +
                            "El precio a pagar es 500 pesos");
                        }
                        else
                        {
                            Console.WriteLine("Entonces Pague nomas 950 pesos");
                        }
                        break;

                        case 5:
                        Console.WriteLine("Gracias vuelva pronto");
                        break;

                        default: Console.WriteLine("No computar ");
                            break;
                }
               if ( sel ==5)
                {
                    Console.WriteLine("Vallase Pues");
                }
                else
                {
                  Console.WriteLine("Disfrute su comida");
                }
               
                
                Console.ReadKey();
                Console.Clear();
            } 
            
            while (sel!=5);

            
        }
    }
}

/*
 * Elabore un programa que implemente los ciclo for
 * para imprimir una figura de asteriscos o simbolos 
 * en los siguientes formatos
 * 
 * 1-Rectangulo solida
 * 2-Rectangulo hueco
 * 3-Un triangulo equilatero
 * 4-Un triangulo rectangulo alineado ala izquierda
 * 
