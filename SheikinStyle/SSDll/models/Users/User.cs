using SSDll.models.Orders;

namespace SSDll.models.Users;

/// <summary>
/// Abstract class of person which was written into system 
/// </summary>
public abstract class User
{
    /// <summary>
    /// ID of user's record
    /// </summary>
    protected Guid _id;

    /// <summary>
    /// Name of user
    /// </summary>
    protected string _name;

    /// <summary>
    /// User's contact list
    /// </summary>
    protected List<Contact> _contacts;

    /// <summary>
    /// User's order list
    /// </summary>
    protected List<Order> _orders;

    /// <summary>
    /// User's birthdate
    /// </summary>
    private DateTime _birthDate;

    /// <inheritdoc cref="_id"/>
    public Guid Id => _id;
}