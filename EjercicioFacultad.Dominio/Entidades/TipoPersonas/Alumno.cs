using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades.TipoPersonas
{
    public class Alumno : Persona
    {
        public Alumno(string ultimoCodigo, DateTime fechaNac, string nombre, int codigo) : base(ultimoCodigo, fechaNac, nombre)
        {
            _codigo = codigo;
        }

        private int _codigo;

        public int Codigo { get => _codigo; set => _codigo = value; }

        //TODO PROPERTY Credencial
        //public string Credencial { get => _codigo; set => _codigo = value; }

        public new string GetCredencial()
        {
            return "";
        }

        public override string ToString()
        {
            return "";
        }

    }
}
