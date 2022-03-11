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
    public partial class Clientes : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        string nameTxt = "Clientes.txt";

        public Clientes()
        {
            InitializeComponent();
            ReadTxtCliente();
            ActualizarGridCliente();
        }
        private void SaveTxtCliente()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (Cliente dato in clientes)
            {
                var AgregartxtCliente = dato.Nit + "|" + dato.Nombre + "|" + dato.Direccion;
                writer.WriteLine(AgregartxtCliente);
            }
            writer.Close();
        }
        private void ReadTxtCliente()
        {
            FileStream stream = new FileStream(nameTxt, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                var linea = reader.ReadLine();
                var partes = linea.Split('|');

                var dato = new Cliente();
                dato.Nit = partes[0];
                dato.Nombre = partes[1];
                dato.Direccion = partes[2];

                clientes.Add(dato);
            }
            reader.Close();
        }
        private void ActualizarGridCliente()
        {
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Refresh();
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();
            cl.Nit = textBoxNIT.Text;
            cl.Nombre = textBoxName.Text;
            cl.Direccion = textBoxAddress.Text;

            clientes.Add(cl);

            SaveTxtCliente();
            ActualizarGridCliente();

            textBoxNIT.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
        }
        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            Form vehiculos = new Vehiculos();
            vehiculos.Show();
            this.Hide();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
