using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HaversineFormulaApp
{
    public partial class Aria_Triunghiului : Form
    {

        public Aria_Triunghiului()
        {
            InitializeComponent();

        }


        private void button_ok_Click(object sender, EventArgs e)
        {
            string lat1 = textBox_lat1.Text;
            string lon1 = textBox_long1.Text;
            string lat2 = textBox_lat2.Text;
            string lon2 = textBox_long2.Text;
            string lat3 = textBox_lat3.Text;
            string lon3 = textBox_long3.Text;


            double ParseToString(string str)
            {
                const string Deg = "°";
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
            double a = GreatCircleDistance(ParseToString(lat1), ParseToString(lon1), ParseToString(lat2), ParseToString(lon2));
            double b = GreatCircleDistance(ParseToString(lat1), ParseToString(lon1), ParseToString(lat3), ParseToString(lon3));
            double c = GreatCircleDistance(ParseToString(lat2), ParseToString(lon2), ParseToString(lat3), ParseToString(lon3));

            double R = 6371;
            double s = (a + b + c) / 2;
            double ExcesSfeirc =
               4 * Math.Atan(Math.Sqrt(Math.Abs(Math.Tan(s / 2) * Math.Tan((s - a) / 2) * Math.Tan((s - b) / 2) * Math.Tan((s - c) / 2))));
            double Aria = Math.Pow(R, 2) * ExcesSfeirc;
            Aria = Aria / Math.Pow(10, 7);
            String.Format("{0:0.00}", Aria.ToString());
            textBox_aria.Text = Aria.ToString("0.00") + " *10^7 km^2";
            // textBox_aria.Text = String.Format("{0:0.00}", Aria.ToString()) + "*10^7 km^2";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
