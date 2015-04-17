using System;
using Ploeh.AutoFixture;

namespace autofixturetest
{
  class Program
  {
    static void Main(string[] args)
    {
      var fixture = new Fixture();
      Console.WriteLine(fixture.Create<string>());

      var fixture2 = new Fixture();
      Console.WriteLine(fixture2.Create<string>());

      Console.WriteLine("press key to close");
      Console.ReadLine();
    }
  }
}
