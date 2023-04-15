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
        private Punto centro;
        private float alto;
        private float ancho;
        private float profundidad;

        public Casa(Punto centro, float alto, float ancho, float profundidad)
        {
            this.centro = centro;
            this.alto = alto;
            this.ancho = ancho;
            this.profundidad = profundidad;
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
            GL.Vertex3(centro.x + ancho / 2, centro.y, centro.z + profundidad / 3);
            GL.Vertex3(centro.x + ancho / 2, centro.y - (alto / 3) / 2, centro.z + profundidad / 3);
            GL.Vertex3(centro.x + ancho / 2, centro.y - (alto / 3) / 2, centro.z - profundidad / 3);
            GL.Vertex3(centro.x + ancho / 2, centro.y, centro.z - profundidad / 3);
            GL.End();
        }

        private void DibujarPuerta(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.DarkOliveGreen);
            GL.Vertex3(centro.x - (ancho / 3) / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - (ancho / 3) / 2, centro.y, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + (ancho / 3) / 2, centro.y, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + (ancho / 3) / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.End();
        }

        private void DibujarTechoIzquierdo(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.DarkGoldenrod);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z - profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarTechoDerecho(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Red);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z - profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarTechoTrasero(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Brown);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.End();
        }

        private void DibujarTechoFrente(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Cyan);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x, centro.y + alto, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarParedTrasera(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Orange);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.End();
        }

        private void DibujarParedFrente(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Yellow);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.End();
        }

        private void DibujarParedIzquierda(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Purple);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x - ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.End();
        }

        private void DibujarParedDerecha(PrimitiveType primitiveType)
        {
            GL.Begin(primitiveType);
            GL.Color3(Color.Blue);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z + profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y + alto / 2, centro.z - profundidad / 2);
            GL.Vertex3(centro.x + ancho / 2, centro.y - alto / 2, centro.z - profundidad / 2);
            GL.End();
        }
    }
}
