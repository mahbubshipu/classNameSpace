using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNameSpace
{
    public class Bottle
    {
        public static int bottleSerialNumber = 0;
        public string BottleColor { get; private set; }
        public double BottleHeight { get; private set; }
        public string Water { get; private set; }
        protected internal string MaterialName { get; set;}
        public readonly int MaximumCapacity;

        public const string Shape="Cylindar";


        //Copy Constructor
        public Bottle(Bottle bottle)
        {
            BottleColor = bottle.BottleColor;
            BottleHeight = bottle.BottleHeight;
            Water = bottle.Water;
            MaterialName = bottle.MaterialName;
            MaximumCapacity = 250;
           
        }
        public Bottle(string color,double height)//Constructor..
        {
            BottleColor = color;
            BottleHeight = height;
            MaterialName = "Plastic";
            bottleSerialNumber++;
        }
        //public Bottle(double height)
        //{
        //    BottleColor = null;
        //    BottleHeight = height;
        //}
        FileStream filestream;//Finalizer/Destructor.
        ~Bottle()
        {

            filestream.Dispose();
        }
        public void AddGlass()
        {
            //MaximumCapacity = 250;
        }
    }
}
