using System;

namespace Third_Lab
{
    class Vector
    {
        private double _x;
        private double _y;
        private double _z;

        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first._x + second._x, first._y + second._y, first._z + second._z);
        }

        public static Vector operator -(Vector first, Vector second)
        {
            return new Vector(first._x - second._x, first._y - second._y, first._z - second._z);
        }

        public static double operator *(Vector first, Vector second)
        {
            return first._x * second._x + first._y * second._y + first._z * second._z;
        }
        // Это векторное произведение (нет идей, какой здесь ещё знак сделать)
        public static Vector operator ^(Vector first, Vector second)
        {
            return new Vector(first._y * second._z - first._z * second._y, -(first._z * second._z - first._z * second._x), first._x * second._y - first._y * second._x);
        }

        public double Length => Math.Sqrt((_x * _x) + (_y * _y) + (_z * _y)); 
    }
}
