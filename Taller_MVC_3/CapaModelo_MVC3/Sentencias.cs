using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC3
{
    public class Sentencias
    {
        Conexion conn = new Conexion();
        public OdbcDataAdapter llenartbl(string nombreTable)
        {
            string sSQL = "SELECT * FROM " + nombreTable + ";";
            OdbcDataAdapter daSentencias = new OdbcDataAdapter(sSQL, conn.conexion());
            return daSentencias;
        }
    }
}
