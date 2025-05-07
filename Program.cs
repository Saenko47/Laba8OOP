namespace Laba8OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Bag bag = new Bag(70.0, 40.0, 30.0);
            bag.BagFull += bag.IsBagFull;
            Item[] items = new Item[5];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = new Item(); 
            }
            bag.PutSomethingIn(items);
            bag.ShowAllItems();
        }
        
    }
}
