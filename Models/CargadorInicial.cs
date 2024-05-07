namespace WebApplication1.Models
{
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;
    public class CargadorInicial
    {
        private ListaEnlazada _listaEnlazada;
        public CargadorInicial()
        {
            _listaEnlazada = new ListaEnlazada(); // Inicializar la lista enlazada
        }
        public ArbolBinarioBusqueda CargarArbolDesdeJson(string rutaArchivo)
        {
            string json = File.ReadAllText(rutaArchivo);
            var tarjetas = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);

            ArbolBinarioBusqueda arbol = new ArbolBinarioBusqueda();
            foreach (var tarjeta in tarjetas)
            {
                arbol.Insertar(tarjeta);
            }

            return arbol;
        }

        public ListaEnlazada CargarListaDesdeJson(string rutaArchivo)
        {
            string json = File.ReadAllText(rutaArchivo);
            var tarjetas = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);

            ListaEnlazada lista = new ListaEnlazada();
            foreach (var tarjeta in tarjetas)
            {
               // lista.InsertarAlInicio(tarjeta);
            }

            return lista;
        }
       
        


    }
}
