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

    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class JogoController : ControllerBase
    {
        private IJogoRepository _jogoRepository { get; set; }


        public JogoController()
        {
          JogoRepository  _jogoRepository = new JogoRepository();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jogoRepository.Listar());
        }

        [HttpPost]
        public  IActionResult Post(Jogo novoJogo)
        {
            return Ok(_jogoRepository.Cadastrar(novoJogo));
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            Jogo jogoBuscado = _jogoRepository.BuscarPorId(Id);

            if (jogoBuscado == null)
            {
                return Ok(jogoBuscado);
            }

            return NotFound("Nenhum jogo encontrado para se corresponder com as informaçõs solicitadas");
        }
    [HttpPut]
        public IActionResult Put(int id, Jogo jogoAtualizado)
    {
        Jogo jogoBuscado = _jogoRepository.BuscarPorId(id);

        if (jogoBuscado == null)
        {
            try
            {
                _jogoRepository.Atualizar(id, jogoAtualizado);

                    return NoContent();
            }

                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return NotFound
                    (
                new
                {
                    mensagem = "Não foi possivel encontrar o jogo",
                    erro = true
                }
            );
    }
    }


}

        

