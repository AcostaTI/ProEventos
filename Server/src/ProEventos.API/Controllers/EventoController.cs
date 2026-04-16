using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _eventos = new Evento []
    {
        new Evento
        {
            EventoId = 1,
            Local = "Pará", 
            Lote = "1º",
            Tema = "Comidas Tipícas",
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
            QtdPessoas = 300,
            ImagemURL = "tacaca.png"
        },
            new Evento
        {
            EventoId = 2,
            Local = "Pará",
            Lote = "3º",
            Tema = "Danças Regionais",
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
            QtdPessoas = 250,
            ImagemURL = "carimbo.png"
        }       
    };

    [HttpGet]
    public IEnumerable<Evento> get()
    {
        return _eventos;   
    }     

    [HttpGet("id")]
    public IEnumerable<Evento> get(int id)
    {
        return _eventos.Where(e => e.EventoId == id);   
    }   
}
