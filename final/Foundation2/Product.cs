public class Product
{
  private string _name;
  private string _product_id;
  private double _price;
  private int _quantity;

  public Product(string name, string product_id, double price, int quantity)
  {
    _name = name;
    _product_id = product_id;
    _price = price;
    _quantity = quantity;
  }

  public string GetName()
  {
    return _name;
  }

  public string GetProductId()
  {
    return _product_id;
  }

  public double GetTotalCost()
  {
    return _price * _quantity;
  }
}