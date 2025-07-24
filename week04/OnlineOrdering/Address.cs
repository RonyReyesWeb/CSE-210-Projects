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

    public bool IsInUSA()
    {
        return _country != null && _country.Trim().ToUpper() == "USA";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_province}\n{_country}";
    }

    public string GetStreet() => _street;
    public void SetStreet(string value) => _street = value;

    public string GetCity() => _city;
    public void SetCity(string value) => _city = value;

    public string GetProvince() => _province;
    public void SetProvince(string value) => _province = value;

    public string GetCountry() => _country;
    public void SetCountry(string value) => _country = value;
}
