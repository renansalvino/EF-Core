using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Inlock.WebApi.DataBaseFirst.Domain;
using Senai.Inlock.WebApi.DataBaseFirst.Interfaces;
using Senai.Inlock.WebApi.DataBaseFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Inlock.WebApi.DataBaseFirst.Controllers
{

    [Produces("api/[json]")]

    [Route("api/[controller]")]

    [ApiController]
    public class EstudioController : ControllerBase

    {
        private IEstudioRepository _estudioRepository { get; set; }


        public EstudioController()
        {
           EstudioRepository _estudioRepository = new EstudioRepository();
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get ()
        {
            return Ok(_estudioRepository.Listar());
        }

        public IActionResult Post (Estudio novoEstudio)
        {
            _estudioRepository.Cadastrar(novoEstudio);

            return Created("http://localhost:5000/api/Estudio", novoEstudio);
        }


        [HttpGet("Jogos")]
        public IActionResult GetEstudiosJogos()
        {
            return Ok(_estudioRepository.ListarJogosPorEstudio()); mano que 
        }
    }
}
