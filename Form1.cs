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
            if (acc.EliminarFamilia(txbNombre.Text))
                MessageBox.Show("Eliminado con exito");
            else
                MessageBox.Show("Fallo al eliminar");
        }
    }
}
