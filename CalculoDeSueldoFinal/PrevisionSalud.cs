using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class PrevisionSalud
    {
        //CALCULAR LAS LOS PORCENTAJES CORRESPONDIENTES A CADA PREVISION, AFP!


        public static double AfpCapital(double SueldoTotal)
        {
            double CalcularPrevision = (SueldoTotal * 1.44) / 100;
            return CalcularPrevision;
        }
        public static double AfpCuprum(double SueldoTotal)
        {
            double CalcularPrevision = (SueldoTotal * 1.48) / 100;
            return CalcularPrevision;
        }
        public static double AfpHabitat(double SueldoTotal)
        {
            double CalcularPrevision = (SueldoTotal * 1.27) / 100;
            return CalcularPrevision;
        }
        public static double AfpModelo(double SueldoTotal)
        {
            double CalcularPrevision = (SueldoTotal * 0.77) / 100;
            return CalcularPrevision;
        }
        public static double AfpProvida(double SueldoTotal)
        {

            double CalcularPrevision = (SueldoTotal * 1.54) / 100;
            return CalcularPrevision;
        }

        public static double AfpPlanVital(double SueldoTotal)
        {

            double CalcularPrevision = (SueldoTotal * 0.47);
            return CalcularPrevision;
        }

        //CALCULAR LOS VALORES CORRESPONDIENTES AL SISTEMA DE SALUD, "FONASA" O "ISAPRE" !

        public static double CalcularFonasa(double SueldoTotal)
        {
            double CalcularSalud = (SueldoTotal * 7) / 100;
            return CalcularSalud;
        }
        public static double CalcularIsapre(double SueldoTotal)
        {
            Console.WriteLine("Ingrese descuento por Isapre :");
            double digitarIsapre;
            digitarIsapre = Convert.ToDouble((Console.ReadLine()));
            return digitarIsapre;
        }


    }
}
