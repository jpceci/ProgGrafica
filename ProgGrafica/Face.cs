using System;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
namespace ProgGrafica
{
    class Face
    {
        public Point centro { get; set; }
        public List<Point> listaDePuntos { get; set; }
        public Color color { get; set; }
        public Point centroReal { get; set; }
        public Point centroObjeto { get; set; }
        public Point traslacion { get; set; }
        public Point escalacion { get; set; }
        public Matrix3 rotacion { get; set; }
        public Point transformacion { get; set; }

    public Face()
        {

        }
        public Face(Point centro, List<Point> listaDePuntos, Color color)
        {
            this.centro = centro;
            this.listaDePuntos = listaDePuntos;
            this.color = color;
            this.centroReal = centro;
            this.centroObjeto = new Point(0, 0, 0);
            this.traslacion = new Point(0, 0, 0);
            this.escalacion = new Point(1, 1, 1);
            this.rotacion = Matrix3.Identity;
            this.transformacion = new Point(0, 0, 0);
        }
        public Face(Point centro, Color color)
        {
            this.centro = centro;
            this.listaDePuntos = new List<Point>();
            this.color = color;
        }
        public void Draw()
        {
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(color);
            foreach (var point in listaDePuntos)
            {
                Point valores = (centro + point - this.transformacion) * this.escalacion * this.rotacion + this.traslacion + this.transformacion;
                GL.Vertex3(valores.x, valores.y, valores.z);
            }
            GL.End();

        }

        public void Add(Point punto)
        {
            this.listaDePuntos.Add(punto);
        }

        public void Remove(int index)
        {
            this.listaDePuntos.RemoveAt(index);
        }

        public Point Get(int index)
        {
            return this.listaDePuntos[index];
        }

        public void SetCentro(Point centro)
        {
            this.centroReal = centro;
            this.centro = centroReal + this.centroObjeto;
        }

        public void RefreshCentro(Point centro)
        {
            this.centroObjeto = centro;
            this.centro = this.centroReal + centroObjeto;
        }

        public void Translate(float valorATrasladar, int x, int y, int z)
        {
            this.traslacion += new Point(valorATrasladar * x, valorATrasladar * y, valorATrasladar * z);
        }

        public void Scale(float valorAEscalar, int x, int y, int z)
        {
            float escalarX = valorAEscalar * x == 0 ? 1: valorAEscalar * x;
            float escalarY = valorAEscalar * y == 0 ? 1 : valorAEscalar * y;
            float escalarZ = valorAEscalar * z == 0 ? 1 : valorAEscalar * z;
            this.escalacion *= new Point(escalarX, escalarY, escalarZ);
        }

        public void RotateStage(Point centroEscenario, float valorARotar, int x, int y, int z)
        {
            this.transformacion = centroEscenario;
            float rotarX = MathHelper.DegreesToRadians(valorARotar * x);
            float rotarY = MathHelper.DegreesToRadians(valorARotar * y);
            float rotarZ = MathHelper.DegreesToRadians(valorARotar * z);
            this.rotacion *= Matrix3.CreateRotationX(rotarX) * Matrix3.CreateRotationY(rotarY) * Matrix3.CreateRotationZ(rotarZ);
        }
    }
}
