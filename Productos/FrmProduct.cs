using Productos.Dao;
using Productos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Productos
{   
    
    public partial class FrmProduct : Form
    {
        ProductoDao dao = new ProductoDao();
        public FrmProduct()
        {
            InitializeComponent();
            LlenarGrid();
        }
        public void LlenarGrid()
        {
            this.dgvRegistros.DataSource = dao.VerCarrito();
            this.dgvRegistros.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Producto prod = new Producto();
                prod.Nombre = tbNombre.Text.ToUpper();
                prod.Precio = double.Parse(tbPrecio.Text);
                prod.Codigo = tbCodigo.Text.ToUpper();
                prod.IVA = chkIVA.Checked;
                dao.Agregar(prod);
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LlenarGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
