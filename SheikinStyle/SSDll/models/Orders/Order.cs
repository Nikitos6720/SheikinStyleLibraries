using SSDll.models.Orders.OrderStates;
using SSDll.models.Users;

namespace SSDll.models.Orders;

public class Order
{
    private Guid _id;
    private DateTime _startDate;
    private DateTime _endDate;
    private List<OrderLine> _lines;
    private IOrderState _state;
    private User _employee;
    private List<OrderEvent> _events;

    /// <inheritdoc cref="_id"/> 
    public Guid Id => _id;
}