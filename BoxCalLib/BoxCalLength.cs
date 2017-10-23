using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxCalLib
{
    public class BoxCalLength
    {
        /// <summary>
        /// Private instanser af typen double.
        /// </summary>

        private double volume;
        private double width;
        private double height;
        private double length;


        /// Properties af de private instanser.
        public double Volume { get => volume; set => volume = value; }
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public double Length { get => length; set => length = value; }



        /// <summary>
        /// Default konstruktør
        /// </summary>
        public BoxCalLength()
        {
            
        }

        public BoxCalLength(double volume, double width, double height)
        {
            this.volume = volume;
            this.width = width;
            this.height = height;
            GetLength();

        }

        public double GetLength()
        {
            Length = volume / (width * height);
            return Length;
        }

        public override string ToString()
        {
            return $"Længden er: {Length}";
        }
    }
}
