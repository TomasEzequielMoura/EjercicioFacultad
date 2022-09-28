using EjercicioFacultad.Dominio.Entidades.TipoPersonas.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades.TipoPersonas.TipoEmpleados
{
    public class Bedel : Empleado
    {

        public Bedel(string ultimoCodigo, DateTime fechaNac, string nombre, DateTime fechaIngreso, int legajo, List<Salario> salarios, string apodo) : base(ultimoCodigo, fechaNac, nombre, fechaIngreso, legajo, salarios)
        {
            _apodo = apodo;
        }

        private string _apodo;

        public string Apodo { get => _apodo; set => _apodo = value; }

        public new string GetNombreCompleto()
        {
            return "";
        }
    }
}
