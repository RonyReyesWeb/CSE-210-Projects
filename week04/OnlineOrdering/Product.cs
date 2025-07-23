using System;
using System.Reflection.Metadata.Ecma335;

class Product
{
    public string Name { get; set; }
    public string _product { get; set; }
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public void Cost(int Total_Cost)
    {
        // Total_Cost = Price  * Quantity 
    }
}