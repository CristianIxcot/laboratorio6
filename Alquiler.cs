using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratorio6
{
    class Alquiler
    {
        
        int nit;
        string placa;
        float fechaAlq;
        float fechaDev;
        int kilometros;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public float FechaAlq { get => fechaAlq; set => fechaAlq = value; }
        public float FechaDev { get => fechaDev; set => fechaDev = value; }
        public int Kilometros { get => kilometros; set => kilometros = value; }

        /*public int Nit { get => Nit1; set => Nit1 = value; }
        public string Placa { get => Placa1; set => Placa1 = value; }
        public DateTime FechaAlq { get => FechaAlq1; set => FechaAlq1 = value; }
        public DateTime FechaDev { get => FechaDev1; set => FechaDev1 = value; }
        public int Kilometros { get => Kilometros1; set => Kilometros1 = value; }
        public int Nit1 { get => nit; set => nit = value; }
        public string Placa1 { get => placa; set => placa = value; }
        public float FechaAlq1 { get => fechaAlq; set => fechaAlq = value; }
        public float FechaDev1 { get => fechaDev; set => fechaDev = value; }
        public int Kilometros1 { get => kilometros; set => kilometros = value; }*/

    }
}
