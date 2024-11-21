public interface IFloor {
    int number;
    double structuralIntegrity;
    List<IRoom> rooms;
    List<IBuilding> buildings;
    void AddRoom(IRoom room);
    void RemoveRoom(IRoom room);
    void AddBuilding(IBuilding building);
    void RemoveBuilding(IBuilding building);
}