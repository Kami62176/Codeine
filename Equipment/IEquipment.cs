public abstract class IEquipment
{
    public string Name { get; set; }

    public IEquipment(string name){
        this.Name = name;
    } 
}