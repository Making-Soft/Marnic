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

        public List<Categoria> Categoria(string filtro)
        {
           
            Conn c = new Conn(ConfigurationManager.ConnectionStrings["ECommerce"].ConnectionString);
            DataTable dt = new DataTable();
            StringBuilder qry = new StringBuilder();
            qry.Append("select * from VW_Categorias_Productos where dependede ");
            qry.Append(filtro);
            dt = c.GetTable(qry.ToString());
            List<Categoria> lst = PopulateList(dt);
            c.Close();
            return lst; 
        }

        private List<Categoria> PopulateList(DataTable dt)
        {
            List<Categoria> Categoria = new List<Categoria>();
            foreach (DataRow item in dt.Rows)
            {
                Categoria.Add(PopulateEntity(item));
            }
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
            Categoria.Cantidad = e.GetInt(row, "Cantidad");
            Categoria.Descripcion = e.GetString(row, "Descripcion");           
            ProductosRepository tr = new ProductosRepository();
            Categoria.Productos = tr.Productos(Categoria.Id_Categoria_Producto);
            return Categoria;
        }
        
    }
}