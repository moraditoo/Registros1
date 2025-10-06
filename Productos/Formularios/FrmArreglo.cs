using Productos.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos.Formularios
{
    public partial class FrmArreglo : Form
    {
        public FrmArreglo()
        {
            InitializeComponent();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (int.TryParse(tbEdad.Text, out int edad) && edad > 0)
                    {
                        EdadDao.edades[EdadDao.pos++] = edad;
                    }
                    else
                    {
                        MessageBox.Show("Solo se aceptan numeros enteros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("No se pueden ingresar más edades", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally 
                {                     
                    tbEdad.Clear();
                    tbEdad.Focus();
                    mostrarEdades();

                    double promedio = EdadDao.edades.Average();
                    lblPromedio.Text = $"Promedio: {promedio}";
                    //prueba
                }
            }
        }
        
        public void mostrarEdades()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = EdadDao.edades;
            lbEdades.Refresh();
        }

        private void FrmArreglo_Load(object sender, EventArgs e)
        {
            mostrarEdades();
        }

        private void tbEdad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
