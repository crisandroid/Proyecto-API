using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HistorialesTransaccionesController : ControllerBase
    {
        private readonly ArbolBinarioBusqueda _arbolHistorialesTransacciones;

        public HistorialesTransaccionesController()
        {
            _arbolHistorialesTransacciones = new ArbolBinarioBusqueda();
        }

        

        [HttpGet("{numeroTarjeta}")]
        public IActionResult ObtenerHistorialTransacciones(long numeroTarjeta)
        {
            try
            {
                // Implementar la búsqueda en el árbol binario para encontrar el historial de transacciones
                return Ok("Historial de transacciones encontrado.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener el historial de transacciones: {ex.Message}");
            }
        }

       
    }
}
