using System;

namespace Triangle
{
  public class TriangleTracker
  {
    
    public string IsTriangleTracker(int sideA, int sideB, int sideC) 
    {
      if (sideA+sideB < sideC || sideB+sideC < sideA  || sideC + sideA < sideB) // not Triangle
      {
        return ("Not a Triangle");
      }
      else if (sideA == sideB && sideB == sideC && sideC == sideA) // Equilateral
      {
        return ("This is an Equilateral Triangle");
      } 
      else if (sideA == sideB || sideB == sideC || sideC == sideA) // Isosceles
      {
        return ("This is an Isoceles triangle");
      } 
      else if (sideA != sideB || sideB != sideC  || sideC != sideA) // scalene
      {
        return ("This is a Scalene Triangle");
      }
      else
      {
        return ("How did you end up here?");
      }
    }
  }
}

