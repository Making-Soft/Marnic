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
    public class ComponentesRepository
    {

        public List<Combos> Combos(string tipo, string param)
        {
            List<Combos> Combos = new List<Combos>();
            if(tipo=="Tipo_Categoria_0")
            {
                Conn c = new Conn(ConfigurationManager.ConnectionStrings["ECommerce"].ConnectionString);
                DataTable dt = new DataTable();
                StringBuilder qry = new StringBuilder();
                qry.Append("");
                dt = c.GetTable(qry.ToString());                
                foreach (DataRow row in dt.Rows)
                {
                    Combos.Add(PopulateEntity(row));
                }
                c.Close();
            }            

            return Combos;
        }


        private Combos PopulateEntity(DataRow row)
        {
            Entidades e = new Entidades();
            Combos Combos = new Combos();
            Combos.id = e.GetInt(row, "id");
            Combos.value = e.GetString(row, "value");

            return Combos;
        }

    }
}