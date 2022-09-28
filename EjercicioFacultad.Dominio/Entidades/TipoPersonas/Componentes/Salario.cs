using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFacultad.Dominio.Entidades.TipoPersonas.Componentes
{
    public class Salario
    {

        public Salario(double bruto, string codigoTransferencia, DateTime fecha, double descuentos)
        {
            _bruto = bruto;
            _codigoTransferencia = codigoTransferencia;
            _descuentos = descuentos;
            _fecha = fecha;
        }

        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public double Bruto { get => _bruto; set => _bruto = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public double GetSalarioNeto() {
            return 0;
        }

        public void GetSalarioNeto(double salario)
        {
        }
    }
}
