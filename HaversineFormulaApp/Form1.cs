using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace HaversineFormulaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lat1 = latitudine1.Text;
            string lon1 = longitudine1.Text;
            string lat2 = latitudine2.Text;
            string lon2 = longitudine2.Text;

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
            double dist = GreatCircleDistance(ParseToString(lat1), ParseToString(lon1), ParseToString(lat2), ParseToString(lon2));

            distanta.Text = dist.ToString("0.00") + " km";

            /*radLat1.Text = DegreesToRadians(ParseToString(lat1)).ToString();
            radLong1.Text = DegreesToRadians(ParseToString(lon1)).ToString();

            radLat2.Text = DegreesToRadians(ParseToString(lat2)).ToString();
            radLong2.Text = DegreesToRadians(ParseToString(lon2)).ToString();*/


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.hide();
            Aria_Triunghiului f2 = new Aria_Triunghiului(); //this is the change, code for redirect  
            f2.ShowDialog();
        }
    }
}
