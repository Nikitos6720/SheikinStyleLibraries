namespace SSDll.models.Products;

public class Product
{
    private Guid _id;
    private string _name;
    private string _description;
    private decimal _price;
    private Category _category;
    private AdditionalContent _media;

    public Guid Id => _id;

    public string Name
    {
        get => _name;
        set => _name = string.IsNullOrWhiteSpace(value) ? value : "Not set";
    }

    public string Description
    {
        get => _description;
        set => _description = value;
    }

    public decimal Price
    {
        get => _price;
        set => _price = (value > 0) ? value : 1.0m;
    }

    public Category Category
    {
        get => _category;
        set => _category = value ?? new Category();
    }

    public AdditionalContent Media
    {
        get => _media;
        set => _media = value ?? new AdditionalContent();
    }
}