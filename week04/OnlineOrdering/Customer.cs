using System;

class Customer
{
    private string _name;

    private Address _address;

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

}