public abstract class Item : IEquipment
{
    public float cost;
    public int quantity;
    public Item(string name, float cost, int quantity):base(name){
        this.cost = cost;
        this.quantity = quantity;
    }
}