using OrganizEtec.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrganizEtec.Models;

namespace OrganizEtec.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemasController : ControllerBase
    {
        private readonly DataContext _context;

        public TemasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")] //Buscar pelo id
        public async Task<IActionResult> GetSingle(int id)//using System.Threading.Tasks;
        {
            try
            {
                Tema a = await _context.Temas
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
                List<Tema> lista = await _context.Temas
                    .ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(Tema novoTema)
        {
            try
            {
                Integrante i = await _context.Integrantes
                    .FirstOrDefaultAsync(p => p.Id == novoTema.IntegranteId);

                if (i == null)
                    throw new Exception("Não existe Integrante com o Id informado");
                
                Projeto p = await _context.Projetos
                    .FirstOrDefaultAsync(p => p.Id == novoTema.ProjetoId);

                if (p == null)
                    throw new Exception("Não existe Projeto com o Id informado");

                await _context.Temas.AddAsync(novoTema);
                await _context.SaveChangesAsync();

                return Ok(novoTema.Id);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Tema novoTema)
        {
            try
            {
                _context.Temas.Update(novoTema);
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
                Tema tRemover = await _context.Temas.FirstOrDefaultAsync(p => p.Id == id);

                _context.Temas.Remove(tRemover);
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