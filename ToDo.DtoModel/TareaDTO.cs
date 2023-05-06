using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.DtoModel
{
    public class TareaDTO
    {
        public string nombre { get; set; }
        public string accion { get; set; }
        public string responsable { get; set; }
        public string duracion { get; set; }
        public int id_estado_fk { get; set; }

    }
}
