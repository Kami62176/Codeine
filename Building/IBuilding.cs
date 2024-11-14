public interface IBuilding {
    string name;
    string address;

    void AddRoom(IRoom room);
    void RemoveRoom(IRoom room);
    void AddDepartment(Department department);
    void RemoveDepartment(Department department);
    void AddEmployee(IEmployee employee);
    void RemoveEmployee(IEmployee employee);
    void AddEquipment(IEquipment equipment);
    void RemoveEquipment(IEquipment equipment);
    void AddBuilding(IBuilding building);
    void RemoveBuilding(IBuilding building);
    void AddFloor(IFloor floor);
    void RemoveFloor(IFloor floor);
    
}