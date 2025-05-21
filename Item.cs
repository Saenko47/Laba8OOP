using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    public enum ShapeType { Rectangle, Sphere, Cylinder, Cube }
    internal class Item
    {
        Random random = new Random();
       
        public ShapeType  shape;
        public double Length;
        public double Width;
        public double Height;
        public string name;
        public double weight;
        public double space;
        public Item(string name, ShapeType shape, double weight, double Length, double Width, double Height)
        {
            
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;

            this.name = name;
            this.shape = shape; 
            this.weight = weight;
            this.space = GetSpace();
        }
        public Item()
        {
            this.name = "No name";
            this.weight = random.Next(1, 11);
            this.Length = random.Next(1, 21);
            this.Width = random.Next(1, 21);
            this.Height = random.Next(1, 21);
            this.shape = (ShapeType)random.Next(Enum.GetValues(typeof(ShapeType)).Length);
            this.space = GetSpace();
        }
        public double GetSpace()
        {
            switch (shape)
            {
                case ShapeType.Rectangle:
                    return Length * Width * Height;


                case ShapeType.Sphere:
                    double radiusSphere = Length / 2;
                    return (4.0 / 3.0) * Math.PI * Math.Pow(radiusSphere, 3);
                   

                case ShapeType.Cylinder:
                    double radiusCylinder = Length / 2;
                    return Math.PI * Math.Pow(radiusCylinder, 2) * Height;
                    

                case ShapeType.Cube:
                    return Math.Pow(Length, 3);
                   

                default:
                    return 0;
                               }
        }
        public override string ToString()
        {

            return $"item name:{name}, space {space:F2}, width:{Width}, Shape: {shape}";
        }
    }
}
