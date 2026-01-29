using System.Security.AccessControl;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    public bool IsCustomerInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else return false;
    }
}