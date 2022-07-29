using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAngular.API.Data;
using WebAngular.API.Models;

namespace WebAngular.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[]{                
                
                new Evento(){
                EventoId = 1,
                Tema = "Angular",
            },
                new Evento(){
                EventoId = 2,
                Tema = "Angular",
            }
        };
        private readonly DataContext context;

        public EventoController(DataContext context)
        {
                this.context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return context.Eventos;
        }
        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Delete = {id}";
        }


    }
}
