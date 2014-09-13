using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class DatosSolicitados
    {
    public static void mensajeInicio()
        {
            System.Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡CALCULE SU SUELDO A PAGAR!" + "\n");
            Console.WriteLine("¡DATOS PERSONALES!");
            System.Console.ForegroundColor = ConsoleColor.White;
        }

        public static void nombre()
        {
          Console.Write("Ingrese su nombre :");
        }
        public static void apellido()
        {
        Console.Write("Ingrese su apellido :");
        }

        public static void rut()
        {
            //int rut;
            //bool esValido = false;
            
            Console.Write("Ingrese su Rut...¡si termina en K, reemplace por 1!:");
           // esValido = int.TryParse(Console.ReadLine(),out rut);

           //while(!esValido)
           // {
           //     Console.Write("¡Solo se aceptan números!");
           //     esValido = int.TryParse(Console.ReadLine(), out rut);
           // }

           //Console.WriteLine();
        }

        public static void año()
        {
            Console.Write("\n");
            Console.WriteLine("¡DATOS LABORALES!");
                       
                Console.Write("Ingrese Año :");               
                Console.ReadKey();


        }

        public static void mes()
        {
            Console.Write("Ingrese mes:");
        }

        public static void HorasNormales()
        {
           Console.Write("Ingrese Nº horas trabajadas en la semana : " );
        }

        public static void HorasFinSemana()
        {
           Console.Write("Ingrese Nº horas trabajadas los fines de semana : ");
        }

        public static void valorHora()
        {
          Console.Write("Ingrese el valor que le pagan por la hora trabajada : ");
        }

        public static void Descuentos()
        {
            Console.Write("\n");
            Console.Write("¡OTROS!" + "\n"); 
            Console.Write("Ingrese descuentos : ");
              
        }


        public static void Bonos()
        {
           Console.Write("Ingrese si obtuvo bonos : ");
            
        }

        public static void Anticipos()
        {
            Console.Write("Ingrese si pidió anticipos : ");
        }


        public static void Prevision()
        {
            Console.Write("\n");
            Console.Write("¡SELECCIONES SU PREVISION! " + "\n");
            Console.WriteLine("Opción 1: Capital");
            Console.WriteLine("Opción 2: Cuprum");
            Console.WriteLine("Opción 3: Habitat");
            Console.WriteLine("Opción 4: Modelo");
            Console.WriteLine("Opción 5: PlanVital");
            Console.WriteLine("Opción 6: Provida");
            Console.Write("Ingrese su opción :");
        }

        public static void Salud()
        {
            Console.Write("\n");
            Console.Write("¡SELECIONES SU SISTEMA DE SALUD!" + "\n"); 
            Console.Write("Opción 1: Fonasa:" + "\n");
            Console.Write("Opción 2: Isapre:" + "\n");
                       
            Console.Write("Ingrese su opción :");
            
           
        }
    }
}
