using System;
using System.Collections.Generic;
public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
         _customer = customer;

    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }

        if (_customer.ResidesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return label;
    }    
    
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}\n{_customer.GetAddress()}";
    }
        
}   
