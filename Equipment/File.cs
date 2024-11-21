public class File: IEquipment
{
    public string Content{get;set;}

    public File(string name, string content):base(name){
        this.Content = content;
    }
}