using System;

class Customer
{
    private string _name;

    private Address _address;

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetName() => _name;
    public void SetName(string value) => _name = value;

}