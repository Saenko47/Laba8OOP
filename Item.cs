using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    internal class Item
    {
        Random random = new Random();
        public string[] randomItemNames = new string[]
{
    "Toothbrush",
    "Shirt",
    "Laptop",
    "Passport",
    "Shoes",
    "Charger",
    "Towel",
    "Headphones",
    "Book",
    "Sunglasses"
};
        public double Length;
        public double Width;
        public double Height;
        public string name;
        public double weight;
        public double space;
        public Item(double weight, double space, double Length, double Width, double Height)
        {
           this.name = randomItemNames[random.Next(0, randomItemNames.Length)];
            this.weight = weight;
            this.space = GetSpace();
        }
        public Item()
        {
            this.name = randomItemNames[new Random().Next(0, randomItemNames.Length)];
            this.weight = random.Next(1, 11); 
            this.Length = random.Next(1, 21); 
            this.Width = random.Next(1, 21);
            this.Height = random.Next(1, 21);
            this.space = GetSpace();
        }
        public double GetSpace()
        {
            return Length * Width * Height;
        }
    }
}
