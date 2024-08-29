using System.Net.Http.Headers;

namespace SSDll.models.Orders;

public class OrderLine
{
    private ProductHeaderValue _product;
    private int _count;
}