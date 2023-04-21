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
        private Point centro;
        private float alto;
        private float ancho;
        private float profundidad;

        public Auto(Point centro, float alto, float ancho, float profundidad)
        {
            this.centro = centro;
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
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
                GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2 + Math.Cos(i) * 1, centro.z + profundidad / 4 + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaTraseraDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i += 2)
            {
                GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2 + Math.Cos(i) * 1, centro.z + profundidad / 4 + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaDelanteraIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i += 2)
            {
                GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2 + Math.Cos(i) * 1, centro.z - profundidad / 4 + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarRuedaDelanteraDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Black);
            for (int i = 0; i < 180; i+=2)
            {
                GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2 + Math.Cos(i) * 1, centro.z - profundidad / 4 + Math.Sin(i) * 1);
            }
            GL.End();
        }

        private void DibujarVentanillaIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto / 2, centro.z - profundidad / 3);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto, centro.z - profundidad / 4);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto, centro.z + profundidad / 4);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto / 2, centro.z + profundidad / 3);
            GL.End();
        }

        private void DibujarVentanillaDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto / 2, centro.z - profundidad / 3);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto, centro.z - profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto, centro.z + profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto / 2, centro.z + profundidad / 3);
            GL.End();
        }
        private void DibujarParabrisaTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.FromArgb(1, 168, 204, 215));
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto / 2, centro.z + profundidad / 3);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto, centro.z + profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto, centro.z + profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto / 2, centro.z + profundidad / 3);
            GL.End();
        }

        private void DibujarParabrisaDelantero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.FromArgb(1, 168, 204, 215));
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto / 2, centro.z - profundidad / 3);
            GL.Vertex3(centro.x - ancho / 4, centro.y + alto, centro.z - profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto, centro.z - profundidad / 4);
            GL.Vertex3(centro.x + ancho / 4, centro.y + alto / 2, centro.z - profundidad / 3);
            GL.End();
        }

        private void DibujarPuertaIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarPuertaDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarParachoqueTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarParachoqueDelantero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.End();
        }
    }
}
