public interface IRoom {
    int number;
    int floor;
    int capacity;
    string name;
    string type;
    void AddRoom(IRoom room);
    void RemoveRoom(IRoom room);
    void AddDepartment(Department department);
    void RemoveDepartment(Department department);
    void AddBuilding(IBuilding building);
    void RemoveBuilding(IBuilding building);
    void AddFloor(IFloor floor);
    void RemoveFloor(IFloor floor);
}