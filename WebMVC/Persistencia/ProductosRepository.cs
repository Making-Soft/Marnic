using WebMVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace WebMVC.Persistencia
{
    public class ProductosRepository
    {

        public List<Productos> Productos(int filtro)
        {
           
            Conn c = new Conn(ConfigurationManager.ConnectionStrings["ECommerce"].ConnectionString);
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder();
            qry.Append("select * from Productos where  Id_Categoria_Producto=");
            qry.Append(filtro);

            dt = c.GetTable(qry.ToString());
            List<Productos> lst = PopulateList(dt);
            c.Close();
            return lst; 
       
        }

        private List<Productos> PopulateList(DataTable dt)
        {
            List<Productos> Productos = new List<Productos>();
            foreach (DataRow item in dt.Rows)
            {
                Productos.Add(PopulateEntity(item));
            }
            return Productos;
        }

        private Productos PopulateEntity(DataRow row)
        {
            Entidades e = new Entidades();
            Productos Productos = new Productos();
            Productos.Id_Producto = e.GetInt(row, "Id_Producto");
            Productos.Id_Categoria_Producto = e.GetInt(row, "Id_Categoria_Producto");
            Productos.Link_Pago = e.GetString(row, "Link_Pago");
            Productos.Nombre = e.GetString(row, "Nombre");
            Productos.Precio = e.GetFloat(row, "Precio");
            Productos.Descripcion = e.GetString(row, "Descripcion");
            Productos.Ruta_Imagen = e.GetString(row, "Ruta_Imagen");
            Productos.Visible = e.GetBool(row, "Visible");

            return Productos;
        }

    }
}