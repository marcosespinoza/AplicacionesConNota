using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class DatosCapturados
    {
        public static string Cnombre()
        {

            string nombre;
            nombre = Console.ReadLine();
            return nombre;
        }

        public static string Capellido()
        {
            string apellido;
            apellido = Console.ReadLine();
            return apellido;
        }

        public static string CRut()
        {
            string rut;
            rut = Convert.ToString(Console.ReadLine());
            return rut;
        }

        public static int CAño()
        {
            int año;
            año = Convert.ToInt16(Console.ReadLine());
            return año;

        }

        public static int Cmes()
        {
            int mes;
            mes = Convert.ToInt32(Console.ReadLine());
            return mes;

        }

        public static double horasNormales()
        {
            double Hs;
            Hs = Convert.ToDouble((Console.ReadLine()));
            return Hs;
        }


        public static double horasFinSemana()
        {
            double Hfs;
            Hfs = Convert.ToDouble((Console.ReadLine()));
            return Hfs;
        }

        public static double valorHora()
        {
            double ValorH;
            ValorH = Convert.ToDouble((Console.ReadLine()));
            return ValorH;
        }

        public static double Cdescuentos()
        {
            double descuentos;
            descuentos = Convert.ToDouble(Console.ReadLine());
            return descuentos;
        }

        public static double Cbonos()
        {
            double bonos;
            bonos = Convert.ToDouble(Console.ReadLine());
            return bonos;
        }

        public static double Canticipos()
        {
            double anticipos;
            anticipos = Convert.ToDouble(Console.ReadLine());
            return anticipos;
        }

        public static int Cprevision()
        {
            int Prevision;
            Prevision = Convert.ToInt32(Console.ReadLine());
            return Prevision;
        }

        public static int Csalud()
        {
            int Salud;
            Salud = Convert.ToInt32(Console.ReadLine());
            return Salud;
        }


        public static double CapturarValorIsapre()
        {
            double Isapre;
            Isapre = Convert.ToInt32(Console.ReadLine());
            return Isapre;
        }



    }
}


