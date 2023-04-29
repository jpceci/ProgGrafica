using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProgGrafica
{
    class Object
    {
        public Point centro{ get; set; }
        public Dictionary<string, Face> listaDeCaras{ get; set; }
        public Point centroReal { get; set; }
        public Point centroEscenario { get; set; }

        public Object(Point centro, Dictionary<string, Face> listaDeCaras)
        {
            this.listaDeCaras = listaDeCaras;
            this.centro = centro;
            this.centroReal = centro;
            centroEscenario = new Point(0, 0, 0);

            foreach (Face face in listaDeCaras.Values)
            {
                face.RefreshCentro(centro);
            }

        }

        public void Draw()
        {
            foreach (Face face in listaDeCaras.Values)
            {
                face.Draw();
            }
        }
        public void Add(string key, Face cara)
        {
            this.listaDeCaras.Add(key, cara);
        }

        public void Remove(string key)
        {
            this.listaDeCaras.Remove(key);
        }

        public Face Get(string key)
        {
            return this.listaDeCaras[key];
        }
        public void SetCentro(Point centro)
        {
            this.centroReal = centro;
            this.centro = centroReal + this.centroEscenario;
            foreach (Face face in listaDeCaras.Values)
            {
                face.RefreshCentro(this.centro);
            }
        }
        public void RefreshCentro(Point centro)
        {
            this.centroEscenario = centro;
            this.centro = this.centroReal + centroEscenario;
            foreach (Face face in listaDeCaras.Values)
            {
                face.RefreshCentro(this.centro);
            }
        }

        public void Translate(float valorATrasladar, int x, int y, int z)
        {
            foreach(Face face in listaDeCaras.Values)
            {
                face.Translate(valorATrasladar, x, y, z);
            }
        }

        public void Scale(float valorAEscalar, int x, int y, int z)
        {
            foreach (Face face in listaDeCaras.Values)
            {
                face.Scale(valorAEscalar, x, y, z);
            }
        }

        public void RotateStage(Point centroEscenario, float valorARotar, int x, int y, int z)
        {
            foreach (Face face in listaDeCaras.Values)
            {
                face.RotateStage(centroEscenario, valorARotar, x, y, z);
            }
        }
    }
}
