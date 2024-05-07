using System;
using System.Collections.Generic;
using System.Transactions;

namespace WebApplication1.Models
{
    public class TarjetaCredito
    {
        public long Numero { get; set; }
        public string Nombre { get; set; }
        public string FechaExpiracion { get; set; }
        public string CodigoSeguridad { get; set; }
        public string Tipo { get; set; }
        public double LimiteCredito { get; set; }
        public double Saldo { get; set; }
        public string Estatus { get; set; }
        public List<Transacciones> HistorialTransacciones { get; set; }

        public TarjetaCredito(long numero, string nombre, string fechaExpiracion, string codigoSeguridad, string tipo, double limiteCredito, double saldo, string estatus)
        {
            Numero = numero;
            Nombre = nombre;
            FechaExpiracion = fechaExpiracion;
            CodigoSeguridad = codigoSeguridad;
            Tipo = tipo;
            LimiteCredito = limiteCredito;
            Saldo = saldo;
            Estatus = estatus;

        }

    }
}
