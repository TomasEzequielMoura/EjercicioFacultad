using EjercicioFacultad.Dominio.Entidades.TipoPersonas;
using EjercicioFacultad.Dominio.Entidades.TipoPersonas.Componentes;
using EjercicioFacultad.Dominio.Entidades.TipoPersonas.TipoEmpleados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades
{
    public class Facultad
    {
        public Facultad(int cantidadSedes, string nombre)
        {
            _cantidadSedes = cantidadSedes;
            _nombre = nombre;
        }

        private List<Alumno> _alumnos;
        private int _cantidadSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public int CantidadSedes { get => _cantidadSedes; set => _cantidadSedes = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        public void AgregarAlumno(Alumno alumno)
        {
        }

        public void AgregarEmpleado(Empleado empleado)
        {
        }


        public void EliminarAlumno(int codigo)
        {
        }

        public void EliminarEmpleado(int legajo)
        {
        }

        public void ModificarEmpleado(Empleado empleado)
        {
        }

        public List<Alumno> TraerAlumnos()
        {
            List<Alumno> listAlumno = new List<Alumno>();
            return listAlumno;
        }

        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            List<Salario> listSalario = new List<Salario>();
            Empleado EmpleadoEjemplo = new Docente("", new DateTime(2008, 04, 14), "", new DateTime(2008, 04, 14), 1 , listSalario);
            return EmpleadoEjemplo  ;
        }

        public List<Empleado> TraerEmpleado()
        {
            List<Empleado> listEmpleado = new List<Empleado>();
            return listEmpleado;
        }

        public List<Empleado> TraerEmpleadoPorNombre(string nombre)
        {
            List<Empleado> listEmpleado = new List<Empleado>();
            return listEmpleado;
        }

    }
}
