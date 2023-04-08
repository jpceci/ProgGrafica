using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Graphics;
using System.Drawing;

namespace ProgGrafica
{
    class Auto
    {
        public Auto()
        {
        }

        public void Dibujar()
        {
            PrimitiveType primitiveType = PrimitiveType.LineLoop;
            DibujarParachoqueDelantero(primitiveType);
            DibujarParachoqueTrasero(primitiveType);
            DibujarPuertaDerecha(primitiveType);
            DibujarPuertaIzquierda(primitiveType);
            DibujarParabrisaDelantero(primitiveType);
            DibujarParabrisaTrasero(primitiveType);
            DibujarVentanillaDerecha(primitiveType);
            DibujarVentanillaIzquierda(primitiveType);
            DibujarRuedaDelanteraDerecha(primitiveType);
            DibujarRuedaDelanteraIzquierda(primitiveType);
            DibujarRuedaTraseraDerecha(primitiveType);
            DibujarRuedaTraseraIzquierda(primitiveType);

        }

        private void DibujarRuedaTraseraIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i+=2)
            {
                GL.Vertex3(11, -9 + Math.Cos(i) * 1, -6f + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaTraseraDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i += 2)
            {
                GL.Vertex3(14, -9 + Math.Cos(i) * 1, -6f + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaDelanteraIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i += 2)
            {
                GL.Vertex3(11, -9 + Math.Cos(i) * 1, -3f + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaDelanteraDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i+=2)
            {
                GL.Vertex3(14, -9 + Math.Cos(i) * 1, -3f + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarVentanillaIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(11f, -7f, -2f);
            GL.Vertex3(11f, -5f, -3f);
            GL.Vertex3(11f, -5f, -6f);
            GL.Vertex3(11f, -7f, -7f);
            GL.End();
        }

        private void DibujarVentanillaDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(13f, -5f, -3f);
            GL.Vertex3(13f, -7f, -2f);
            GL.Vertex3(13f, -7f, -7f);
            GL.Vertex3(13f, -5f, -6f);
            GL.End();
        }
        private void DibujarParabrisaTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(11f, -7f, -7f);
            GL.Vertex3(11f, -5f, -6f);
            GL.Vertex3(13f, -5f, -6f);
            GL.Vertex3(13f, -7f, -7f);
            GL.End();
        }

        private void DibujarParabrisaDelantero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(11f, -7f, -2f);
            GL.Vertex3(11f, -5f, -3f);
            GL.Vertex3(13f, -5f, -3f);
            GL.Vertex3(13f, -7f, -2f);
            GL.End();
        }

        private void DibujarPuertaIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(10f, -9f, 0f);
            GL.Vertex3(10f, -7f, 0f);
            GL.Vertex3(10f, -7f, -10f);
            GL.Vertex3(10f, -9f, -10f);
            GL.End();
        }

        private void DibujarPuertaDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(14f, -9f, 0f);
            GL.Vertex3(14f, -7f, 0f);
            GL.Vertex3(14f, -7f, -10f);
            GL.Vertex3(14f, -9f, -10f);
            GL.End();
        }

        private void DibujarParachoqueTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(10f, -9f, -10f);
            GL.Vertex3(10f, -7f, -10f);
            GL.Vertex3(14f, -7f, -10f);
            GL.Vertex3(14f, -9f, -10f);
            GL.End();
        }

        private void DibujarParachoqueDelantero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(10f, -9f, 0f);
            GL.Vertex3(10f, -7f, 0f);
            GL.Vertex3(14f, -7f, 0f);
            GL.Vertex3(14f, -9f, 0f);
            GL.End();
        }
    }
}
