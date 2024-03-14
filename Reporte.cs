using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio6
{
    class Reporte
    {
        int nit;
        string nombre;
        string placa;
        float fechaAlq;
        float fechaDev;
        int kilometros;
        int totalPago;

        public int Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Placa { get => placa; set => placa = value; }
        public float FechaAlq { get => fechaAlq; set => fechaAlq = value; }
        public float FechaDev { get => fechaDev; set => fechaDev = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }
        public int TotalPago { get => totalPago; set => totalPago = value; }
    }
}
