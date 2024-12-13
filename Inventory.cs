using System;
using System.Collections.Generic;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public int quantity { get; set; }

    public Product(int id, string name, int quantity)
    {
        this.id = id;
        this.name = name;
        this.quantity = quantity;
    }
}

class Inventory_Management
{
    private List<Product> products = new List<Product>();

    // Create a product
    public void addProduct()
    {
        Console.WriteLine("Enter your product id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your product name: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Enter your product quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        products.Add(new Product(id, name!, quantity));
        Console.WriteLine($"Your product named {name} is added.");
    }

    // Read a product
    public void readProduct()
    {
        Console.WriteLine("Enter your product id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.Find(p => p.id == id);
        if (product != null)
        {
            Console.WriteLine($"Product id: {product.id} \nProduct name: {product.name} \nProduct quantity: {product.quantity}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // Update a product
    public void UpdateProduct()
    {
        Console.WriteLine("Enter your product id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.Find(p => p.id == id);
        if (product != null)
        {
            Console.WriteLine("Enter new product name: ");
            product.name = Console.ReadLine()!;
            Console.WriteLine("Enter new product quantity: ");
            product.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your product named {product.name} is updated.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    // Delete a product
    public void DeleteProduct()
    {
        Console.WriteLine("Enter your product id: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Product? product = products.Find(p => p.id == id);
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine($"Your product named {product.name} is deleted.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Inventory_Management inventory = new Inventory_Management();
        while (true)
        {
            Console.WriteLine("\nEnter 1 to add a product");
            Console.WriteLine("Enter 2 to read a product");
            Console.WriteLine("Enter 3 to update a product");
            Console.WriteLine("Enter 4 to delete a product");
            Console.WriteLine("Enter 5 to exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    inventory.addProduct();
                    break;
                case 2:
                    inventory.readProduct();
                    break;
                case 3:
                    inventory.UpdateProduct();
                    break;
                case 4:
                    inventory.DeleteProduct();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
