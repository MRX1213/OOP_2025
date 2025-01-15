using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OOP_NET1
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public string VIN;
        public string interiorColor;
        public string exteriorColor;
        public Car(string make, string model, int year, string VIN, string interiorColor, string exteriorColor)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.VIN = VIN;
            this.interiorColor = interiorColor;
            this.exteriorColor = exteriorColor;
        }
    }
}
