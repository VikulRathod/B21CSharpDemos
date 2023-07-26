Customer c = new Customer("Vishal");

//Console.WriteLine($"Customer Name : {c.CustomerName}");

foreach (Order order in c.Orders.Value)
{
    Console.WriteLine($"Order Id : {order.Id} Details : {order.OrderDetails}");
}


Console.ReadLine();

class Order
{
    public int Id { get; set; }
    public string OrderDetails { get; set; }
}
class Customer
{
    public string CustomerName { get; set; }

    #region Association

    //// public List<Order> Orders { get; set; } // independent child = aggregation
    //List<Order> _orders;
    //public Customer(List<Order> orders) // child depends on parent = composition
    //{
    //    _orders = orders;
    //}

    #endregion Association

    public Lazy<List<Order>> Orders { get; set; }

    public Customer(string name)
    {
        CustomerName = name;
        // Orders = GetOrders();
        Orders = new Lazy<List<Order>>(() => GetOrders());
    }

    public List<Order> GetOrders()
    {
        return new List<Order>()
        {
        new Order(){ Id = 1, OrderDetails = "Order 1"},
        new Order(){ Id = 2, OrderDetails = "Order 2"},
        new Order(){ Id = 3, OrderDetails = "Order 3"}
        };
    }
}