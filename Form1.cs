using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2doparcial
{
    public partial class Form1 : Form
    {
        public class Cliente
        {
            public string Codigo { get; set; }
            public decimal Importe { get; set; }
            public string Producto { get; set; } 

            public override string ToString()
            {
                return $"{Codigo} - {Producto} - ${Importe:N2}";
            }
        }

        private Queue<Cliente> colaClientes = new Queue<Cliente>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtImporte.Text) ||
                string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Debe completar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtImporte.Text, out decimal importe))
            {
                MessageBox.Show("El importe debe ser un NUMERO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cliente nuevoCliente = new Cliente()
            {
                Codigo = txtCodigo.Text,
                Importe = importe,
                Producto = txtProducto.Text
            };

            colaClientes.Enqueue(nuevoCliente);

            lstCola.Items.Add(nuevoCliente.ToString());

            txtCodigo.Clear();
            txtImporte.Clear();
            txtProducto.Clear();
            txtCodigo.Focus();
            }
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (colaClientes.Count == 0)
            {
                MessageBox.Show("No hay clientes para cobrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Cliente clienteCobrado = colaClientes.Dequeue();

            MessageBox.Show($"Cobro Cliente: {clienteCobrado.Producto}\nCódigo: {clienteCobrado.Codigo}\nImporte cobrado: ${clienteCobrado.Importe:N2}",
                            "Cliente Cobrado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (lstCola.Items.Count > 0)
            {
                lstCola.Items.RemoveAt(0);
            }
        }
    }
}
