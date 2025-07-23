using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Dynamic;
using System.Runtime.CompilerServices;

class Address
{
    private string _street;
    private string _city;
    private string _province;
    private string _country;


    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }

    public bool IsInUSA()
    {
        return _country != null && _country.Trim().ToUpper() == "USA";
    }
    
    //Add public getters/setters as example for my own reference
    public string GetStreet() => _street;
    public void SetStreet(string value) => _street = value;

}