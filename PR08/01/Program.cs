using System;
using System.Threading;
namespace _01
{
  class Program
  {
    static void Counting()
    {
      for(int i = 0; i < 10; i++)
      {
        Console.WriteLine(i + " " + Thread.CurrentThread.ManagedThreadId);
        Thread.Sleep(10);
      }
    }
    static void Main(string[] args)
    {
      ThreadStart starter = new ThreadStart(Counting);
      Thread first = new Thread(starter);
      Thread second = new Thread(starter);
      first.Start();
      second.Start();
      first.Join(); 
      second.Join();
      Console.Read();
    }
  }
}
