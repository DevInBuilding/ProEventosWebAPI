using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] { 
            new Evento() {
                EventoId = 1,
                Local = "Maranhão",
                Lote = "1º Lote",
                Tema = "Angular 11 e .NET 5",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                ImagemURL = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "São Paulo",
                Lote = "2º Lote",
                Tema = "Angular e Suas Novidades",
                QtdPessoas = 125,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                ImagemURL = "print.jpg"
            }
        };
        public EventoController()
        {            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }
        
        //Returns only the element with the id entered
        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }
        
        [HttpPost]
        public string Post()
        {
            return "Exemplo de POST";
        }

        [HttpPut("{id}")]
        public string Post(int id)
        {
            return $"Exemplo de PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de DELETE com id = {id}";
        }
    }
}
