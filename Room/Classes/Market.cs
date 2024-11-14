public class Market : Commons, IRoom {
    public List<IEquipment> equipments;
    public List<Department> departments;
    public Building buildings;
    public Floor floors;

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
}