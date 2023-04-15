using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
namespace ProgGrafica
{
    public class Game: GameWindow
    {
        private Casa casa;
        private Casa casa2;
        private Auto auto;
        public Game(int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            casa = new Casa(new Punto(10, 10, 0), 6, 10, 10);
            casa2 = new Casa(new Punto(-10, -10, 0), 6, 10, 10);
            auto = new Auto(new Punto(-10, -10, 0), 2, 3, 7);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.White);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(-20, 20, -20, 20, -20, 20);
            GL.Rotate(10f, 1, 0, 0);
            GL.Rotate(-10f, 0, 1, 0);

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            //GL.Begin(PrimitiveType.LineLoop);
            //GL.Color3(1.0f, 0.0f, 0.0f);
            //GL.Vertex3(-1.0f, -1.0f, 0.0f);
            //GL.Color3(0.0f, 1.0f, 0.0f);
            //GL.Vertex3(1.0f, -1.0f, 0.0f);
            //GL.Color3(0.0f, 0.0f, 1.0f);
            //GL.Vertex3(0.0f, 1.0f, 0.0f);
            //GL.End();

            casa.Dibujar();
            //casa2.Dibujar();
            auto.Dibujar();
            GL.Rotate(2f,0,1,0);


            SwapBuffers();
            base.OnRenderFrame(e);
        }
    }
}
