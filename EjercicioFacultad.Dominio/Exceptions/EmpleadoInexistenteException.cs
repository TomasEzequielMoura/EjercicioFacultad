using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Exceptions
{
    public class EmpleadoInexistenteException : Exception
    {
        public EmpleadoInexistenteException() : base("Empleado Inexistente") { }
        public EmpleadoInexistenteException(string msg) : base(msg) { }
    }
}
