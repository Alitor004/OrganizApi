using OrganizEtec.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganizEtec.Models;

namespace OrganizEtec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class ProjetosController : ControllerBase
    {
        private readonly DataContext _context;

        public ProjetosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)//using System.Threading.Tasks;
        {
            try
            {
                Projeto a = await _context.Projetos
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
                List<Projeto> lista = await _context.Projetos
                    .ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Projeto novoProjeto)
        {
            try
            {
                await _context.Projetos.AddAsync(novoProjeto);
                await _context.SaveChangesAsync();

                return Ok(novoProjeto.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Projeto novoProjeto)
        {
            try
            {
                _context.Projetos.Update(novoProjeto);
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
                Projeto pRemover = await _context.Projetos.FirstOrDefaultAsync(p => p.Id == id);

                _context.Projetos.Remove(pRemover);
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