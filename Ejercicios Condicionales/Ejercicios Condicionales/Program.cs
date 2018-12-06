﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
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


                // operadores logicos
                double nota;

                Console.WriteLine("Dame una nota");
                nota = Convert.ToDouble(Console.ReadLine());

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



                //Pide altura y peso y calcula el imc segun la OMS

                double altura;// al introducir los datos,hay que poner comas y no puntos
                double peso;

                Console.WriteLine("Dame una altura en metros");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dame un peso en kilos");
                peso = Convert.ToDouble(Console.ReadLine());


                double imc;
                imc = peso / (altura * altura);// tambien se puede poner: imc= peso/ Math.Pow(altura,2)

                if (altura >= 1 && altura <= 2.5 && peso>=20 && peso<=200)// metemos una acotacion a la altura y peso
                    //para que no hayan alturas o pesos "raros"

                {
                    if (imc < 16.0)
                    {
                        Console.WriteLine("El imc es de delgadez severa");
                    }
                    else if (imc >= 16 && imc < 16)
                    {
                        Console.WriteLine("El imc es de delgadez moderada");
                    }
                    else if (imc > 16 && imc <= 18.49)
                    {
                        Console.WriteLine("El imc es de delgadez moderada");
                    }
                    else if (imc >= 18.5 && imc <= 24.99)
                    {
                        Console.WriteLine("El imc es de delgadez aceptable");
                    }
                    else if (imc >= 25 && imc <= 29.99)
                    {
                        Console.WriteLine("El imc es de peso normal");
                    }
                    else if (imc >= 30 && imc <= 34.99)
                    {
                        Console.WriteLine("El imc es de sobrepeso");
                    }
                    else if (imc >= 35 && imc <= 40)
                    {
                        Console.WriteLine("El imc es de obeso tipo I");
                    }
                    else if (imc >= 35 && imc <= 40)
                    {
                        Console.WriteLine("El imc es de obeso tipo II");
                    }
                    else if (imc > 40)
                    {
                        Console.WriteLine("El imc es de obeso tipo III");
                    }
                    else
                    {
                        Console.WriteLine("Los datos introducidos no son correctos");
                    }

                }
                    else
                    {
                    Console.WriteLine("La altura o el peso estan mal");

                    }

        

            



            Console.ReadLine();


        }
    }
}


    
            
            

            //Escribe un programa que pida dos números y que muestre la suma, la resta, 
            //la multiplicación, la media, el máximo y el mínimo.

            int dig1;
            Console.WriteLine("Dame un numero");
            dig1 = Convert.ToInt32(Console.ReadLine());
            int dig2;
            Console.WriteLine("Dame otro numero");
            dig2 = Convert.ToInt32(Console.ReadLine());
            double suma;
            double resta;
            double multiplicacion;
            double media;
            double maximo;
            double minimo;

            suma = dig1 + dig2;
            resta = dig1 - dig2;
            multiplicacion = dig1 * dig2;
            media = (dig1 + dig2) / 2;

            Console.WriteLine("La suma es " + suma);
            Console.WriteLine("la resta es " + resta);
            Console.WriteLine("la multiplicacion es " + multiplicacion);
            Console.WriteLine("La media es " + media);

            if (dig1>dig2)
            {
                Console.WriteLine(dig1 + " es el maximo y " + dig2 + " es el minimo");
            }
                 
            else if (dig1<dig2)
            {
                Console.WriteLine(dig1 + " es el minimo y " + dig2 + " es el maximo");
            }
            
            //Escribe un programa que pida al usuario 3 números. Si el resultado de la suma de los 
            //dos primeros es igual al tercer número, mostrarlo en pantalla, sino mostrar que el 
            // tercero no es la suma de los dos anteriores.

            int dig1;
            Console.WriteLine("Dame un numero");
            dig1 = Convert.ToInt32(Console.ReadLine());
            int dig2;
            Console.WriteLine("Dame otro numero");
            dig2 = Convert.ToInt32(Console.ReadLine());
            int dig3;
            Console.WriteLine("Dame un numero");
            dig3 = Convert.ToInt32(Console.ReadLine());

            int suma;
            suma = dig1 + dig2;

            if (suma== dig3)
            {
                Console.WriteLine("La suma de los 2 primeros numeros es el tercero");
            }
            else
            {
                Console.WriteLine("la suma de los 2 primeros numeros no es el tercero");
            }

           

            //Escribe un programa que convierta los segundos a horas, minutos y segundos.

            int segundos;
            int horas;
            int minutos;
            int resto2;

            Console.WriteLine("Dime segundos para pasarlos a horas minutos y segundos");
            segundos = Convert.ToInt32(Console.ReadLine());

            horas = segundos / 3600;
            minutos = segundos % 3600 / 60;
            resto2 = segundos % 60; 

            Console.WriteLine(segundos + " son " + horas + " horas " + minutos + " minutos y " + resto2 + " segundos");

            
            //Escribe un programa que pida al usuario tres números y que diga si 
            //uno de ellos es 20 menos que uno de los otros.
            
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Dame un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1-20==num2)//se podria poner un solo if y el resto else if,si hicieramos esto y 
                //coincidieran en 2 casos,solo saldria 1 respuesta
            {
                Console.WriteLine(num1 +" es 20 veces mas que " +num2);
            }
             if (num2 - 20 == num1)
            {
                Console.WriteLine(num2 +" es 20 veces mas que " +num1);
            }
            if (num2 - 20 == num3)
            {
                Console.WriteLine(num2 + " es 20 veces mas que " + num3);
            }
            if (num3 - 20 == num2)
            {
                Console.WriteLine(num3 + " es 20 veces mas que " + num2);
            }
            if (num1 - 20 == num3)
            {
                Console.WriteLine(num1 + " es 20 veces mas que " + num3);
            }
            if (num3 - 20 == num1)
            {
                Console.WriteLine(num3 + " es 20 veces mas que " + num1);
            }

            else
            {
                Console.WriteLine("Ninguno de los 3 numeros es 20 unidades menor que otro");
            }
            
            //Escribe un programa que pida dos valores del usuario y 
            //Si los dos valores son iguales muestre 0
            //Si los dos valores tienen el mismo resto al dividir entre 6 mostrar el más pequeño
            //Si no que muestre el más grande de los dos
            
            int nume1;
            int nume2;

            Console.WriteLine("Dame un numero");
            nume1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero");
            nume2 = Convert.ToInt32(Console.ReadLine());

             if (nume1==nume2)
            {
                Console.WriteLine("0");
            }
             else if(nume1%6==nume2%6)
            {
                if (nume1%6>nume2%6)
                {
                    Console.WriteLine("El resto mas pequeño es " + nume2 % 6);
                }
                else if (nume1%6<nume2%6)
                {
                    Console.WriteLine("El resto mas pequeño es " + nume1 % 6);
                }
            }
             else

             if(nume1>nume2)
                  {
                Console.WriteLine("Los 2 numeros no son iguales ni tienen el mismo resto y " + nume1+ " es mayor ");
                  }
             else if (nume1<nume2)
            {
                Console.WriteLine("Los 2 numeros no son iguales ni tienen el mismo resto y " + nume2 + " es mayor ");
            }
            
            //Escribe un programa que pida dos números enteros entre 25 y 75 y que diga si hay un 
            //dígito en común entre los dos números.

            int numer1;
            int numer2;
            
            Console.WriteLine("Dame un numero entre 25 y 75");
            numer1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame otro numero entre 25 y 75");
            numer2 = Convert.ToInt32(Console.ReadLine());

            int digito1nume1;
            digito1nume1 = numer1 / 10;
            int digito2nume1;
            digito2nume1 = (digito1nume1 * 10)-numer1;
            int digito1nume2;
            digito1nume2 = numer2 / 10;
            int digito2nume2;
            digito2nume2 = (digito1nume2 * 10)-numer2;


            if (numer1>= 25 && numer1<= 75 && numer2>= 25 && numer2<=75 );
            {
                if (digito1nume1 == digito1nume2 || digito1nume1 == digito2nume2)
                {
                    Console.WriteLine("Hay al menos un digito en comun entre ambos numeros");
                }

                else
                {
                    Console.WriteLine("No hay digitos en comun entre los 2 numeros");
                }
            }
            
            //Comprobar si se ha pagado la entrada. 
            //Si se ha pagado, mostramos mensaje "Bienvenido",si no mostrar mensaje "Tienes que pagar la entrada".

            bool entradaPagada;
            bool clienteVip;
            int saldo;
            
            Console.WriteLine("¿Has pagado la entrada?.Diga si o no.");
            string respuesta = Console.ReadLine();
            
            if (respuesta=="si")
            {
                entradaPagada = true;
            }
            else
            {
                entradaPagada = false;
            }

            if (entradaPagada)
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Pague la entrada");
            }

            Console.WriteLine("Eres VIP?");
            string respuesta2 = Console.ReadLine();

            if (respuesta2 == "si")
            {
                clienteVip = true;
            }
            else
            {
                clienteVip = false;
            }

            if (clienteVip)
            {
                Console.WriteLine("Bienvenido.Que pase un buen dia");
            }
            else
            {
                Console.WriteLine("Bienvenido");
            }

            Console.WriteLine("Por cierto,que saldo tienes?");
            saldo = Convert.ToInt32(Console.ReadLine());

            if (saldo>=0 )
            {
                Console.WriteLine("Bienvenido");
            }

            Console.WriteLine("Hola,eres cliente VIP?");
            string respuesta3 = Console.ReadLine();// esta es una forma mas rapida de usar un texto escrito en la consola
            Console.WriteLine("Cuanto saldo tienes?");
            int respuesta4;
            respuesta4 = Convert.ToInt32(Console.ReadLine());

            if (respuesta3== "si" && respuesta4>=0)
            {
                Console.WriteLine("Bienvenido");
            }
            
            //Resultado de carrera. Hacer varios programas en los que se le pregunta al usuario 
            //el puesto en el que acabó. Después:

            //Si el valor de puesto es 1 mostramos mensaje con "Ganaste", si no "Lo importante es participar”.


            Console.WriteLine("En que puesto has quedado en la carrera?");
            int respuesta;
            respuesta = Convert.ToInt32(Console.ReadLine());

            if (respuesta == 1)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Lo importante es participar");
            }
            //Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", si el valor de puesto es 2,
            //mostramos el mensaje con "Medalla de plata", si es 3 "Medalla de bronce" y al resto "Lo importante " +
            //"es participar.
            Console.WriteLine("En que puesto has quedado en la carrera?");
            int respuesta2;
            respuesta2 = Convert.ToInt32(Console.ReadLine());

            if (respuesta2 == 1)
            {
                Console.WriteLine("Medalla de oro");
            }
            else if (respuesta2 == 2)
            {
                Console.WriteLine("Medalla de plata");
            }
            else if (respuesta2 == 3)
            {
                Console.WriteLine("Medalla de bronce");
            }

            else
            {
                Console.WriteLine("Lo importante es participar");

            }
            
            //Con switch: Si el valor de puesto es 1, mostramos mensaje con "Medalla de oro", 
            //si el valor de puesto es 2, mostramos el mensaje con "Medalla de plata", si es 3 
            //  "Medalla de bronce" y al resto "Lo importante es participar.

            Console.WriteLine("En que puesto has quedado en la carrera?");
            int respuesta3;
            respuesta3 = Convert.ToInt32(Console.ReadLine());

            switch (respuesta3)
            {
                case 1:
                    Console.WriteLine("Medalla de oro");
                    break;

                case 2:
                    Console.WriteLine("Medalla de plata");
                    break;

                case 3:
                    Console.WriteLine("Medalla de bronce");
                    break;

                default:
                    Console.WriteLine("Lo importante es participar");
                    break;


            }
            
            //Los puestos 1, 2 y 3 ven el mensaje "Sube al podium", el resto ven el mensaje
            //"Se acabó la carrera".Hazlo usando un if/else y usando switch
            Console.WriteLine("En que puesto has quedado en la carrera?");
            int respuesta3;
            respuesta3 = Convert.ToInt32(Console.ReadLine());

            switch (respuesta3)
            {
                case 1:
                    Console.WriteLine("Sube al podium");
                    break;

                case 2:
                    Console.WriteLine("Sube al podium");
                    break;

                case 3:
                    Console.WriteLine("Sube al podium");
                    break;

                default:
                    Console.WriteLine("Se acabo la carrera");
                    break;


            }

            Console.WriteLine("En que puesto has quedado en la carrera?");
            int respuesta2;
            respuesta2 = Convert.ToInt32(Console.ReadLine());

            if (respuesta2 == 1 || respuesta2 == 2|| respuesta2 == 3)
            {
                Console.WriteLine("Sube al podium");
            }        
            else
            {
                Console.WriteLine("Se acabo la carrera");
            }
            
            //Si la edad es igual o inferior 
            //a 8 mostramos mensaje "Pasa al tobogán", si no mostramos "Eres demasiado mayor para usar el tobogán" 

            Console.WriteLine("Cuantos años tienes?");
            int edad;
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad<=8)
            {
                Console.WriteLine("Pasa al tobogan");
            }
            else
            {
                Console.WriteLine("Eres demasiado mayor para usar el tobogan");
            }
            
            //Comprobar un string que tenga el valor del día de la semana(lunes, martes, ...).
            //Mostrar en pantalla el día que dice que es si es entre lunes y viernes
            //(Por ejemplo "Hoy es lunes") y si es fin de semana mostrar "Es fin de semana" Con switch y con if else.

            Console.WriteLine("Dime un dia de la semana");
            string semana = Console.ReadLine();

            if (semana== "lunes")
            {
                Console.WriteLine("Hoy es lunes");
            }
            if (semana == "martes")
            {
                Console.WriteLine("Hoy es martes");
            }
            if(semana == "miercoles")
            {
                Console.WriteLine("Hoy es miercoles");
            }
            if (semana == "jueves")
            {
                Console.WriteLine("Hoy es jueves");
            }
            if (semana == "viernes")
            {
                Console.WriteLine("Hoy es viernes") ;
            }
            if (semana == "sabado")
            {
                Console.WriteLine("Hoy es fin de semana");
            }
            if (semana == "domingo")
            {
                Console.WriteLine("Hoy es fin de semana");
            }

            
            //A partir de un valor de número entero, mostrar el mensaje "El valor absoluto de -7 es 7".
            //Si es menor que cero mostrar el valor en positivo, si es positivo o cero mostrar ese mismo valor.

            Console.WriteLine("Dime un numero");
            int respuesta2;
            respuesta2 = Convert.ToInt32(Console.ReadLine());

            if (respuesta2<0)
            {
                Console.WriteLine("El numero es negativo " + -respuesta2);
            }
            if (respuesta2>=0)
            {
                Console.WriteLine("El numero es positivo " + respuesta2);
            }

            
            //Decir el número de helados que queremos comprar. Cada helado vale 2 euros. 
            //Si compramos más de 10 helados, nos regalan uno gratis. Mostrar en pantalla 
            //el número de helados que nos dan y cuánto hemos pagado por ellos.

            Console.WriteLine("Cuantos helados quieres?");
            int helado;
            helado = Convert.ToInt32(Console.ReadLine());
            int precio;
            precio = helado * 2;
             
            if (helado<10 && helado>=1)
            {
                Console.WriteLine("Tienes " + helado + " helados y te van a costar " + precio + " euros");
            }
            else if(helado>=10 )
            {
                Console.WriteLine("Tienes " + (helado + 1) + " helados y te van a costar " + precio + " euros");
            }
            */

            //Tenemos dos números, un numerador y un dividendo. Si el dividendo no es cero, 
            //mostramos el resultado de dividir el numerador por el dividendo. Si el dividendo es cero,
            //mostramos el mensaje "No se puede dividir por cero"

            Console.WriteLine("Dame 2 numeros");
            int numerador, dividendo;
            numerador = Convert.ToInt32(Console.ReadLine());
            dividendo = Convert.ToInt32(Console.ReadLine());

            if (dividendo!=0)
            {
                Console.WriteLine("El resultado de dividir el numerador por el dividendo es " + numerador / dividendo);
            }
            else if (dividendo==0)
                    {
                Console.WriteLine("No se puede dividir por cero");
                    }
            









            Console.ReadLine();


        }
    }
}

            

            
