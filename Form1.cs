using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace laboratorio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Clientes> clientess = new List<Clientes>();
        List<Vehiculos> vehiculoss = new List<Vehiculos>();
        List<Alquiler> alquilers = new List<Alquiler>();

        public void cargarClientes()
        {
            String fileName = "Clientes.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
 
            while (reader.Peek() > -1)
            {
                Clientes clientes = new Clientes();
                clientes.Nit = Convert.ToInt32(reader.ReadLine());
                clientes.Nombre = reader.ReadLine();
                clientes.Direccion = reader.ReadLine();
            
                clientess.Add(clientes);

            }
            reader.Close();
        }

        public void cargarAlquileres()
        {
            String fileName = "Alquileres.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquiler alquileres = new Alquiler();
                alquileres.Nit = Convert.ToInt32(reader.ReadLine());
                alquileres.Placa = reader.ReadLine();
                alquileres.FechaAlq = Convert.ToDateTime(reader.ReadLine());
                alquileres.FechaDev = Convert.ToDateTime(reader.ReadLine());
                alquileres.Kilometros = Convert.ToInt32(reader.ReadLine());

                alquilers.Add(alquileres);

            }
            reader.Close();
        }
        public void CargarVehiculos()
        {
            StreamWriter vehiculosa = new StreamWriter(@"C:\\Users\\ACER\\Desktop\\U\\progra III\\laboratorio6-master\\bin\\Debug\Vehiculos.txt", true);
            try
            {
                vehiculosa.WriteLine(textBox1.Text);
                vehiculosa.WriteLine(textBox2.Text);
                vehiculosa.WriteLine(textBox3.Text);
                vehiculosa.WriteLine(textBox4.Text);
                vehiculosa.WriteLine(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            vehiculosa.Close();
        }
        public void MostrarVehiculos()
        {
            String fileName = "Vehiculos.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculos vehiculos = new Vehiculos();
                vehiculos.Placa = reader.ReadLine();
                vehiculos.Marca = reader.ReadLine();
                vehiculos.Modelo = Convert.ToInt32(reader.ReadLine());
                vehiculos.Color = reader.ReadLine();
                vehiculos.PrecioPerkm = Convert.ToInt32(reader.ReadLine());

                vehiculoss.Add(vehiculos);

            }
            reader.Close();
        }
        public void MostrarClientes()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientess;
            dataGridViewClientes.Refresh();
        }
        public void Mostrarvehiculos()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculoss;
            dataGridViewVehiculos.Refresh();
        }
        public void MostrarAlquiler()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewAlquiler.DataSource = null;
            dataGridViewAlquiler.DataSource = alquilers;
            dataGridViewAlquiler.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargarClientes();
            MostrarClientes();
            cargarAlquileres();
            MostrarAlquiler();
            Mostrarvehiculos();
            MostrarVehiculos();
        }
        public void CalculosAlq()
        {
            foreach (Alquiler alquiler in alquilers)
            {
                //int noAlquiler = alquiler.NoEmpleado;
                foreach (Clientes clientes in clientess)
                {
                    if (alquiler.Nit == clientes.Nit)
                    {
                        Reporte reporte = new Reporte();
                        reporte.Nit = alquiler.Nit;
                        reporte.Nombre = clientes.Nombre;
                        reporte.Placa = alquiler.Placa;
                        reporte.FechaAlq = alquiler.FechaAlq;
                        reporte.FechaDev = alquiler.FechaDev;
                        reporte.TotalPago = alquiler.Kilometros * 2000;

                        alquilers.Add(alquiler);
                    }
                }
            }
            dataGridViewCalculos.DataSource = null;
            dataGridViewCalculos.DataSource = alquilers;
            dataGridViewCalculos.Refresh();

        }
        public void maxAlquiler()
        {
            int mayor = alquiler.Max(a => a.nota);
            //Encuentra el valor mayor, y guarda todo el objeto con los datos del alumno que obtuvo esa nota, 

            //El resultado lo guarda en el objeto llamado mayor

            //Lo que se hace es ordenarlo descendentemente por la nota, y luego obtener el primer valor First()

            Alumno mayor = alumnos.OrderByDescending(a => a.nota).First();

            //Luego ya podríamos usar el objeto mayor para obtener los datos
            //suponiendo que tenemos unas etiquetas

            label1.text = mayor.Nombre;
            label2.text = mayor.nota
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
