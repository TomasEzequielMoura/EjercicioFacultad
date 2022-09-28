using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Exceptions
{
    public class AlumnoExistenteException : Exception
    {
        public AlumnoExistenteException() : base("Alumno Existente") { }
        public AlumnoExistenteException(string msg) : base(msg) { }
    }
}
