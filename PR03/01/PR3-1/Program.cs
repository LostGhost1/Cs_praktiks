using System;
using System.Text.RegularExpressions;

namespace PR3_1
{
  class Program
  {
    static bool IsPhone(string s)
    {
      return Regex.IsMatch(s, @"[+]??\d([(]\d{3}[)]|\d{3})\d{3}([-]\d{2}[-]\d{2}|\d{4})");
    }
    static bool IsPhoneShort(string s)
    {
      return Regex.IsMatch(s, @"[+]??\d{11}");
    }
    static bool IsPhoneLong(string s)
    {
      return Regex.IsMatch(s, @"[+]??\d[(]\d{3}[)]\d{3}[-]\d{2}[-]\d{2}");
    }

    static string ReformatPhone(string s)
    {
      return String.Concat(s[0],s[1],'(', s[2],s[3],s[4],')',s[5],s[6],s[7],'-',s[8],s[9],'-',s[10],s[11]);
    }
    static bool IsZip(string s)
    {
      return Regex.IsMatch(s, @"[\w._-]+@[\w._-]+");
    }
    static void Main(string[] args)
    {
      string s = Console.ReadLine();
      Console.Write(IsPhone(s) ?"IsPhone ":"IsntPhone ");
      if (IsPhoneShort(s) && !IsPhoneLong(s)) 
        Console.WriteLine(ReformatPhone(s));
      Console.Write(IsZip(s) ? "IsZip " : "IsntZip ");
    }
  }
}
