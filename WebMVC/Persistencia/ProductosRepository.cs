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

        public List<Productos_nivel1> Productos_nivel1(string filtro)
        {
            List<Productos_nivel1> Productos_nivel1 = new List<Productos_nivel1>();

            Conn c = new Conn(ConfigurationManager.ConnectionStrings["ECommerce"].ConnectionString);
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder();
            qry.Append("select * from obtener_productos_Nivel_1 ");
            qry.Append(filtro);

            dt = c.GetTable(qry.ToString());                
            foreach (DataRow row in dt.Rows)
            {
                Productos_nivel1.Add(PopulateEntity(row));
            }
            c.Close();


            return Productos_nivel1;
        }


        private Productos_nivel1 PopulateEntity(DataRow row)
        {
            Entidades e = new Entidades();
            Productos_nivel1 Productos_nivel1 = new Productos_nivel1();

            Productos_nivel1.Id_Sitio = e.GetInt(row, "Id_Sitio");
            Productos_nivel1.Id_Producto = e.GetInt(row, "Id_Producto");
            Productos_nivel1.Id_Categoria_Producto_c0 = e.GetInt(row, "Id_Categoria_Producto_c0");
            Productos_nivel1.Id_Categoria_Producto_c1 = e.GetInt(row, "Id_Categoria_Producto_c1");
            Productos_nivel1.CategoriaCompleta = e.GetString(row, "CategoriaCompleta");
            Productos_nivel1.Categoria_c0 = e.GetString(row, "Categoria_c0");
            Productos_nivel1.Categoria_c1 = e.GetString(row, "Categoria_c1");
            Productos_nivel1.Descripcion = e.GetString(row, "Descripcion");
            Productos_nivel1.Nombre = e.GetString(row, "Nombre");
            Productos_nivel1.Precio = e.Getdbl(row, "Precio");
            Productos_nivel1.Link_Pago = e.GetString(row, "Link_Pago");
            Productos_nivel1.Ruta_Imagen = e.GetString(row, "Ruta_Imagen");
            Productos_nivel1.Visible = e.GetBool(row, "Visible");

             return Productos_nivel1;
        }

    }
}