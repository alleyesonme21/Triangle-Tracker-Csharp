using System;
using Triangle;

namespace UserCollection
{
  public class Program
  {
public static void Main()
{
  Console.WriteLine("Give us Side A: ");
  string stringSideA = Console.ReadLine();
  int sideA = int.Parse(stringSideA);

  Console.WriteLine("Give us Side B: ");
  string stringSideB = Console.ReadLine();
  int sideB = int.Parse(stringSideB);

  Console.WriteLine("Give us Side C: ");
  string stringSideC = Console.ReadLine();
  int sideC = int.Parse(stringSideC);

  TriangleTracker tri = new TriangleTracker();
  string output = tri.IsTriangleTracker(sideA, sideB, sideC);
  Console.WriteLine(output);

}
  }
}