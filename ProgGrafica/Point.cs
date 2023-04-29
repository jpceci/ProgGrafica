using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace ProgGrafica
{
    class Point
    {
        public float x, y, z;
        public Point(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point operator +(Point a, Point b) => new Point(a.x + b.x, a.y + b.y, a.z + b.z);
        public static Point operator -(Point a, Point b) => new Point(a.x - b.x, a.y - b.y, a.z - b.z);
        public static Point operator *(Point a, Point b) => new Point(a.x * b.x, a.y * b.y, a.z * b.z);
        public static Point operator *(Point a, Matrix3 b) => new Point(
            a.x * b.M11 + a.y * b.M12 + a.z * b.M13,
            a.x * b.M21 + a.y * b.M22 + a.z * b.M23,
            a.x * b.M31 + a.y * b.M32 + a.z * b.M33);
    }
}
