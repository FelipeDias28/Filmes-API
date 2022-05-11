using Filmes_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Filmes_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        // A lista será um campo da classe
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public void AdicionarFilme([FromBody] Filme filme)
        {
            filme.id = id++;
            filmes.Add(filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return filmes;
        }
    }
}
