using System;

namespace WebApplication1.Models
{
    public class Transacciones
    {
        public string Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }

        public Transacciones(string fecha, string descripcion, double monto)
        {
            Fecha = fecha;
            Descripcion = descripcion;
            Monto = monto;
            
        }
    }
   
}
