using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Models;
using static WebApplication1.Models.ListaEnlazada;
using Newtonsoft.Json;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargaInicialController : ControllerBase
    {
        private readonly CargadorInicial _cargador;
        private readonly string _rutaArchivo = ".\\Data\\tarjetas.json"; // Ruta fija del archivo JSON
        private readonly ListaEnlazada _linkedList;



        public CargaInicialController(CargadorInicial cargador)
        {
            _cargador = cargador;
            _linkedList = new ListaEnlazada();

        }

        [HttpPost("arbol")]
        public IActionResult CargarArbol()
        {
            try
            {
                var arbol = _cargador.CargarArbolDesdeJson(_rutaArchivo);
                return Ok(arbol);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al cargar el árbol: {ex.Message}");
            }
        }

        [HttpPost("lista")]
        public IActionResult CargarLista()
        {
            try
            {
                var lista = _cargador.CargarListaDesdeJson(_rutaArchivo);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al cargar la lista: {ex.Message}");
            }
        }

    }
}



