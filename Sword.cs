using SharpGL;

namespace cglr4
{
	/// <summary>
	/// Represents a model of a sword in 3D space.
	/// </summary>
    class Sword
    {
        private PolygonalObject Blade;
        private PolygonalObject Guard;

		/// <summary>
		/// Creates an instance of this class.
		/// </summary>
        public Sword()
        {
			Blade = new PolygonalObject();
			Blade.Points = new Point3D[9]
			{
				new Point3D(0, 0, 0),			
				new Point3D(1.5, 0, 0),			
				new Point3D(0.25, 12.25, 0),	
				new Point3D(1.25, 12.25, 0),	

				new Point3D(0.75, 0, -0.25),	
				new Point3D(0.75, 0, 0.25),		
				new Point3D(0.75, 12.25, -0.15),
				new Point3D(0.75, 12.25, 0.15),	

				new Point3D(0.75, 13.5, 0)		
			};

			Blade.Indexes = new Point3D[12]
			{
				new Point3D(0, 2, 4),
				new Point3D(4, 2, 6),

				new Point3D(1, 3, 4),
				new Point3D(4, 3, 6),

				new Point3D(0, 2, 5),
				new Point3D(5, 2, 7),

				new Point3D(1, 3, 5),
				new Point3D(5, 3, 7),

				new Point3D(2, 6, 8),
				new Point3D(2, 7, 8),
				new Point3D(3, 6, 8),
				new Point3D(3, 7, 8)
			};
			Blade.Dock(new Point3D(-1.25, 0.25, 0));

			Guard = new PolygonalObject();
			Guard.Points = new Point3D[12]
			{
				new Point3D(0, 0.25, 0.3),	
				new Point3D(2, 0, 0),		
				new Point3D(3, 0, 0),		
				new Point3D(5, 0.25, 0.3),	
				new Point3D(5, 0.5, 0.3),	
				new Point3D(0, 0.5, 0.3),	

				new Point3D(0, 0.25, 0.7),	
				new Point3D(2, 0, 1),		
				new Point3D(3, 0, 1),		
				new Point3D(5, 0.25, 0.7),	
				new Point3D(5, 0.5, 0.7),	
				new Point3D(0, 0.5, 0.7)	
			};
			Guard.Indexes = new Point3D[4 * 2 + 4 + 2 + 3 * 2]
			{
				//wide side 1
				new Point3D(0, 1, 5),	
				new Point3D(5, 1, 2),	
				new Point3D(5, 2, 4),	
				new Point3D(2, 4, 3),	
				//wide side 2
				new Point3D(6, 7, 11),	
				new Point3D(11, 7, 8),	
				new Point3D(11, 8, 10),	
				new Point3D(8, 10, 9),	
				//top (near the blade) 
				new Point3D(5, 4, 10),	
				new Point3D(5, 11, 10),	
				//small side 1 
				new Point3D(0, 5, 11),	
				new Point3D(11, 6, 0),	
				//small side 2
				new Point3D(4, 3, 9),	
				new Point3D(9, 10, 4),	
				//bottom slope 1 
				new Point3D(0, 1, 7),	
				new Point3D(7, 6, 0),	
				//bottom slope 2 
				new Point3D(2, 3, 9),	
				new Point3D(9, 8, 2),	
				//bottom (near the grip)
				new Point3D(1, 2, 8),	
				new Point3D(8, 7, 1)	
			};
			Guard.Dock(new Point3D(-3, 0, -0.5));
		}
		/// <summary>
		/// Draws this object onto the OpenGL control
		/// </summary>
		/// <param name="gl">OpenGL controll to draw onto</param>
		public void Draw(OpenGL gl)
		{
			gl.Begin(OpenGL.GL_TRIANGLES);
			gl.Color(0.7f, 0.7f, 0.7f);
			for (int i = 0; i < Blade.Indexes.Length; i++)
			{
				gl.Vertex(Blade.Points[(int)Blade.Indexes[i].X].X, Blade.Points[(int)Blade.Indexes[i].X].Y, Blade.Points[(int)Blade.Indexes[i].X].Z);
				gl.Vertex(Blade.Points[(int)Blade.Indexes[i].Y].X, Blade.Points[(int)Blade.Indexes[i].Y].Y, Blade.Points[(int)Blade.Indexes[i].Y].Z);
				gl.Vertex(Blade.Points[(int)Blade.Indexes[i].Z].X, Blade.Points[(int)Blade.Indexes[i].Z].Y, Blade.Points[(int)Blade.Indexes[i].Z].Z);
			}
			gl.Color(0.1f, 0.1f, 0.1f);
			for (int i = 0; i < Guard.Indexes.Length; i++)
			{
				gl.Vertex(Guard.Points[(int)Guard.Indexes[i].X].X, Guard.Points[(int)Guard.Indexes[i].X].Y, Guard.Points[(int)Guard.Indexes[i].X].Z);
				gl.Vertex(Guard.Points[(int)Guard.Indexes[i].Y].X, Guard.Points[(int)Guard.Indexes[i].Y].Y, Guard.Points[(int)Guard.Indexes[i].Y].Z);
				gl.Vertex(Guard.Points[(int)Guard.Indexes[i].Z].X, Guard.Points[(int)Guard.Indexes[i].Z].Y, Guard.Points[(int)Guard.Indexes[i].Z].Z);
			}
			gl.End();

			gl.Rotate(90, 1, 0, 0);
			gl.Scale(1, 0.6, 1);
			gl.Translate(-0.5, 0, -0.1);

			gl.Begin(OpenGL.GL_QUADS);
			gl.Color(0.39f, 0.13f, 0f);
			gl.Cylinder(gl.NewQuadric(), 0.6, 0.6, 3, 50, 50);

			gl.End();

			gl.Translate(0, 0, 3);
			gl.Rotate(180, 1, 0, 0);
			gl.Scale(0.8, 0.8, 0.5);
			gl.Begin(OpenGL.GL_QUADS);
			gl.Color(0.1f, 0.1f, 0.1f);
			gl.Sphere(gl.NewQuadric(), 1.25, 20, 20);
			gl.End();
		}
    }
}