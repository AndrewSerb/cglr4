using System;
using System.Windows.Forms;
using SharpGL;

namespace cglr4
{
	public partial class Form1 : Form
	{
		private OpenGL gl;
		private Sword sword;
		public Form1()
		{
			InitializeComponent();
			gl = OGlControl.OpenGL;
			sword = new Sword();
		}
		private void OGlControl_OpenGLDraw(object sender, RenderEventArgs args)
		{
			gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
			gl.LoadIdentity();
			// Translate away from the screen to fully see the object.
			gl.Translate(0, -1, -5);
			// Apply transformations
			gl.Rotate((float)RotateXNUD.Value, (float)RotateYNUD.Value, (float)RotateZNUD.Value);
			gl.Scale((double)ScaleXNUD.Value * 0.25, (double)ScaleYNUD.Value * 0.25, (double)ScaleZNUD.Value * 0.25);
			// Draw the object
			sword.Draw(gl);
		}

		private void OGlControl_OpenGLInitialized(object sender, EventArgs e)
		{
			gl = OGlControl.OpenGL;
			gl.ClearColor(1f, 1f, 1f, 0.0f);
			gl.Enable(OpenGL.GL_DEPTH_TEST);

			float[] ambient = { 0.2f, 0.2f, 0.2f, 1f };
			float[] diffuse = { 0.2f, 0.2f, 0.2f, 1f };
			float[] specular = { 0.2f, 0.2f, 0.2f, 1f };
			float[] position = { 0.0f, 10.0f, 5.0f, 1.0f };

			gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, OpenGL.GL_TRUE);

			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, position);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, ambient);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, diffuse);
			gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, specular);

			gl.ShadeModel(OpenGL.GL_SMOOTH);
			gl.Enable(OpenGL.GL_LIGHTING);
			gl.Enable(OpenGL.GL_LIGHT0);
			gl.Enable(OpenGL.GL_COLOR_MATERIAL);
		}

		private void RotateXNUD_ValueChanged(object sender, EventArgs e)
		{
			if (RotateXNUD.Value >= 360)
				RotateXNUD.Value -= 360;
			else if (RotateXNUD.Value < 0)
				RotateXNUD.Value += 360;
		}

		private void RotateYNUD_ValueChanged(object sender, EventArgs e)
		{
			if (RotateYNUD.Value >= 360)
				RotateYNUD.Value -= 360;
			else if (RotateYNUD.Value < 0)
				RotateYNUD.Value += 360;
		}

		private void RotateZNUD_ValueChanged(object sender, EventArgs e)
		{
			if (RotateZNUD.Value >= 360)
				RotateZNUD.Value -= 360;
			else if (RotateZNUD.Value < 0)
				RotateZNUD.Value += 360;
		}
	}
}