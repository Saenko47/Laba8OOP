using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba8OOP
{
    internal class Bag
    {
        public event Action BagFull;
        Random random = new Random();
        string[] suitcaseBrands = new string[]
{
    "TravelPro",
    "SkyWay",
    "Valizo",
    "FlyCase",
    "WanderLux",
    "AeroPack",
    "RoadMate",
    "Voyager",
    "BagMaster",
    "TURBOX"
};
        public string[] suitcaseColors = new string[]
{
    "Чорний",
    "Сірий",
    "Синій",
    "Червоний",
    "Зелений",
    "Жовтий",
    "Фіолетовий",
    "Помаранчевий",
    "Білий",
    "Бордовий"
};
        public double Length;
        public double Width;
        public double Height;
        public string bagBrand;
        public string bagColor;
        public Item[] items = new Item[0];
        public double weight { get; private set; }
         public double space => GetSpace();
        public double usedSpace;
        public Bag()
        {
            this.bagBrand = suitcaseBrands[random.Next(0, suitcaseBrands.Length)];
            this.bagColor = suitcaseColors[random.Next(0, suitcaseColors.Length)];
            this.weight = 0;
            this.Length = 0;
            this.Width = 0;
            this.Height = 0;
           this.usedSpace = 0;
            this.items = new Item[0];

        }

        public Bag(double Length, double Width, double Height)
        {
            this.bagBrand = suitcaseBrands[random.Next(0, suitcaseBrands.Length)];
            this.bagColor = suitcaseColors[random.Next(0, suitcaseColors.Length)];
            this.weight = 0;
            this.Length = Length;
            this.Width = Width;
            this.Height = Height;
            this.usedSpace = 0;
            this.items = new Item[0];
        }
       
        public Item this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Length) throw new IndexOutOfRangeException();
                return items[index];
            }
            set { items[index] = value; }
        }
        public double GetSpace()
        {
            return Length * Width * Height;
        }
        public void IsBagFull()
        {
            ShowAllItems();
            throw new InvalidOperationException("Cannot add item: bag is full.");



        }
        public void ShowAllItems()
        {
            Console.WriteLine("All items in bag:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"Item {i + 1}: {items[i].name}, weight: {items[i].weight}, space: {items[i].space:F2}");
            }
            Console.WriteLine($"Total weight: {weight}");
            Console.WriteLine($"{space - usedSpace:F2} - space left");
        }
        public void PutSomethingIn(params Item[] item)
        {
            
            int oldItemLen = items.Length;
            Item[] temp = new Item[oldItemLen + item.Length];
            Array.Copy(items, temp, oldItemLen);
            for (int i = 0; i < item.Length; i++)
            {
                if (item[i].space + usedSpace > space) { BagFull?.Invoke(); return; }
                temp[oldItemLen + i] = item[i];
                weight += item[i].weight;
                usedSpace += item[i].space;
            }
            items = temp;


        }

        
    }
}
