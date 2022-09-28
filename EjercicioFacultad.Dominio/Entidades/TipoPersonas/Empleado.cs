using EjercicioFacultad.Dominio.Entidades.TipoPersonas.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades.TipoPersonas
{
    public abstract class Empleado : Persona
    {
        public Empleado(string ultimoCodigo, DateTime fechaNac, string nombre, DateTime fechaIngreso, int legajo, List<Salario> salarios) : base(ultimoCodigo, fechaNac, nombre)
        {
            _fechaIngreso = fechaIngreso;
            _legajo = legajo;
            _salarios = salarios;
        }

        private DateTime _fechaIngreso;
        private int _legajo;
        private List<Salario> _salarios;

        public int Legajo { get => _legajo; set => _legajo = value; }
        public List<Salario> Salarios { get => _salarios; set => _salarios = value; }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }

        //TODO
        //public int Antiguedad { get => ; set =>  = value; }
        //public Salario UltimoSalarios { get => ; set => = value; }
        //public DateTime FechaNacimiento { get => ; set =>  = value; }

        public void AgregarSalario(Salario salario)
        {
        }

        public override bool Equals(Object obj)
        {
            return false;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public new string GetCredencial()
        {
            return "";
        }

        public new string GetNombreCompleto()
        {
            return "";
        }

        public override string ToString()
        {
            return "";
        }

    }
}
