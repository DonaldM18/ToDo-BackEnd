using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Entidades.Entidades
{
    public class Tarea
    {
        public int id_tarea { get; set; }
        public string nombre { get; set; }
        public string accion { get; set; }
        public string responsable { get; set; }
        public string duracion { get; set; }
        public string id_estado_fk { get; set; }
    }

}
