class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string Name()
    {
        return _name;
    } 
    public string ProductId()
    {
        return _productId;
    } 
    public decimal TotalCost()
    {
       return _price * _quantity;
    } 
    public override string ToString()
    {
        return $"{_name} (ID: {_productId})";
    }
} 