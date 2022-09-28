using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades
{
    public abstract class Persona
    {
        public Persona(string ultimoCodigo, DateTime fechaNac, string nombre)
        {
            _apellido = ultimoCodigo;
            _fechaNac = fechaNac;
            _nombre = nombre;
        }

        private string _apellido;
        private DateTime _fechaNac;
        private string _nombre;

        public string Apellido { get => _apellido; set => _apellido = value; }

        //TODO PROPERTY EDAD
        //public int Edad { get => _fechaNac; set => _fechaNac = value; }

        //public DateTime FechaNac { get => _fechaNac; set => _fechaNac = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public string GetCredencial() {
            return "";
        }

        public string GetNombreCompleto()
        {
            return "";
        }
    }
}
