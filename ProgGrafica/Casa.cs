using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgGrafica
{
    class Casa
    {
        public Casa()
        {
        }

        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            DibujarParedIzquierda(primitiveType);
            DibujarParedDerecha(primitiveType);
            DibujarParedFrente(primitiveType);
            DibujarParedTrasera(primitiveType);
            DibujarTechoFrente(primitiveType);
            DibujarTechoTrasero(primitiveType);
            DibujarTechoDerecho(primitiveType);
            DibujarTechoIzquierdo(primitiveType);
            DibujarPuerta(primitiveType);
            DibujarVentana(primitiveType);
        }

        private void DibujarVentana(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.DarkOliveGreen);
            GL.Vertex3(0f, -7f, -4f);
            GL.Vertex3(0f, -5f, -4f);
            GL.Vertex3(0f, -5f, -11f);
            GL.Vertex3(0f, -7f, -11f);
            GL.End();
        }

        private void DibujarPuerta(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.DarkOliveGreen);
            GL.Vertex3(-6.5f, -10f, 0f);
            GL.Vertex3(-6.5f, -5f, 0f);
            GL.Vertex3(-3.5f, -5f, 0f);
            GL.Vertex3(-3.5f, -10f, 0f);
            GL.End();
        }

        private void DibujarTechoIzquierdo(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.DarkGoldenrod);
            GL.Vertex3(-10f, 0f, 0f);
            GL.Vertex3(-5f, 5f, 0f);
            GL.Vertex3(-5f, 5f, -15f);
            GL.Vertex3(-10f, 0f, -15f);
            GL.End();
        }

        private void DibujarTechoDerecho(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Red);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(-5f, 5f, 0f);
            GL.Vertex3(-5f, 5f, -15f);
            GL.Vertex3(0f, 0f, -15f);
            GL.End();
        }

        private void DibujarTechoTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Brown);
            GL.Vertex3(-10f, 0f, -15f);
            GL.Vertex3(-5f, 5f, -15f);
            GL.Vertex3(0f, 0f, -15f);
            GL.End();
        }

        private void DibujarTechoFrente(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Cyan);
            GL.Vertex3(-10f, 0f, 0f);
            GL.Vertex3(-5f, 5f, 0f);
            GL.Vertex3(0f, 0f, 0f);
            GL.End();
        }

        private void DibujarParedTrasera(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(-10f, -10f, -15f);
            GL.Vertex3(-10f, 0f, -15f);
            GL.Vertex3(0f, 0f, -15f);
            GL.Vertex3(0f, -10f, -15f);
            GL.End();
        }

        private void DibujarParedFrente(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Yellow);
            GL.Vertex3(-10f, -10f, 0f);
            GL.Vertex3(-10f, 0f, 0f);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0f, -10f, 0f);
            GL.End();
        }

        private void DibujarParedIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Purple);
            GL.Vertex3(0f, -10f, 0f);
            GL.Vertex3(0f, 0f, 0f);
            GL.Vertex3(0f, 0f, -15f);
            GL.Vertex3(0f, -10f, -15f);
            GL.End();
        }

        private void DibujarParedDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(-10f, -10f, 0f);
            GL.Vertex3(-10f, 0f, 0f);
            GL.Vertex3(-10f, 0f, -15f);
            GL.Vertex3(-10f, -10f, -15f);
            GL.End();
        }
    }
}
