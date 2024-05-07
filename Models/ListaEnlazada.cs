using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace WebApplication1.Models
{
    public class ListaEnlazada
    {
        private Node head;

        public ListaEnlazada()
        {
            head = null;
        }

        public void Insert(TarjetaCredito data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void InsertFromJsonFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            List<TarjetaCredito> tarjetas = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);

            foreach (var tarjeta in tarjetas)
            {
                Insert(tarjeta);
            }
        }

        public TarjetaCredito Search(long numero)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.Numero == numero)
                {
                    return current.Data;
                }
                current = current.Next;
            }
            return null;
        }
        // Otros métodos de la lista enlazada según sea necesario
    }
}
