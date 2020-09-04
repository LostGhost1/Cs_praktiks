﻿using System;

namespace PR1_1
{
  public enum Genders : int { Male, Female, DeadInside };
  struct Person
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

  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Yusupov", "Konstantin", 18, Genders.DeadInside);
      Console.WriteLine(p.ToString());

      Console.ReadKey();
    }
  }
}
