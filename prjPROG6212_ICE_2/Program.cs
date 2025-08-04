using System.ComponentModel;

namespace prjPROG6212_ICE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] headings = { "Name", "Brand", "Inventory", "Price" };
            Products product = new Products("Free Range Jumbo Eggs","Alzu Eggs", 200, 45.96);
            Products product2 = new Products("Free Range Milk","Clover", 150, 35.50);
            Console.WriteLine("Product Details:");
            Console.WriteLine("Name: " + product["name"]);
            Console.WriteLine("Brand: " + product["brand"]);
            Console.WriteLine("Inventory: " + product["inventory"]);
            Console.WriteLine("Price: R" + product["price"]);
            product[2] = 490;
            Console.WriteLine("Updated Inventory of Free Range Jumbo Eggs: " + product["inventory"]);
            Console.WriteLine("\nProduct 2 Details:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(headings[i] + (i == 3? ": R" : ": ") +product2[i]);
            }
            Console.ReadLine();
           
           

        }
    }
}
