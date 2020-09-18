using System;
using System.IO;
namespace PR3_2
{
  class Program
  {
    static void Main(string[] args)
    {
      StreamReader sr = new StreamReader("boot.ini");
      StreamWriter sw = new StreamWriter("boot - utf7.txt", false, System.Text.Encoding.UTF7);
      sw.WriteLine(sr.ReadToEnd());
      sw.Close();
      sr.Close();
    }
  }
}
