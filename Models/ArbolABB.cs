using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class ArbolBinarioBusqueda
    {
        public NodoArbol Raiz { get; private set; }

        public void Insertar(TarjetaCredito tarjeta)
        {
            Raiz = InsertarRecursivo(Raiz, tarjeta);
        }

        private NodoArbol InsertarRecursivo(NodoArbol nodo, TarjetaCredito tarjeta)
        {
            if (nodo == null)
            {
                return new NodoArbol(tarjeta);
            }

            if (tarjeta.Numero < nodo.Tarjeta.Numero)
            {
                nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, tarjeta);
            }
            else if (tarjeta.Numero > nodo.Tarjeta.Numero)
            {
                nodo.Derecha = InsertarRecursivo(nodo.Derecha, tarjeta);
            }

            return nodo;
        }

        // Otros métodos del árbol binario de búsqueda, como búsqueda, eliminación, recorridos, etc.
    }

    public class NodoArbol
    {
        public TarjetaCredito Tarjeta { get; }
        public NodoArbol Izquierda { get; set; }
        public NodoArbol Derecha { get; set; }

        public NodoArbol(TarjetaCredito tarjeta)
        {
            Tarjeta = tarjeta;
            Izquierda = null;
            Derecha = null;
        }

      
    }
}

