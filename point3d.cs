public struct Point3D
{
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Z { get; private set; }

    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public void Translate(int x, int y, int z)
    {
        X += x;
        Y += y;
        Z += z;
    }

    public override string ToString()
    {
        return $"({X}, {Y}, {Z})";
    }
}