public abstract class Table : IEquipment
{
    
    public int Legs {get; set;}

    public Table(string name, int legs) : base(name){
        this.Legs = legs;
    }
}