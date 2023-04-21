using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace ProgGrafica
{
    class Scenery
    {
        public Point centro;
        public Dictionary<string, Object> listaDeObjetos;
        public Point centroReal;

        public Scenery(Point centro, Dictionary<string, Object> listaDeObjetos)
        {
            this.centro = centro;
            this.listaDeObjetos = listaDeObjetos;
            this.centroReal = centro;

            foreach (var item in listaDeObjetos)
            {
                Object objeto = item.Value;
                objeto.centro = objeto.centroReal + centro;
            }
        }

        public void Draw()
        {
            foreach (var item in listaDeObjetos)
            {
                Object objeto = item.Value;
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
            this.centroReal = centro;
            foreach (var item in listaDeObjetos)
            {
                Object objeto = item.Value;
                objeto.RefreshCentro(centro + objeto.centroReal); 
            }
        }
    }
}
