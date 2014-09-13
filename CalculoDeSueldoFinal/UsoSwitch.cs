using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class UsoSwitch
    {

        public static double SeleccionPrevision(int Prevision, double SueldoTotal)
        {
            double Vprevision = 0;//valor de la prevision

            switch (Prevision)
            {
                case 1:
                    Console.WriteLine("¡Ha seleccionado AFP CAPITAL!" + "\n");
                    Vprevision = PrevisionSalud.AfpCapital(SueldoTotal);
                    break;
                case 2:
                    Console.WriteLine("¡Ha seleccionado AFP CUPRUM!" + "\n");
                    Vprevision = PrevisionSalud.AfpCuprum(SueldoTotal);
                    break;
                case 3:
                    Console.WriteLine("¡Ha seleccionado AFP HABITAT!" + "\n");
                    Vprevision = PrevisionSalud.AfpHabitat(SueldoTotal);
                    break;
                case 4:
                    Console.WriteLine("¡Ha seleccionado AFP MODELO!" + "\n");
                    Vprevision = PrevisionSalud.AfpModelo(SueldoTotal);
                    break;
                case 5:
                    Console.WriteLine("¡Ha seleccionado AFP PLANVITAL!" + "\n");
                    Vprevision = PrevisionSalud.AfpProvida(SueldoTotal);
                    break;
                case 6:
                    Console.WriteLine("¡Ha seleccionado AFP PROVIDA!" + "\n");
                    Vprevision = PrevisionSalud.AfpPlanVital(SueldoTotal);
                    break;
                default: Console.Write("¡Ingrese una opción correcta!" + "\n");
                    break;
            }
            return Vprevision;
        }

        public static double SeleccionSalud(int Salud, double SueldoTotal)
        {
            double Vsalud = 0;//valor de la Salud

            switch (Salud)
            {
                case 1:
                    
                    Console.WriteLine("¡Ha seleccionado FONASA!" + "\n");
                    Vsalud = PrevisionSalud.CalcularFonasa(SueldoTotal);
                    break;
                case 2:
                    
                    Console.WriteLine("¡Ha seleccionado ISAPRE!" + "\n");

                    Vsalud = PrevisionSalud.CalcularIsapre(SueldoTotal);
                    break;

                default: Console.Write("¡Ingrese una opción correcta!" + "\n");
                    break;
            }
            return Vsalud;
        }

    }
}
