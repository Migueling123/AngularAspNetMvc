using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AngularAspNet.Models;

namespace AngularAspNet.Controllers.API
{
    public class UsuarioController : ApiController
    {        
        [HttpGet]
        public IHttpActionResult Traer()
        {
            IEnumerable<Usuario> usuarios = null;
            try
            {
                using (var usrModel = new UsuarioModel())
                {
                    usuarios = usrModel.TraerUsuario().ToList();
                }
            }
            catch (Exception ex)
            {
                return NotFound();

            }
            return Ok(usuarios);
        }
        [HttpPost]
        public IHttpActionResult Crear(Usuario model)
        {
            try
            {
                using (var usrModel = new UsuarioModel())
                {
                   model=usrModel.Crear(model);
                }
            }
            catch (Exception ex)
            {
                model.RespuestaOperacion.Exito = false;
                model.RespuestaOperacion.Mensaje = "Hubo un error";                
            }

            return Ok(model);
            
        }
    }
}
