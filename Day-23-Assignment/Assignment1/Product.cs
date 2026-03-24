using System;
using System.Collections.Generic;

namespace Assignment1
{
    public class Product
    {
        public int Id;
        public string Name;
        public double Price;
        public string Category;

    //     public static void Main(string[] args)
    //     {
    //         List<Product> P1 = new List<Product>();

    //         P1.Add(new Product { Id = 1, Name = "Laptop", Price = 50000, Category = "Electronics" });
    //         P1.Add(new Product { Id = 2, Name = "Mobile", Price = 20000, Category = "Electronics" });
    //         P1.Add(new Product { Id = 3, Name = "Shoes", Price = 1500, Category = "Fashion" });
    //         P1.Add(new Product { Id = 4, Name = "Watch", Price = 2500, Category = "Accessories" });
    //         P1.Add(new Product { Id = 5, Name = "Bag", Price = 1200, Category = "Fashion" });
    //         P1.Add(new Product { Id = 6, Name = "Pen", Price = 50, Category = "Stationery" });
    //         P1.Add(new Product { Id = 7, Name = "Book", Price = 300, Category = "Education" });
    //         P1.Add(new Product { Id = 8, Name = "Headphones", Price = 1800, Category = "Electronics" });
    //         P1.Add(new Product { Id = 9, Name = "Keyboard", Price = 900, Category = "Electronics" });
    //         P1.Add(new Product { Id = 10, Name = "Chair", Price = 3500, Category = "Furniture" });

    //         Console.WriteLine("All Products:");
    //         foreach (Product p in P1)
    //         {
    //             Console.WriteLine(p.Id + " " + p.Name + " " + p.Price + " " + p.Category);
    //         }

    //         Console.WriteLine("Products with Price > 1000:");
    //         foreach (Product p in P1)
    //         {
    //             if (p.Price > 1000)
    //             {
    //                 Console.WriteLine(p.Name + " - " + p.Price);
    //             }
    //         }

    //         Console.WriteLine();

    //         List<Product> ascList = new List<Product>(P1);

    //         for (int i = 0; i < ascList.Count - 1; i++)
    //         {
    //             for (int j = 0; j < ascList.Count - i - 1; j++)
    //             {
    //                 if (ascList[j].Price > ascList[j + 1].Price)
    //                 {
    //                     Product temp = ascList[j];
    //                     ascList[j] = ascList[j + 1];
    //                     ascList[j + 1] = temp;
    //                 }
    //             }
    //         }

    //         Console.WriteLine("Sorted by Price (Ascending):");
    //         foreach (Product p in ascList)
    //         {
    //             Console.WriteLine(p.Name + " - " + p.Price);
    //         }

    //         List<Product> descList = new List<Product>(P1);

    //         for (int i = 0; i < descList.Count - 1; i++)
    //         {
    //             for (int j = 0; j < descList.Count - i - 1; j++)
    //             {
    //                 if (descList[j].Price < descList[j + 1].Price)
    //                 {
    //                     Product temp = descList[j];
    //                     descList[j] = descList[j + 1];
    //                     descList[j + 1] = temp;
    //                 }
    //             }
    //         }

    //         Console.WriteLine();


    //         Console.WriteLine("Sorted by Price (Descending):");
    //         foreach (Product p in descList)
    //         {
    //             Console.WriteLine(p.Name + " - " + p.Price);
    //         }

    //         Console.WriteLine();


    //         Console.WriteLine("Removing product with Id = 3");

    //         Product productToRemove = null;

    //         foreach (Product p in P1)
    //         {
    //             if (p.Id == 3)
    //             {
    //                 productToRemove = p;
    //                 break;
    //             }
    //         }

    //         if (productToRemove != null)
    //         {
    //             P1.Remove(productToRemove);
    //         }

    //         Console.WriteLine();


    //         Console.WriteLine("Products after removal:");
    //         foreach (Product p in P1)
    //         {
    //             Console.WriteLine(p.Id + " " + p.Name + " " + p.Price + " " + p.Category);
    //         }
    //     }
    }
}