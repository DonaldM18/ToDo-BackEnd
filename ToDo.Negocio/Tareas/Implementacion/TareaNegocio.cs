using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Datos.Interfases;
using ToDo.DtoModel;
using ToDo.Negocio.Tareas.Interfaz;
using ToDo.Util;

namespace ToDo.Negocio.Tareas.Implementacion
{
    public class TareaNegocio : ITareaNegocio
    {
        private readonly ITareasRepositorio _tareasRepositorio;
        public TareaNegocio(ITareasRepositorio tareasRepositorio)
        {
            _tareasRepositorio = tareasRepositorio;
        }

        public ITareasRepositorio TareasRepositorio { get; }

        public Response<int> BorrarTareas(string id_tarea)
        {
            var response = new Response<int>();
            try
            {
                var data = _tareasRepositorio.BorrarTareas(Convert.ToInt32(id_tarea));
                if (data != null)
                {
                    response.Data = data;
                    response.IsSuccess = true;
                    response.Message = "Registros Borrados";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<TareaSalidaDTO> EditarTareas(TareaSalidaDTO tarea)
        {
            var response = new Response<TareaSalidaDTO>();
            try
            {
                var data = _tareasRepositorio.EditarTareas(tarea);
                if (data != null)
                {
                    response.Data = data;
                    response.IsSuccess = true;
                    response.Message = "Registros editados";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<TareaSalidaDTO> InsertarTareas(TareaDTO tarea)
        {
            var response = new Response<TareaSalidaDTO>();
            try
            {
                var data = _tareasRepositorio.InsertarTareas(tarea);
                if (data != null)
                {
                    response.Data = data;
                    response.IsSuccess = true;
                    response.Message = "Registros insertados";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }

        public Response<IEnumerable<TareaSalidaDTO>> ObtenerTareas()
        {
            var response = new Response<IEnumerable<TareaSalidaDTO>>();
            try
            {
                var data = _tareasRepositorio.ObtenerTareas();
                if (data != null)
                {
                    response.Data = data;
                    response.IsSuccess = true;
                    response.Message = "Registros obtenidos";
                }
            }
            catch (Exception e)
            {
                response.Message = e.Message;
            }
            return response;
        }
    }
}
