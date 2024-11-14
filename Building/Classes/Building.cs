public class Building : IBuilding {
    public string name;
    public string address;
    public List<IRoom> rooms;
    public List<IDepartment> departments;
    public List<IEmployee> employees;
    public List<IEquipment> equipments;
    public List<IBuilding> buildings;
    public List<IFloor> floors;
    
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
    
    public void AddEmployee(IEmployee employee) {
        employees.Add(employee);
    }
    
    public void RemoveEmployee(IEmployee employee) {
        employees.Remove(employee);
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