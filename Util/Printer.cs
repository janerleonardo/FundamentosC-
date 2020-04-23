using System.Linq;

namespace CoreEscuela.Util
{
    public static class Printer
    {
        public static void Dibujarlinea(int cant = 10)
        {
            var linea = "".PadLeft(cant, '=');
            System.Console.WriteLine("PadLeft" + linea);

            var linea1 = "".PadRight(cant, '=');
            System.Console.WriteLine("PadLeft" + linea1);

            string v = new string('*', cant);
            System.Console.WriteLine("string" + v);

            string B = string.Concat(Enumerable.Repeat("-", cant));
            System.Console.WriteLine("Concat(Enumerable)" + B);
        }
    }
}