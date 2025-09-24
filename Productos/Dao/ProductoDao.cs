using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Productos.Modelos;

namespace Productos.Dao
{
    public class ProductoDao
    {
        private static int TAM = 5;
        private Producto[] carrito = new Producto[TAM];
        private int pos = 0;
        public string error = "";
        public void Agregar(Producto prod)
        {
            if (pos < TAM)
            {
                carrito[pos++] = prod;
            }
            else Console.WriteLine("No se pueden agregar mas productos");
            
        }
        public Producto[] VerCarrito()
        {
            return carrito;
        }
    }   

}
