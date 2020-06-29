using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AngularAspNet.Models
{
    public class Usuario
    {
        public Usuario()
        {
            RespuestaOperacion = new Respuesta()
            {
                Exito = true,
                Mensaje = "operacion exitosa"
            };
        }
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long Salario { get; set; }
        [NotMapped]
        public Respuesta RespuestaOperacion { get; set; }
    }
}