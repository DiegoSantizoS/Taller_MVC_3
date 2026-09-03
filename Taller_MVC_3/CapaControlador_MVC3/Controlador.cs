using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_MVC3;

namespace CapaControlador_MVC3
{

    internal class Controlador
    {
        Sentencias sentencias = new Sentencias();
        public DataTable llenarDgv(string nombreTabla)
        {
            OdbcDataAdapter daControlador =  sentencias.llenartbl(nombreTabla);
            DataTable dtControlador = new DataTable();
            daControlador.Fill(dtControlador);
            return dtControlador;
        }

    }
}
