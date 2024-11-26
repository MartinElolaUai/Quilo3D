using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class Acceso
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ELOLA;Initial Catalog=QUILO3D;Integrated Security=True;");

        public void abrir()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void cerrar()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public DataTable Leer(string sp, SqlParameter[] param)
        {
            abrir();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = sp;
            da.SelectCommand.Connection = connection;
            if (param != null)
            {
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddRange(param);
            }
            da.Fill(dt);
            cerrar();

            return dt;
        }

        public int Escribir(string sp, SqlParameter[] parametro)
        {
            int status = 0;
            abrir();
            SqlCommand cmd = new SqlCommand();
            SqlTransaction ts = connection.BeginTransaction();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Transaction = ts;
            if (parametro != null)
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddRange(parametro);
            }

            try
            {
                status = cmd.ExecuteNonQuery();
                ts.Commit();
            }
            catch (SqlException ex)
            {
                ts.Rollback();
            }
            finally
            {
                cerrar();
            }

            return status;
        }

        public void ExportarSPXML(string sp, string fileName, SqlParameter[] parametros) 
        {
            try 
            {
                String defaulPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                String filePath = defaulPath + "\\" + fileName + ".xml";

                Leer(sp, parametros).WriteXml(filePath);

                MessageBox.Show("Exportación XML exitosa", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error de exportación XML", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
