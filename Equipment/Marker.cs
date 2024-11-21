public class Marker : IEquipment
{
    public string Color {get; set;} 
    public Marker(string name, string color) : base(name)
    {
        this.Color = color;
    }
}