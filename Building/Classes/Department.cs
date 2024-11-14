public class Department {
    public string name;
    public string description;
    public List<IEmployee> employees;
    public List<IRoom> rooms;
    public List<IEquipment> equipments;
    public List<IBuilding> buildings;
    public List<IFloor> floors;
    
    public void AddEmployee(IEmployee employee) {
        employees.Add(employee);
    }
    
    public void RemoveEmployee(IEmployee employee) {
        employees.Remove(employee);
    }
    
    public void AddRoom(IRoom room) {
        rooms.Add(room);
    }
    
    public void RemoveRoom(IRoom room) {
        rooms.Remove(room);
    }
    
    public void AddEquipment(IEquipment equipment) {
        equipments.Add(equipment);
    }
    
    public void RemoveEquipment(IEquipment equipment) {
        equipments.Remove(equipment);
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