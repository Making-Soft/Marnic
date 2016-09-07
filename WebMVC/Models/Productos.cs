using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Productos_nivel1
    {      
            
        public int Id_Sitio { get; set; }
        public int Id_Producto { get; set; }
        public int Id_Categoria_Producto_c0 { get; set; }
        public int Id_Categoria_Producto_c1 { get; set; }
        public string CategoriaCompleta { get; set; }
        public string Categoria_c0 { get; set; }
        public string Categoria_c1 { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public string Link_Pago { get; set; }
        public string Ruta_Imagen { get; set; }        
        public bool Visible { get; set; }
        
    }
}