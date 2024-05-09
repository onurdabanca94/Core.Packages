namespace Core.Persistance.Dynamic;

public class Filter
{
    public string Field { get; set; } //Vites
    public string? Value { get; set; } //Otomatik
    public string Operator { get; set; } //İçinde geçen eşittir
    public string? Logic { get; set; } // And-Or

    public IEnumerable<Filter>? Filters { get; set; } //Filter içinde filter gibi
    public Filter()
    {
        Field = string.Empty;
        Operator = string.Empty;
    }
    public Filter(string field, string @operator)
    {
        Field = field;
        Operator = @operator;
    }
}
