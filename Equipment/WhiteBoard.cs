public abstract class WhiteBoard : IEquipment
{
    public float Width {get; set;}
    public float Height {get; set;}
    
    public WhiteBoard(string name) : base(name){
        
    }
}