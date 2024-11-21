public class Drink:Item{
    public string type{get;set;}

    public Drink(string name, string type, int quantity, float cost):base(name,cost,quantity){
        this.type = type;
    }
}