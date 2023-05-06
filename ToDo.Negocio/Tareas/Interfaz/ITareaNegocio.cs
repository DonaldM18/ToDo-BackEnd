using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DtoModel;
using ToDo.Util;

namespace ToDo.Negocio.Tareas.Interfaz
{
    public interface ITareaNegocio
    {
        public Response<IEnumerable<TareaSalidaDTO>> ObtenerTareas();
        public Response<TareaSalidaDTO> InsertarTareas(TareaDTO tarea);
        public Response<int> BorrarTareas(string id_tarea);
        public Response<TareaSalidaDTO> EditarTareas(TareaSalidaDTO tarea);
    }
}
