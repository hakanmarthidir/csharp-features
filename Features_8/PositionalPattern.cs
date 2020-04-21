using System;
using System.Collections.Generic;
using System.Text;

namespace Features_8
{

    public class MyTriangle
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public MyTriangle(int x, int y, int z) => (X, Y, Z) = (x, y, z);

        public void Deconstruct(out int x, out int y, out int z) =>
            (x, y, z) = (X, Y, Z);
    }

    public class PositionalPattern
    {

        public static string WhichTriangleIsMine(MyTriangle triangle) => triangle switch
        {            
            var (x, y, z) when x == y && y == z => "Equilateral triangle",
            var (x, y, z) when x == y || y == z ||x == z => "Isosceles triangle",
            var (x, y, z) when x != y && y != z && x != z => "Scalene triangle",
            _ => ""
        };

    }
}
