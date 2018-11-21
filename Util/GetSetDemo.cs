using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SammaTestApp
{
    public class GetSetDemo
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        private double length;
        public double Length { get; set; }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            try
            {
                Guid id = new Guid();
                Console.WriteLine("length is: {0}", length);
                Console.WriteLine("width is: {0}", width);
                Console.WriteLine("Area is: {0}", GetArea());
            }
            catch (Exception e)
            {

            }
        }
    }
}
