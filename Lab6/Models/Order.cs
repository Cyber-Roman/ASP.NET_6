namespace Lab6.Models;

public class Order
{
    public int OrderQuantity { set; get; }
    public List<string> OrderName { set; get; } = new List<string>();

    public Order()
    {
        OrderQuantity = 0;
        OrderName.Add("None");
    }

    public Order(int orderQuantity, List<string> orderName)
    {
        OrderQuantity = orderQuantity;
        OrderName = orderName;
    }
}