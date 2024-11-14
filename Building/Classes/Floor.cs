public class Floor : IFloor {
    public int number;
    double structuralIntegrity;
    public List<IRoom> rooms;
    public Building buildings;

    public void AddRoom(IRoom room) {
        rooms.Add(room);
    }
    public void RemoveRoom(IRoom room) {
        rooms.Remove(room);
    }
    public void AddBuilding(IBuilding building) {
        buildings.Add(building);
    }
}