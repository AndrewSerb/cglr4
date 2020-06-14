namespace cglr4
{
    /// <summary>
    /// Represents a point in 3D space. Contains double floating point values.
    /// </summary>
    struct Point3D
    {
        public double X;
        public double Y;
        public double Z;

        /// <summary>
        /// Creates an instance of Point3D
        /// </summary>
        /// <param name="x"> X coordinate </param>
        /// <param name="y"> Y coordinate </param>
        /// <param name="z"> Z coordinate </param>
        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    /// <summary>
    /// Represents a model of an object in 3D space.
    /// </summary>
    struct PolygonalObject
    {
        /// <summary>
        /// Contains unique points, that the object consists of.
        /// </summary>
        public Point3D[] Points { get; set; }
        /// <summary>
        /// Contains information on how to draw triangles, that form the object.
        /// Point3D's coordinates in this array are used to store indexes of points from Poins array.
        /// Each Point3D in this array represents a triangle, formed with points from Points array, using indexes stored in coordinates of that Point3D object.
        /// </summary>
        public Point3D[] Indexes { get; set; }
        /// <summary>
        /// Translates the object to the position.
        /// </summary>
        /// <param name="dockpoint"> Point to translate the object to </param>
        public void Dock(Point3D dockpoint)
        {
            for (int i = 0; i < Points.Length; i++)
            {
                Points[i].X += dockpoint.X;
                Points[i].Y += dockpoint.Y;
                Points[i].Z += dockpoint.Z;
            }
        }
    }
}