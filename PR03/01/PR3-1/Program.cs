using System;
using System.Text.RegularExpressions;

namespace PR3_1
{
  class Program
  {
    static bool IsPhone(string s)
    {
      return Regex.IsMatch(s, "[+]??\\d[(]??\\d{3}[)]??\\d{3}[-]??\\d{2}[-]??\\d{2}");
    }

    static bool IsZip(string s)
    {
      return Regex.IsMatch(s, "[\\w._-]+@[\\w._-]+");
    }
      static void Main(string[] args)
    {
      string s = Console.ReadLine();
      Console.Write(IsPhone(s) ?"IsPhone ":"IsntPhone ");
      Console.Write(IsZip(s) ? "IsZip " : "IsntZip ");
    }
  }
}
