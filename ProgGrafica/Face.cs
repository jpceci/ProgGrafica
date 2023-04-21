using System;
using System.Collections.Generic;
using OpenTK.Graphics.OpenGL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ProgGrafica
{
    class Face
    {
        public Point centro { get; set; }
        public Dictionary<string, Point> listaDePuntos { get; set; }
        public Color color { get; set; }
        public Point centroReal { get; set; }

        public Face()
        {

        }
        public Face(Point centro, Dictionary<string, Point> listaDePuntos, Color color)
        {
            this.centro = centro;
            this.listaDePuntos = listaDePuntos;
            this.color = color;
            this.centroReal = centro;
        }
        public Face(Point centro, Color color)
        {
            this.centro = centro;
            this.listaDePuntos = new Dictionary<string, Point>();
            this.color = color;
        }
        public void Draw()
        {
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(color);
            foreach (var item in listaDePuntos)
            {
                Point point = item.Value;
                GL.Vertex3(centro.x + point.x, centro.y + point.y, centro.z + point.z);
            }
            GL.End();
        }

        public void Add(string key, Point punto)
        {
            this.listaDePuntos.Add(key, punto);
        }

        public void Remove(string key)
        {
            this.listaDePuntos.Remove(key);
        }

        public Point Get(string key)
        {
            return this.listaDePuntos[key];
        }

        public void SetCentro(Point centro)
        {
            this.centro = centro;
            this.centroReal = centro;
        }
    }
}
