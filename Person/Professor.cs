using System;

public class Professor : IPerson
{
  public string FirstName { get; set; }
  public string LastName { get; set; }
  public int Age { get; set; }
  public string Email { get; set; }
  public string PhoneNumber { get; set; }
  public string Address { get; set; }
  public DateTime DateOfBirth { get; set; }

  public string Department { get; set; }
  public string OfficeNumber { get; set; }
  public string Title { get; set; }
  public string ResearchArea { get; set; }

  public Professor(string firstName, string lastName, DateTime dateOfBirth)
  {
    FirstName = firstName;
    LastName = lastName;
    DateOfBirth = dateOfBirth;
    Age = CalculateAge();
  }

  public string GetFullName()
  {
    return $"{Title} {FirstName} {LastName}";
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
