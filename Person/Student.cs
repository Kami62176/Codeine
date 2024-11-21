using System;

public class Student : IPerson
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public string Address { get; set; }
  public DateTime DateOfBirth { get; set; }

  // Student-specific properties
  public string StudentId { get; set; }
  public double GPA { get; set; }
  public string Major { get; set; }

  public Student()
  {
    // Default constructor
  }

  public Student(string firstName, string lastName, DateTime dateOfBirth)
  {
    FirstName = firstName;
    LastName = lastName;
    DateOfBirth = dateOfBirth;
    Age = CalculateAge();
  }

  public string GetFullName()
  {
    return $"{FirstName} {LastName}";
  }

  public bool IsAdult()
  {
    return Age >= 18;
  }

  public int CalculateAge()
  {
    var today = DateTime.Today;
    var age = today.Year - DateOfBirth.Year;
    if (DateOfBirth.Date > today.AddYears(-age))
    {
      age--;
    }
    return age;
  }

  public void UpdateContactInfo(string email, string phone, string address)
  {
    Email = email;
    PhoneNumber = phone;
    Address = address;
  }
}
