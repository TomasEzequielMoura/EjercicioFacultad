using EjercicioFacultad.Dominio.Entidades.TipoPersonas.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades.TipoPersonas.TipoEmpleados
{
    public class Directivo : Empleado
    {
        public Directivo(string ultimoCodigo, DateTime fechaNac, string nombre, DateTime fechaIngreso, int legajo, List<Salario> salarios) : base(ultimoCodigo, fechaNac, nombre, fechaIngreso, legajo, salarios)
        {
        }

        public new string GetNombreCompleto()
        {
            return "";
        }
    }
}
