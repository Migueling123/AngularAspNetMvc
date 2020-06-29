using System;
using System.Collections.Generic;
using System.Linq;
using AngularAspNet.Context;

namespace AngularAspNet.Models
{
    public class UsuarioModel:IDisposable
    {
        public IEnumerable<Usuario> TraerUsuario()
        {
            IEnumerable<Usuario> usuarios;
            using(var userContexto= new ContextoPrincipal())
            {
                usuarios = userContexto._Usuario.ToList();
            }
            return usuarios;
        }
        public bool Actualizar(Usuario model)
        {
            var success = true;
            using (var userContexto = new ContextoPrincipal())
            {
                var user = userContexto._Usuario.FirstOrDefault(x => x.Id == model.Id);
                user.Nombre = model.Nombre;
                user.Salario = model.Salario;
                user.Descripcion = model.Descripcion;
                success=(userContexto.SaveChanges()>0);
            }
            return success;
        }

        public bool Borrar(long Id)
        {
            var success = true;
            using (var userContexto = new ContextoPrincipal())
            {
                var user = userContexto._Usuario.FirstOrDefault(x => x.Id == Id);
                userContexto._Usuario.Remove(user);
                success = (userContexto.SaveChanges() > 0);
            }
            return success;
        }

        public Usuario Crear(Usuario model)
        {
            
            using (var userContexto = new ContextoPrincipal())
            {
                model=userContexto._Usuario.Add(model);                
                model.RespuestaOperacion.Exito = (userContexto.SaveChanges() > 0);
            }
            return model;
        }





        #region Dispose
        public void Dispose()
        {

        }        
        #endregion
    }
}