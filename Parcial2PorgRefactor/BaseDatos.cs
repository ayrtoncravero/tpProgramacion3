using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2PorgRefactor
{
    class BaseDatos
    {
        static SqlConnection conexionDB = new SqlConnection();

        static private bool ConectarDB()
        {
            try
            {
                conexionDB.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=RefactorParcial2;Integrated Security=True";
                conexionDB.Open();
                return true;
            }
            catch(Exception f)
            {
                return false;
            }
        }

        static private void DesconectarDB()
        {
            try
            {
                conexionDB.Close();
            }
            catch (Exception f)
            {

            }
        }

        static public bool EfectuarConsultaDB(string cadenaSQL)
        {
            bool cumplio;

            try
            {
                ConectarDB();
                SqlDataAdapter adapter = new SqlDataAdapter(cadenaSQL, conexionDB);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);
                adapter.Update(dTable);

                cumplio = true;
            }
            catch (Exception f)
            {
                cumplio = false;
            }
            finally
            {
                DesconectarDB();
            }

            return cumplio;
        }

        static public DataTable Buscar(string cadenaSQL)
        {
            DataTable dTable = new DataTable();

            try
            {
                ConectarDB();
                SqlDataAdapter adapter = new SqlDataAdapter(cadenaSQL, conexionDB);
                adapter.Fill(dTable);
                adapter.Update(dTable);
            }
            catch (Exception f)
            {
                return null;
            }
            finally
            {
                DesconectarDB();
            }

            return dTable;
        }
    }
}
