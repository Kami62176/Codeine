public interface IPerson
{
  string FirstName { get; set; }
  string LastName { get; set; }
  int Age { get; set; }
  string Email { get; set; }
  string PhoneNumber { get; set; }
  string Address { get; set; }
  DateTime DateOfBirth { get; set; }

  string GetFullName();
  bool IsAdult();
  int CalculateAge();
  void UpdateContactInfo(string email, string phone, string address);
}
