using OrganizEtec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrganizEtec.Data;
using System.Threading.Tasks;

namespace OrganizEtec.Controller
{

    [ApiController]
    [Route("[controller]")]

    public class IntegrantesController : ControllerBase
    {
        private readonly DataContext _context;

        public IntegrantesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)//using System.Threading.Tasks;
        {
            try
            {
                Integrante a = await _context.Integrantes
                       .FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                //using Microsoft.EntityFrameworkCore;

                return Ok(a);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                //using System.Collections.Generic;
                List<Integrante> lista = await _context.Integrantes
                    .ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Integrante novoIntegrante)
        {
            try
            {
                await _context.Integrantes.AddAsync(novoIntegrante);
                await _context.SaveChangesAsync();

                return Ok(novoIntegrante.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Integrante novoIntegrante)
        {
            try
            {
                _context.Integrantes.Update(novoIntegrante);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Integrante iRemover = await _context.Integrantes.FirstOrDefaultAsync(p => p.Id == id);

                _context.Integrantes.Remove(iRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();
                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }






    }

}