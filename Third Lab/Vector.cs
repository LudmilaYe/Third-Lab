using System;

namespace Third_Lab
{
    class Vector
    {
        private double _x;
        private double _y;

        public Vector(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public static Vector operator +(Vector first, Vector second)
        {
            return new Vector(first._x + second._x, first._y + second._y);
        }

        public static Vector operator -(Vector first, Vector second)
        {
            return new Vector(first._x - second._x, first._y - second._y);
        }

        public static double operator *(Vector first, Vector second)
        {
            return first._x * second._x + first._y * second._y;
        }
        // Это векторное произведение (нет идей, какой здесь ещё знак сделать)
        public static double operator ^(Vector first, Vector second)
        {
            return first._x * second._y - first._y * second._x;
        }

        public double Length => Math.Sqrt((_x * _x) + (_y * _y)); 
    }
}
