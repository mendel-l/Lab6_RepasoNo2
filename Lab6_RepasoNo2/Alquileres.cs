using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_RepasoNo2
{
    public partial class Alquileres : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        List<Alquiler> alquileres = new List<Alquiler>();
        string nameTxt = "Alquileres.txt";
        public Alquileres()
        {
            InitializeComponent();
            ReadTxtDatosAlquiler();
            ActualizarGred();
            Clientes();
            Vehiculos();
        }
        private void SaveTxtDatosAlquiler()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Alquiler dato in alquileres)
            {
                var AgregartxtCliente = dato.Nit + "|" + dato.Nombre + "|" + dato.Placa + "|" + dato.FechaAlquiler 
                                        + "|" + dato.FechaDevolucion + "|" + dato.KmRecorridos + "|" + dato.PrecioxKm + "|" + dato.Total;
                writer.WriteLine(AgregartxtCliente);
            }
            writer.Close();
        }
        private void ReadTxtDatosAlquiler()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Alquiler();
                dato.Nit = partes[0];
                dato.Nombre = partes[1];
                dato.Placa = partes[2];
                dato.FechaAlquiler = DateTime.Parse(partes[3]);
                dato.FechaDevolucion = DateTime.Parse(partes[4]);
                dato.KmRecorridos = decimal.Parse(partes[5]);
                dato.PrecioxKm = decimal.Parse(partes[6]);
                dato.Total = decimal.Parse(partes[7]);

                alquileres.Add(dato);   
            }
            reader.Close();
        }
        void Clientes()
        {
            FileStream stream = new FileStream(@"Clientes.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Cliente();
                dato.Nit = partes[0];
                dato.Nombre = partes[1];

                clientes.Add(dato);
            }
            reader.Close();
            comboBoxNit.DataSource = clientes;
            comboBoxNit.DisplayMember = "Nit";
            comboBoxNit.Refresh();
        }
        void Vehiculos()
        {
            FileStream stream = new FileStream(@"DataVehiculos.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Vehiculo();
                dato.Placa = partes[0];
                dato.PrecioxKm = decimal.Parse(partes[4]);

                vehiculos.Add(dato);
            }
            reader.Close();
            comboBoxPlaca.DataSource = vehiculos;
            comboBoxPlaca.DisplayMember = "Placa";
            comboBoxPlaca.Refresh();
        }
        void ActualizarGred()
        {
            dataGridViewResultado.DataSource = null;
            dataGridViewResultado.Refresh();
            dataGridViewResultado.DataSource = alquileres;
            dataGridViewResultado.Refresh();
        }
        private void btnMostrar_Click(object sender, EventArgs e)    
        {
            Alquiler al = new Alquiler();
            al.Nit = comboBoxNit.Text;
            al.Nombre = ((Cliente)comboBoxNit.SelectedValue).Nombre; //casting
            al.Placa = comboBoxPlaca.Text;
            al.FechaAlquiler = dateTimePickerAlquiler.Value;
            al.FechaDevolucion = dateTimePickerDevolucion.Value;
            al.KmRecorridos = decimal.Parse(textBoxKmRecorridos.Text);
            al.PrecioxKm = ((Vehiculo)comboBoxPlaca.SelectedValue).PrecioxKm;

            al.Total = decimal.Parse(textBoxKmRecorridos.Text) * ((Vehiculo)comboBoxPlaca.SelectedValue).PrecioxKm;

            alquileres.Add(al);

            ActualizarGred();
            SaveTxtDatosAlquiler();
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form vehiculos = new Vehiculos();
            vehiculos.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonNextForm_Click(object sender, EventArgs e)
        {
            Form clientes = new Clientes();
            clientes.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mayor = Convert.ToInt32(alquileres.Max(x => x.KmRecorridos));

            labelMayorRecorrido.Text = "El mayor recorrido fue de " + mayor.ToString();
        }

        private void textBoxKmRecorridos_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxKmRecorridos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("ERROR! solo se permiten datos de tipo numericos");
                e.Handled = true;
                return;
            }
        }
    }
}
