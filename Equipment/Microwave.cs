public class Microwave:IEquipment{
    public int wattage{get;set;}
    public Microwave(int wattage,string name):base(name){
        this.wattage = wattage;
    }
}