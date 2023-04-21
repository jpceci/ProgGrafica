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

        public Object(Point centro, Dictionary<string, Face> listaDeCaras)
        {
            this.centro = centro;
            this.listaDeCaras = listaDeCaras;
            this.centroReal = centro;

            foreach (var item in listaDeCaras)
            {
                Face face = item.Value;
                face.centro = face.centroReal + centro;
            }
        }

        public void Draw()
        {
            foreach (var item in listaDeCaras)
            {
                Face face = item.Value;
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
            this.centro = centro;
            this.centroReal = centro;
             foreach (var item in listaDeCaras)
            {
                Face face = item.Value;
                face.centro = face.centroReal + centro;
            }
        }
        public void RefreshCentro(Point centro)
        {
            this.centro = centro;
            foreach (var item in listaDeCaras)
            {
                Face face = item.Value;
                face.centro = face.centroReal + centro;
            }
        }
    }
}
