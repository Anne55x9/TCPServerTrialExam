using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxCalLib
{
    public class BoxCalVol
    {
        /// <summary>
        /// Private instanser af typen double.
        /// </summary>

        private double volume;
        private double length;
        private double width;
        private double height;

        /// <summary>
        /// Properties af de private instanser.
        /// </summary>
        public double Volume { get => volume; set => volume = value; }
        public double Length { get => length; set => length = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        /// <summary>
        /// Default konstruktør.
        /// </summary>
        public BoxCalVol()
        {
            
        }

        /// <summary>
        /// Overloaded konstruktor med parametre length, width, height.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public BoxCalVol(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            GetVolume();

        }

      
        private double GetVolume()
        {
            Volume = length * width * height;
            return Volume;
        }

        public override string ToString()
        {
            return $"Volumen er: {Volume}";
        }
    }
}
