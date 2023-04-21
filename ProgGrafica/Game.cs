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
        private Auto auto;
        private Scenery escenario;

        public Game(int width, int height, string title)
            : base(width, height, GraphicsMode.Default, title)
        {
            casa = new Casa(new Point(10, 10, 0), 6, 10, 10);
            auto = new Auto(new Point(-10, -10, 0), 2, 3, 7);

            Dictionary<string, Point> listaDePuntosFT = new Dictionary<string, Point>();
            listaDePuntosFT.Add("puntoIzquierdoArriba", new Point(-4, 4, 0));
            listaDePuntosFT.Add("puntoDerechoArriba", new Point(4, 4, 0));
            listaDePuntosFT.Add("puntoDerechoAbajo", new Point(4, -4, 0));
            listaDePuntosFT.Add("puntoIzquierdoAbajo", new Point(-4, -4, 0));

            Dictionary<string, Point> listaDePuntosLaterales = new Dictionary<string, Point>();
            listaDePuntosLaterales.Add("puntoIzquierdoArriba", new Point(0, 4, 4));
            listaDePuntosLaterales.Add("puntoDerechoArriba", new Point(0, 4, -4));
            listaDePuntosLaterales.Add("puntoDerechoAbajo", new Point(0, -4, -4));
            listaDePuntosLaterales.Add("puntoIzquierdoAbajo", new Point(0, -4, 4));

            Face caraFrente = new Face(new Point(0, 0, 4), listaDePuntosFT, Color.Blue);
            Face caraAtras = new Face(new Point(0, 0, -4), listaDePuntosFT, Color.Blue);
            Face caraDerecha = new Face(new Point(4, 0, 0), listaDePuntosLaterales, Color.Blue);
            Face caraIzquierda = new Face(new Point(-4, 0, 0), listaDePuntosLaterales, Color.Blue);

            Dictionary<string, Face> listaDeCaras = new Dictionary<string, Face>();
            listaDeCaras.Add("caraFrente", caraFrente);
            listaDeCaras.Add("caraAtras", caraAtras);
            listaDeCaras.Add("caraDerecha", caraDerecha);
            listaDeCaras.Add("caraIzquierda", caraIzquierda);

            Object cubo = new Object(new Point(0, 0, 0), listaDeCaras);
            //JSON.Save("../../JSON/Cubo.json", cubo);
            Dictionary<string, Object> listaDeObjetos = new Dictionary<string, Object>();
            listaDeObjetos.Add("cubo", cubo);

            escenario = new Scenery(new Point(0, 0, 0), listaDeObjetos);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.White);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(-50, 50, -50, 50, -50, 50);
            GL.Rotate(10f, 1, 0, 0);
            GL.Rotate(-10f, 0, 1, 0);
            //Object cubo = JSON.Load("../../JSON/Cubo.json");

            escenario.SetCentro(new Point(0, -20, 0));
            escenario.Get("cubo").SetCentro(new Point(20, 40, 0));
            escenario.Get("cubo").Get("caraDerecha").SetCentro(new Point(-25, -20, 0));
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
            //casa.Dibujar(); 
            //auto.Dibujar();
            escenario.Draw();
            GL.Rotate(2f, 0, 1, 0);
            SwapBuffers();
            base.OnRenderFrame(e);
        }
    }
}
