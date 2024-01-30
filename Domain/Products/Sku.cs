namespace Domain.Products;

//Stocl Keeping Unit
public record Sku
{
    private const int DefaultLength = 15;
    public string Value { get; init; }
    private Sku(string value) 
    {
        Value = value;
    }
    public static Sku? Create(string value)
    {
        if (string.IsNullOrEmpty(value)) 
        {
            return null;
        }
        if(value.Length != DefaultLength)
        {
            return null;
        }

        return new Sku(value);
    }
}