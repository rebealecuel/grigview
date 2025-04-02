using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace grigview
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void ListaFamilia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ListaFamilia.DataSource = null;
            ListaFamilia.DataSource = acc.MostrarFamilia();
            
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarFamilia(txbBorrar.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminar");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.InsertarFamilia(txbName.Text, Convert.ToInt32(txbEdad.Text), txbGrado.Text, txbCabello.Text, txbOjos.Text))
                MessageBox.Show("Agregado con exito");
            else
                MessageBox.Show("Fallo al agregar");
        }

        private void btnActua_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarFamilia(txbName.Text, Convert.ToInt32(txbEdad.Text), txbGrado.Text, txbCabello.Text, txbOjos.Text))
                MessageBox.Show("Actualizado con exito");
            else
                MessageBox.Show("Fallo al actualizar");
        }
    }
}
