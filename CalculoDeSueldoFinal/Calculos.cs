using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeSueldoFinal
{
    class Calculos
    {

        public static double CSueltoTotal(double ValorH, double Hs, double Hfs)
        {
            double SueldoTotal;
            SueldoTotal = ValorH * Hs + (ValorH / 2 * Hfs);
            return SueldoTotal;
        }

        public static double CTotalPagar(double SueldoTotal, double CalcularPrevision, double CalcularSalud, double bonos, double descuentos)
        {
            double TotalPagar;
            TotalPagar = SueldoTotal + bonos - descuentos - CalcularPrevision - CalcularSalud;
            return TotalPagar;

        }
    }
}
