using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} (ID: {_id})";
    }

    public string GetName() => _name;
    public void SetName(string value) => _name = value;
}
