using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.DtoModel;

namespace ToDo.Datos.Interfases
{
    public interface ITareasRepositorio
    {
        public IEnumerable<TareaSalidaDTO> ObtenerTareas();
        public TareaSalidaDTO InsertarTareas(TareaDTO tarea);
        public int BorrarTareas(int id_tarea);
        public TareaSalidaDTO EditarTareas(TareaSalidaDTO tarea);
    }
}
