public abstract class Chair : IEquipment
{
    public int legs;
    public Chair(string name, int legs) : base(name){
        this.legs = legs;
    }
}