using System;

namespace HelloWorldApp
{
    public class Car
    {
        string make;
        string model;
        int year;
        string VIN;
        string interiorColor;
        string exteriorColor;
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