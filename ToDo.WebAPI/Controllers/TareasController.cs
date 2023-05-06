using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.DtoModel;
using ToDo.Negocio.Tareas.Interfaz;

namespace ToDo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly ITareaNegocio _tareaNegocio;
        public TareasController(ITareaNegocio tareaNegocio)
        {
            _tareaNegocio = tareaNegocio;
        }

        #region "Métodos Sincronos"
        [HttpPost("Agregar")]
        public IActionResult Insert([FromBody] TareaDTO tareaDto)
        {
            if (tareaDto == null)
                return BadRequest();
            var response = _tareaNegocio.InsertarTareas(tareaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] TareaSalidaDTO tareaDto)
        {
            if (tareaDto == null)
                return BadRequest();
            var response = _tareaNegocio.EditarTareas(tareaDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpDelete("Delete/{id_tarea}")]
        public IActionResult Delete(string id_tarea)
        {
            if (string.IsNullOrEmpty(id_tarea))
                return BadRequest();
            var response = _tareaNegocio.BorrarTareas(id_tarea);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var response = _tareaNegocio.ObtenerTareas();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
#endregion

    }
}
