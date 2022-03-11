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
    public partial class Vehiculos : Form
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        string nameTxt = "DataVehiculos.txt";
        Random codigo = new Random();
        public Vehiculos()
        {
            InitializeComponent();
            ReadTxtVehiculo();
            ActualizarGridVehiculo();

            string letras = "";
            char dato;
            int valor = 0;

            for (int i = 0; i < 3; i++)
            {
                valor = Convert.ToInt32(codigo.Next(65, 90));
                dato = Convert.ToChar(valor);
                letras = letras + dato.ToString();
                codigo = new Random(i);
            }
            letras = letras + "-";
            valor = Convert.ToInt32(codigo.Next(100, 999));
            letras = letras + valor.ToString();

            textBoxPlaca.Text = letras;
        }
        private void SaveTxtVehiculo()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Vehiculo dato in vehiculos)
            {
                var AgregartxtVehiculo = dato.Placa + "|" + dato.Marca + "|" + dato.Modelo + "|" + dato.Color + "|" + dato.PrecioxKm;
                writer.WriteLine(AgregartxtVehiculo);
            }
            writer.Close();
        }
        private void ReadTxtVehiculo()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Vehiculo();
                dato.Placa = partes[0];
                dato.Marca = partes[1];
                dato.Modelo = partes[2];
                dato.Color = partes[3];
                dato.PrecioxKm = decimal.Parse(partes[4]);

                vehiculos.Add(dato);
            }
            reader.Close();
        }
        private void ActualizarGridVehiculo()
        {
            dataGridViewVehiculo.DataSource = null;
            dataGridViewVehiculo.Refresh();
            dataGridViewVehiculo.DataSource = vehiculos;
            dataGridViewVehiculo.Refresh();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Vehiculo vh = new Vehiculo();
            vh.Placa = textBoxPlaca.Text;
            vh.Marca = comboBoxMarca.Text;
            vh.Modelo =numericUpDownModelo.Text;
            vh.Color = comboBoxColor.Text;
            vh.PrecioxKm = Convert.ToDecimal(textBoxPxKm.Text);

            vehiculos.Add(vh);

            //placa de carro automatica
            string letras = "";
            char dato;
            int valor = 0;

            for (int i = 0; i < 3; i++)
            {
                valor = Convert.ToInt32(codigo.Next(65, 90));
                dato = Convert.ToChar(valor);
                letras = letras + dato.ToString();
                codigo = new Random(i);
            }
            letras = letras + "-";
            valor = Convert.ToInt32(codigo.Next(100, 999));
            letras = letras + valor.ToString();

            textBoxPlaca.Text = letras;

            SaveTxtVehiculo();
            ActualizarGridVehiculo();

            textBoxPlaca.Text = letras;
            comboBoxMarca.Text = "";
            numericUpDownModelo.Value = 0;
            comboBoxColor.Text = "";
            textBoxPxKm.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form alquilar = new Alquileres();
            alquilar.Show();
            this.Hide();
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form homePage = new Clientes();
            homePage.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
