using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class Principal
    {
        static void Main(string[] args)
        {
            string nombre, apellido, rut;
            int año, mes, Prevision, Salud;
            double Hs, Hfs;                              //hora normales semanales y  fin de semana
            double ValorH, descuentos, bonos, anticipos; //valorHora
            double SwitchPrevision, SwitchSalud;

            double CalcularPrevision = 0, CalcularSalud = 0, SueldoTotal = 0, TotalPagar, ValorIsapre = 0;

            DatosSolicitados.mensajeInicio();

            DatosSolicitados.nombre();
            nombre = DatosCapturados.Cnombre();


            DatosSolicitados.apellido();
            apellido = DatosCapturados.Capellido();

            DatosSolicitados.rut();
            rut = DatosCapturados.CRut();

            DatosSolicitados.año();
            año = DatosCapturados.CAño();

            DatosSolicitados.mes();
            mes = DatosCapturados.Cmes();

            DatosSolicitados.HorasNormales();
            Hs = DatosCapturados.horasNormales();


            DatosSolicitados.HorasFinSemana();
            Hfs = DatosCapturados.horasFinSemana();


            DatosSolicitados.valorHora();
            ValorH = DatosCapturados.valorHora();


            DatosSolicitados.Prevision();
            Prevision = DatosCapturados.Cprevision();
            SwitchPrevision = UsoSwitch.SeleccionPrevision(Prevision, SueldoTotal);

            DatosSolicitados.Salud();
            Salud = DatosCapturados.Csalud();
            SwitchSalud = UsoSwitch.SeleccionSalud(Salud, SueldoTotal);

            DatosSolicitados.Descuentos();
            descuentos = DatosCapturados.Cdescuentos();


            DatosSolicitados.Bonos();
            bonos = DatosCapturados.Cbonos();


            DatosSolicitados.Anticipos();
            anticipos = DatosCapturados.Canticipos();


            SueldoTotal = Calculos.CSueltoTotal(ValorH, Hs, Hfs);


            TotalPagar = Calculos.CTotalPagar(SueldoTotal, CalcularPrevision, CalcularSalud, bonos, descuentos);

            System.Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n");
            Console.WriteLine("................................................................................" + "\n");
            Console.WriteLine("¡Detalles de Liquidación!" + "\n");
            Console.WriteLine("Fecha:" + mes + "/" + año);
            Console.WriteLine("Sr(a):" + nombre + " " + apellido + "\n" + "Rut:" + rut + "\n" +
                 "Total bonos :" + bonos + "\n" + "Total anticipos:" + anticipos + "\n" + "Total descuentos :" + descuentos + "\n");


            System.Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("TOTAL A PAGAR :" + "$" + TotalPagar);

            Console.ReadKey();


        }
    }
}

