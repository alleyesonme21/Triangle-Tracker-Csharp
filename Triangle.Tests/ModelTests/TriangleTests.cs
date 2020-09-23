using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]

    public void IsTriangle_Equilateral_true()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsTriangleTracker(3, 3, 3));
    }
    [TestMethod]
    public void isTriangle_Isoceles_true()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsTriangleTracker(2, 2, 3));
    }
    [TestMethod]
    public void isTriangle_Scalene_true()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsTriangleTracker(100, 123, 232));
    }
    [TestMethod]
      public void isTriangle_NotTriangle_true() 
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.IsTriangleTracker(7, 6, 15));
    }
  }
}