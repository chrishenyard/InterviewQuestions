namespace Questions.Topics
{
    public class Point3D
    {
        public Point3D(double x, double y, double z) => (X, Y, Z) = (x, y, z);

        public double X { get; set; }
        public double Y { get; }
        public double Z { get; }

        public override bool Equals(object? other)
        {
            if (other == null) return false;

            if (other is not Point3D comparer) return false;

            return X == comparer.X && Y == comparer.Y && Z == comparer.Z;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y, Z);
        }
    }
}