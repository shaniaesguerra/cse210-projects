public class Address
{
    private string _street;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _isInUsa;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _isInUsa = this.IsInUSA();
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else return false;
    }
    
    public string GetAddress()
    {
        return $"{_street} {_city}, {_stateOrProvince}, {_country}";
    }
}