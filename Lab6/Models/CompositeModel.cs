namespace Lab6.Models;

public class CompositeModel
{
    public CompositeModel()
    {
        User = new User();
        Order = new Order();
    }

    public CompositeModel(User user, Order order)
    {
        User = user;
        Order = order;
    }

    public User User { set; get; }
    public Order Order { set; get; }
}