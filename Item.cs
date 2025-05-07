using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    internal class Item
    {
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
        public string name;
        public double weight;
        public double space;
        public Item(double weight, double space)
        {
           this.name = randomItemNames[new Random().Next(0, randomItemNames.Length)];
            this.weight = weight;
            this.space = space;
        }
        public Item()
        {
            this.name = randomItemNames[new Random().Next(0, randomItemNames.Length)];
            this.weight = new Random().Next(1,11);
            this.space = new Random().Next(50,751);
        }
    }
}
