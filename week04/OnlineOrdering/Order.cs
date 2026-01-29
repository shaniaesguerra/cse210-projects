public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer = null;

    public Order(List<Product> productList, Customer customer)
    {
        _productList = productList;
        _customer = customer;
    }

    public double GetTotalPrice()
    {
        double total = 0;

        foreach (Product p in _productList)
        {
            total += p.GetTotalCost();
        }

        return total + this.GetShippingCost();
    }

    private double GetShippingCost()
    {
        double usaShipCost = 5.0;
        double otherShipCost = 35.0;

        if (_customer.IsCustomerInUSA())
        {
            return usaShipCost;
        }
        else return otherShipCost;
    }

    public void MakePackingLabel()
    {
        foreach (Product p in _productList)
        {
            p.GetProductLabel();
        }
    }

    public void MakeShippingLabel()
    {
        _customer.GetShippingInfo();
    }
}