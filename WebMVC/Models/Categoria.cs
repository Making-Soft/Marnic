using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebMVC.Models
{
    public class Categoria
    {
        public int Id_Categoria_Producto { get; set; }
        public int Id_Sitio { get; set; }
        public int Nivel { get; set; }
        public int Dependede { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string CategoriaCompleta { get; set; }
        public bool visible { get; set; }
    }
}
