

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private const double DomesticShippingCost = 5.0;
    private const double InternationalShippingCost = 35.0;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double totalProductCost = 0;
        foreach (var product in _products)
        {
            totalProductCost += product.TotalCost();
        }

        double shippingCost = _customer.IsInUSA() ? DomesticShippingCost : InternationalShippingCost;
        return totalProductCost + shippingCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}