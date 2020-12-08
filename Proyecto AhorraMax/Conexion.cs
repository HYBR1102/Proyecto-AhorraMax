using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_AhorraMax
{
    class Conexion
    {
        private OleDbConnection conexion;

        public Conexion()
        {
            //Cadena de conexión: Cambia dependiendo el equipo en donde se ejecute.
            string cadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Heidy\\OneDrive\\Escritorio\\DEXTER\\Supermercado-AhorraMaxfull3.1.accdb";
            this.conexion = new OleDbConnection(cadenaDeConexion);
        }

        public void conectar()
        {
            this.conexion.Open();
        }

        public void cerrar()
        {
            this.conexion.Close();
        }

        public String[] obtenerUnaSolaFila(string sql)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = this.conexion;
            cmd.CommandText = @sql;

            OleDbDataReader dr = cmd.ExecuteReader();

            String[] valores = new String[dr.FieldCount];

            if (dr.Read())
            {
                for (int i = 0; i < valores.Length; i++)
                {
                    valores[i] = dr.GetValue(i).ToString();
                }

            }
            return valores;
        }

        public DataSet ejecutarQuery(String query)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, this.conexion);

            DataSet d = new DataSet();
            adapter.Fill(d);

            return d;
        }

        public bool ejecutarInstruccion(String instruccion)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = this.conexion;
            cmd.CommandText = @instruccion;
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}

