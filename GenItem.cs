using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    internal class GenItem
    {
      
        public Item[] GenerateItem(int size)
        {
            Item[] items = new Item[size];
            for (int i = 0; i < size; i++)
            {
                string name = "Item" + (i + 1);
                ShapeType shape = (ShapeType)(i % Enum.GetValues(typeof(ShapeType)).Length);
                double weight = new Random().Next(1, 11);
                double length = new Random().Next(1, 21);
                double width = new Random().Next(1, 21);
                double height = new Random().Next(1, 21);
                items[i] = new Item(name, shape, weight, length, width, height);

            }
            return items;
        }
    }
}
