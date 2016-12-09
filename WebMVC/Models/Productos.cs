using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Models
{
    public class Productos
    {      
            
        public int Id_Producto {get;set;}
        public int Id_Categoria_Producto{get;set;}
        public string Descripcion{get;set;}
        public string Nombre{get;set;}
        public float Precio{get;set;}
        public string Link_Pago{get;set;}
        public bool Visible{get;set;}
        public string Ruta_Imagen { get; set; }
        
    }
}