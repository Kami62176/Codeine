public abstract class WhiteBoard : IEquipment
{
    public float Width {get; set;}
    public float Height {get; set;}
    public WhiteBoard(string name, float width, float height) : base(name){
        Width = width;
        Height = height;
    }
}