namespace DSD601Assessment2.Interfaces
{
    public interface IPizza
    {
        string Description { get; set; }
        string Flavor { get; set; }
        List<string> Ingredients { get; set; }
        List<string> Prices { get; set; }
    }
}