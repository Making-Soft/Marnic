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
    public class CategoriaRepository
    {

        public List<Categoria> ObtenerCategoria(int nivel)
        {
            List<Categoria> Categoria = new List<Categoria>();

            Conn c = new Conn(ConfigurationManager.ConnectionStrings["ECommerce"].ConnectionString);
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder();
            qry.Append("select * from obtener_Categorias_Nivel_1");
            qry.Append(" where nivel=");
            qry.Append(nivel);
            qry.Append(" Order by dependede");

            dt = c.GetTable(qry.ToString());                
            foreach (DataRow row in dt.Rows)
            {
                Categoria.Add(PopulateEntity(row));
            }
            c.Close();


            return Categoria;
        }


        private Categoria PopulateEntity(DataRow row)
        {
            Entidades e = new Entidades();
            Categoria Categoria = new Categoria();

            Categoria.Id_Categoria_Producto = e.GetInt(row, "Id_Categoria_Producto");
            Categoria.Id_Sitio = e.GetInt(row, "Id_Sitio");
            Categoria.Nivel = e.GetInt(row, "Nivel");
            Categoria.Dependede = e.GetInt(row, "Dependede");
            Categoria.Descripcion = e.GetString(row, "Descripcion");
            Categoria.Cantidad = e.GetInt(row, "Cantidad");
            Categoria.visible = e.GetBool(row, "visible");
            Categoria.CategoriaCompleta = e.GetString(row, "CategoriaCompleta");

            return Categoria;
        }

    }
}