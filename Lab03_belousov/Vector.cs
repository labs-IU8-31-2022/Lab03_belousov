using System.Runtime.Intrinsics;

namespace Lab03_belousov;

public class Vector
{
    private double _X;
    private double _Y;
    private double _Z;
    public double X => _X;
    public double Y => _Y;
    public double Z => _Z;
    public Vector(double x, double y, double z) => (_X, _Y, _Z) = (x, y, z);

    public static Vector operator +(Vector v1, Vector v2) { return new Vector(v1._X + v2._X, v1._Y + v2._Y, 
        v1._Z + v2._Z); }

    public static Vector operator *(Vector v, Vector v2) { return new Vector(v._X * v2._X, v._Y * v2._Y,
        v._Z * v2._Z); }

    public static Vector operator *(Vector v, double num)
    {
        v._X *= num;
        v._Y *= num;
        v._Z *= num;
        return v;
    }

    private double Length()
    {
        return Math.Sqrt(Math.Pow(this._X, 2) + Math.Pow(this._Y, 2) + Math.Pow(this._Z, 2));
    }

    public static bool operator >(Vector v1, Vector v2)
    {
        return v1.Length() > v2.Length();
    }

    public static bool operator <(Vector v1, Vector v2)
    {
        return !(v1 > v2);
    }
}