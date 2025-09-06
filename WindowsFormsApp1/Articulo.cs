using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Articulo
    {
        public int IDArticulo { get; set; }
        public string NombreArt { get; set; }
        public string DescripcionArt { get; set; }
        public decimal PrecioArt { get; set; }
        public Categoria CategoriaArt { get; set; }
        public Marca MarcaArt { get; set; }
        public Imagen ImagenArt { get; set; }    
    }

}
