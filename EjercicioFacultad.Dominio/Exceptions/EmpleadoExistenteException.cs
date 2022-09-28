using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Exceptions
{
    public class EmpleadoExistenteException : Exception
    {
        public EmpleadoExistenteException() : base("Empleado Existente") { }
        public EmpleadoExistenteException(string msg) : base(msg) { }
    }
}
