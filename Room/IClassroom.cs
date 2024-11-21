public class IClassroom : IRoom {
    public int number;
    public int floor;
    public int capacity;
    public string name;
    public string type;

    List<IEquipment> desks = new List<IEquipment>();
    List<IEquipment> chairs = new List<IEquipment>();
    List<IEquipment> whiteboards = new List<IEquipment>();

    List<IPerson> students = new List<IPerson>();
    List<IPerson> teachers = new List<IPerson>();
    List<IPerson> coaches = new List<IPerson>();

    List<IDepartment> departments = new List<IDepartment>();
    public Building building;
    
    public void AddEquipment(IEquipment equipment) {
        equipments.Add(equipment);
    }
    
    public void RemoveEquipment(IEquipment equipment) {
        equipments.Remove(equipment);
    }
    public void AddRoom(IRoom room) {
        rooms.Add(room);
    }
    
    public void RemoveRoom(IRoom room) {
        rooms.Remove(room);
    }
    
    public void AddDepartment(Department department) {
        departments.Add(department);
    }
    
    public void RemoveDepartment(Department department) {
        departments.Remove(department);
    }
    
    public void AddBuilding(IBuilding building) {
        buildings.Add(building);
    }
    
    public void RemoveBuilding(IBuilding building) {
        buildings.Remove(building);
    }
    
    public void AddFloor(IFloor floor) {
        floors.Add(floor);
    }
    
    public void RemoveFloor(IFloor floor) {
        floors.Remove(floor);
    }
}