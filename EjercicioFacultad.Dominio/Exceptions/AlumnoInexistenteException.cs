using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Exceptions
{
    public class AlumnoInexistenteException : Exception
    {
        public AlumnoInexistenteException() : base("Alumno Inexistente") { }
        public AlumnoInexistenteException(string msg) : base(msg) { }
    }
}
