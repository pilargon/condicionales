using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {  /*
            //Pedir 2 numeros y decir si son iguales o no
            Console.WriteLine("Dame 2 numeros");  //Mejor declarar las variables antes de escribir esta frase.
            int num1;// Podriamos poner mejor int num1, num2;
            num1 = Convert.ToInt32(Console.ReadLine());
            int num2;
            num2 = Convert.ToInt32(Console.ReadLine());//Todo lo que se lee por consola,visual lo lee como un string
            if (num1==num2)//La condicion solo se analiza en el if. Tambien se podria poner (num1!=num2) pero cambiando los condicionales
            {
                Console.WriteLine("Los 2 numeros son iguales");
            }
            else
            {
                Console.WriteLine("Los 2 numeros son distintos");
            }


            //Introduce un numero e indica si es par o impar
            Console.WriteLine("Dame un numero");// Se podria reciclar la variable num1
            int num3;
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num3%2==0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }


            //Pedir un numero de la semana 1-7 y decir que dia de la semana es
            Console.WriteLine("Dame un del 1 al 7");
            int num5;
            num5 = Convert.ToInt32(Console.ReadLine());

             if (num5 == 1) 
                {
                Console.WriteLine("Es lunes");
                }

            else if (num5 == 2) 
                {
                Console.WriteLine("Es martes");
                } 

            else if (num5 == 3) 
                {
                Console.WriteLine("Es miercoles");
                }
            
            else if (num5 == 4) 
                {
                Console.WriteLine("Es jueves");
                }

            else if (num5 == 5) 
                {
                Console.WriteLine("Es viernes");
                } 

            else if (num5 == 6) 
                {
                Console.WriteLine("Es sabado");
                }
            else if (num5==7)
            {
                Console.WriteLine("Es domingo");
            }

            else
            {
                Console.WriteLine("Te he dicho un numero del 1 al 7");
            }
            

            //Escribir un numero del 1 al 12 y decir que mes es

            Console.WriteLine("Dame un del 1 al 12");
            int num6;
            num6 = Convert.ToInt32(Console.ReadLine());

            switch (num6) //analizamos los distintos valores
            {
                case 1://no hace falta ; porque siempre va a analizar ==
                    Console.WriteLine("El mes es Enero");
                    break;// para que salga al realizar la accion
                case 2:
                    Console.WriteLine("El mes es Febrero");
                    break;
                case 3:
                    Console.WriteLine("El mes es Marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes es Abril");
                    break;
                case 5:
                    Console.WriteLine("El mes es Mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes es Junio");
                    break;
                case 7:
                    Console.WriteLine("El mes es Julio");
                    break;
                case 8:
                    Console.WriteLine("El mes es Agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes es Octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes es Diciembre");
                    break;
                default://no hace falta poner ningun valor,si no coincide con ninguno hace esto
                    Console.WriteLine("El numero es mayor de 12");
                    break;
            }
            */

            // operadores logicos
            int nota;

            Console.WriteLine("Dame una nota");
            nota = Convert.ToInt32(Console.ReadLine());

            if (nota >=5 && nota <6)
            {
                Console.WriteLine("Aprobado");
            }
            else if (nota<5 && nota>=0) //para que no admita negativos
            {
                Console.WriteLine("Suspenso");
            }
            else if (nota >=6 && nota <7)
            {
                Console.WriteLine("Bien");
            }
            else if (nota >=7 && nota <8)
            {
                Console.WriteLine("Muy bien");
            }
            else if (nota >=8 && nota <9)
            {
                Console.WriteLine("Excelente");
            }
            else if (nota >=9 && nota <=10)
            {
                Console.WriteLine("Perfecto");
            }

            else
            {
                Console.WriteLine("El numero introducido no es correcto");
            }






            Console.ReadLine();
        }

       

            


       
    }
            
}
            
