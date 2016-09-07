using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMVC.Persistencia
{
    public class Entidades
    {
        public String GetString(System.Data.DataRow row, string field)
        {
            try
            {
                return row.IsNull(field) ? null : (string)row[field];
            }
            catch (ArgumentException ex)
            {
                return null;
            }
        }

        public int GetInt(System.Data.DataRow row, string field)
        {
            return row.IsNull(field) ? 0 : (int)row[field];
        }

        public double Getdbl(System.Data.DataRow row, string field)
        {
            return row.IsNull(field) ? 0 : (double)row[field];
        }

        public long GetLng(System.Data.DataRow row, string field)
        {
            return row.IsNull(field) ? 0 : (long)row[field];
        }

        public decimal GetDcm(System.Data.DataRow row, string field)
        {
            return row.IsNull(field) ? 0 : (decimal)row[field];
        }

        
        public DateTime? GetDateTimeNull(System.Data.DataRow row, string field)
        {
            if (row.IsNull(field))
            {
                return null;
            }
            return (DateTime)row[field];
        }

        public DateTime GetDateTime(System.Data.DataRow row, string field)
        {
            if (row.IsNull(field))
            {
                return new DateTime();
            }
            return (DateTime)row[field];
        }

        public bool ValorBool(System.Data.DataRow row, string field)
        {
            if (row.IsNull(field))
            {
                return false;
            }

            return true;
        }

        public bool GetBool(System.Data.DataRow row, string field)
        {
            try
            {
                return row.IsNull(field) ? false : (bool)row[field];
            }
            catch (ArgumentException ex)
            {
                return false;
            }
        }

    }
}