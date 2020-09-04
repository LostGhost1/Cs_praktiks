using System;

namespace PR1_3
{
  public enum Genders : int { Male, Female, DeadInside };
  class Person
  {
    public string firstName;
    public string lastName;
    public int age;
    public Genders gender;
    public Person(string _firstName, string _lastName, int _age, Genders _gender)
    {
      firstName = _firstName;
      lastName = _lastName; age = _age;
      gender = _gender;
    }
    public override string ToString()
    {
      return firstName + " " + lastName + " (" + gender + "), age " + age;
    }
  }
  class Manager : Person
  {
    string phoneNumber;
    string officeLocation;
    public Manager(string _firstName, string _lastName, int _age, Genders _gender, string
    _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
    {
      phoneNumber = _phoneNumber; officeLocation =
      _officeLocation;
    }
    public override string ToString()
    {
      return base.ToString() + ", " + phoneNumber + ", " + officeLocation;
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Manager p = new Manager("Yusupov", "Konstantin", 18, Genders.DeadInside,"88005553535","Kaliningrad");
      Console.WriteLine(p.ToString());
    }
  }
}