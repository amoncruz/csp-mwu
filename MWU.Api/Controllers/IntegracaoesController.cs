using Microsoft.AspNetCore.Mvc;
using MWU.Application.Abstractions;
using MWU.Application.DTO.Integracao;
using System;
using System.Collections.Generic;

namespace MWU.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegracoesController : ControllerBase
    {
        private readonly IMWU _IMWUService;

        public IntegracoesController(IMWU iMWUService)
        {
            _IMWUService = iMWUService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<IntegracaoDTO> Get()
        {
            return _IMWUService.ListarIntegracao();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IntegracaoDTO Get(int id)
        {
            return new IntegracaoDTO("Teste", "Teste");
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] IntegracaoDTO integracaoDTO)
        {
            _IMWUService.AdicionarIntegracao(integracaoDTO);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] IntegracaoDTO integracaoDTO)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
