namespace Laba8OOP
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {
                string name, shape;
                double weight, length, width, height;

                Bag bag = new Bag(70.0, 40.0, 30.0);
                GenItem genItem = new GenItem();
                Item[] items = genItem.GenerateItem(60);
                bag.BagFull += bag.IsBagFull;                  
                bag.PutSomethingIn(items);
                bag.ShowAllItems();
                while (true)
                {
                   
                    Console.WriteLine("Enter name of item,q - to exit");
                    name = Console.ReadLine();
                    if (name == "q") break;
                    Console.WriteLine("Enter shape of item");
                    if (Enum.TryParse<ShapeType>(Console.ReadLine(), out ShapeType shapeType))
                    {
                        shape = shapeType.ToString();
                    }
                    else
                    {
                        Console.WriteLine("Invalid shape type.");
                        continue;
                    }
                    Console.WriteLine("Enter weight of item");
                    if (!double.TryParse(Console.ReadLine(), out weight))
                    {
                        Console.WriteLine("Invalid weight.");
                        continue;
                    }
                    Console.WriteLine("Enter length of item");
                    if (!double.TryParse(Console.ReadLine(), out length))
                    {
                        Console.WriteLine("Invalid length.");
                        continue;
                    }
                    Console.WriteLine("Enter width of item");
                    if (!double.TryParse(Console.ReadLine(), out width))
                    {
                        Console.WriteLine("Invalid width.");
                        continue;
                    }
                    Console.WriteLine("Enter height of item");
                    if (!double.TryParse(Console.ReadLine(), out height))
                    {
                        Console.WriteLine("Invalid height.");
                        continue;
                    }
                    Item item = new Item(name, shapeType, weight, length, width, height);
                    bag.PutSomethingIn(item);
                    bag.ShowAllItems();
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (InvalidOperationException ex)
            {
              
                Console.WriteLine(ex.Message);
            }
            
        }
        
    }
}
