using Act1_Seguridad.Services.IServices;
using Domain.DTO;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Act1_Seguridad.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServices _usuarioServices;
        public UsuarioController(IUsuarioServices usuarioServices) {
            _usuarioServices = usuarioServices;
        }

        [HttpGet (Name = "GETUsuarios")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _usuarioServices.GetAll();
            return Ok(response);
        }
        [HttpGet ("id")]
        public async Task<IActionResult> GetUser(int id)
        {
            return Ok(await _usuarioServices.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> PostUser([FromBody] UsuarioRequest request)
        {
            return Ok(await _usuarioServices.Create(request));
        }
        [HttpPut ("id")]
        public async Task<IActionResult> PutUser(UsuarioRequest request,int id)
        {
            return Ok(await _usuarioServices.Update(request, id));
        }
        [HttpDelete ("id")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _usuarioServices.Delete(id));
        }
    }
}
