public abstract class IEquipment
{
    public string Name { get; set; }

    IEquipment(string name){
        this.Name = name
    }
}