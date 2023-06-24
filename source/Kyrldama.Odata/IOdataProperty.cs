namespace Kyrldama.Odata
{
    public interface IOdataProperty
    {
        string Name { get; set; }
        string Serialize();
    }

    public interface IOdataProperty<T> : IOdataProperty
    {
        T Value { get; set; }
    }
}
