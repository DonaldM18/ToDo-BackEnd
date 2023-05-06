using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Datos.Context;
using ToDo.Datos.Interfases;
using ToDo.DtoModel;

namespace ToDo.Datos.Repositorios
{
    public class TareasRepositorio : ITareasRepositorio
    {
        private readonly DapperContext _context;

        public TareasRepositorio(DapperContext context)
        {
            _context = context;
        }
        public IEnumerable<TareaSalidaDTO> ObtenerTareas()
        {

            using (var connection = _context.CreateConnection())
            {
                var query = "Traer";
                var Tareas = connection.Query<TareaSalidaDTO>(query, commandType: CommandType.StoredProcedure);
                return Tareas;
            }

        }
        
        public TareaSalidaDTO InsertarTareas(TareaDTO tarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "Agregar";
                var parameters = new DynamicParameters();
                parameters.Add("nombre", tarea.nombre);
                parameters.Add("accion", tarea.accion);
                parameters.Add("responsable", tarea.responsable);
                parameters.Add("duracion", tarea.duracion);
                parameters.Add("id_estado_fk", tarea.id_estado_fk);

                var Agregar = connection.QuerySingle<TareaSalidaDTO>(query, param:parameters, commandType: CommandType.StoredProcedure);
                return Agregar;
            }
        }

        public int BorrarTareas(int id_tarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "Borrar";
                var parameters = new DynamicParameters();
                parameters.Add("id_tarea", id_tarea);

                var Borrar = connection.Execute(query, param: parameters, commandType: CommandType.StoredProcedure);
                return Borrar;
            }
        }

        public TareaSalidaDTO EditarTareas(TareaSalidaDTO tarea)
        {
            using (var connection = _context.CreateConnection())
            {
                var query = "Editar";
                var parameters = new DynamicParameters();
                parameters.Add("id_tarea", tarea.id_tarea);
                parameters.Add("nombre", tarea.nombre);
                parameters.Add("accion", tarea.accion);
                parameters.Add("responsable", tarea.responsable);
                parameters.Add("duracion", tarea.duracion);
                parameters.Add("id_estado_fk", tarea.id_estado_fk);

                var Editar = connection.QuerySingle<TareaSalidaDTO>(query, param: parameters, commandType: CommandType.StoredProcedure);
                return Editar;
            }
        }
    }
}
