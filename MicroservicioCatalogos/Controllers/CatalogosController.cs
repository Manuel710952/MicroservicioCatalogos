using DB;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicioCatalogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private PruebaContext _context;

        public CatalogosController(PruebaContext context) { 
            _context = context;
        }

        [HttpGet]
        [Produces("application/json")]
        public IActionResult GetAll()
        {

            var datos = new List<string> { "dato1", "dato2", "dato3" };

            return Ok(_context.Areas.ToList());
        }


        [HttpGet("{id}")]
        [Produces("application/json")]
        public IActionResult GetById(int id)
        {

            var dato = "dato" + id;

            return Ok(dato);
        }


        [HttpPost]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Create([FromBody] Area area)
        {

            var creado = _context.Areas.Add(area);
            _context.SaveChanges();
            return Ok(area);
        }

        // PUT api/ejemplo/5
        [HttpPut("{id}")]
        [Consumes("application/json")]
        [Produces("application/json")]
        public IActionResult Update(int id, [FromBody] string value)
        {


            return Ok("Dato actualizado exitosamente");
        }

        // DELETE api/ejemplo/5
        [HttpDelete("{id}")]
        [Produces("application/json")]
        public IActionResult Delete(int id)
        {


            return Ok("Dato eliminado exitosamente");
        }
    }
}
