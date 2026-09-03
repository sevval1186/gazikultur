using System;
using GaziKultur.Entity.Concrete;
using GaziKultur.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace GaziKultur.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MuzeController : ControllerBase
    {
        private readonly IMuzeService _muzeService;

        public MuzeController(IMuzeService muzeService)
        {
            _muzeService = muzeService;
        }

        // GET: api/Muze
        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _muzeService.GetAll();
            return Ok(result);
        }

        // GET: api/Muze/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var result = _muzeService.GetById(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        // POST: api/Muze
        [HttpPost]
        public IActionResult Add([FromBody] Muze muze)
        {
            _muzeService.Add(muze);
            return Ok(new { message = "Müze başarıyla eklendi." });
        }

        // PUT: api/Muze
        [HttpPut]
        public IActionResult Update([FromBody] Muze muze)
        {
            _muzeService.Update(muze);
            return Ok(new { message = "Müze başarıyla güncellendi." });
        }

        // DELETE: api/Muze/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _muzeService.Delete(id);
            return Ok(new { message = "Müze başarıyla silindi." });
        }
    }
}
