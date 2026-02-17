public abstract class Product
{
    public int Id{get;set;}
    public string Name{get; set;}
    public double Price{get;set;}
}
public class ShoppingCart<T> where T : Product
{
    private Dictionary<T, int> _cartItems = new Dictionary<T, int>();
    public void AddToCart(T product, int quantity)
    {
        
    }
}