using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProgGrafica
{
    class Stage
    {
        public Point centro;
        public Dictionary<string, Object> listaDeObjetos;
        public Point centroReal;

        public Stage(Point centro, Dictionary<string, Object> listaDeObjetos)
        {
            this.centro = centro;
            this.listaDeObjetos = listaDeObjetos;
            this.centroReal = centro;

            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.RefreshCentro(centro);
            }
        }

        public void Draw()
        {
            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.Draw();
            }
        }
        public void Add(string key, Object objeto)
        {
            this.listaDeObjetos.Add(key, objeto);
        }

        public void Remove(string key)
        {
            this.listaDeObjetos.Remove(key);
        }

        public Object Get(string key)
        {
            return this.listaDeObjetos[key];
        }

        public void SetCentro(Point centro)
        {
            this.centro = centro;
            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.RefreshCentro(this.centro); 
            }
        }
        public void Translate(float valorATrasladar, int x, int y, int z)
        {
            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.Translate(valorATrasladar, x, y, z);
            }
        }
        public void Scale(float valorAEscalar, int x, int y, int z)
        {
            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.Scale(valorAEscalar, x, y, z);
            }
        }
        public void Rotate(float valorARotar, int x, int y, int z)
        {
            foreach (Object objeto in listaDeObjetos.Values)
            {
                objeto.RotateStage(this.centro, valorARotar, x, y, z);
            }
        }
    }
}
