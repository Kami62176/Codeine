public class Box:IEquipment
{
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public Box(string name, int length, int width, int height) : base(name)
    {
        this.Length = length;
        this.Width = width;
        this.Height = height;
    }
}