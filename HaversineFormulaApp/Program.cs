using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HaversineFormulaApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*Console.Write("Introduceti latitudinea punctului A:");
            string lat1 = Console.ReadLine();
            Console.Write("Introduceti longitudinea punctului A:");
            string lon1 = Console.ReadLine();
            Console.Write("Introduceti latitudinea punctului B:");
            string lat2 = Console.ReadLine();
            Console.Write("Introduceti longitudinea punctului B:");
            string lon2 = Console.ReadLine();


            const string Deg = "°";

            double ParseToString(string str)
            {
                str = str.ToUpper().Replace(Deg, " ").Replace("'", " ").Replace("\"", " ");
                str = str.Replace("S", " S").Replace("N", " N");
                str = str.Replace("E", " E").Replace("W", " W");
                char[] separators = { ' ' };
                string[] fields = str.Split(separators,
                    StringSplitOptions.RemoveEmptyEntries);

                double result =             // Degrees.
                    double.Parse(fields[0]);
                if (fields.Length > 2)      // Minutes.
                    result += double.Parse(fields[1]) / 60;
                if (fields.Length > 3)      // Seconds.
                    result += double.Parse(fields[2]) / 3600;
                if (str.Contains('S') || str.Contains('W')) result *= -1;

                return result;
            }

            double DegreesToRadians(double degrees)
            {
                return degrees * Math.PI / 180.0;
            }

            double GreatCircleDistance(double lat1, double lon1, double lat2, double lon2)
            {
                const double radius = 6371; // Radius of the Earth in km.
                lat1 = DegreesToRadians(lat1);
                lon1 = DegreesToRadians(lon1);
                lat2 = DegreesToRadians(lat2);
                lon2 = DegreesToRadians(lon2);
                double d_lat = lat2 - lat1;
                double d_lon = lon2 - lon1;
                double h = Math.Sin(d_lat / 2) * Math.Sin(d_lat / 2) +
                    Math.Cos(lat1) * Math.Cos(lat2) *
                    Math.Sin(d_lon / 2) * Math.Sin(d_lon / 2);
                return 2 * radius * Math.Asin(Math.Sqrt(h));
            }
            //Console.WriteLine("Longitudinea transformata este: {0}", ParseToString(lon1));
            Console.WriteLine("Punctul A (grade) = latitudine: {0}, longitudine: {1}", ParseToString(lat1), ParseToString(lon1));
            Console.WriteLine("Punctul B (grade) = latitudine: {0}, longitudine: {1}", ParseToString(lat2), ParseToString(lon2));

            double dist = GreatCircleDistance(ParseToString(lat1), ParseToString(lon1), ParseToString(lat2), ParseToString(lon2));
            Console.WriteLine("Distanta dintre cele doua puncte este: {0} km", dist);*/
        }
    }
}
