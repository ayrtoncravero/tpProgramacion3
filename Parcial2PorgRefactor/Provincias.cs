using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2PorgRefactor
{
    class Provincias
    {
        #region Atributos
        private int id;
        private string nombreProvincia;
        #endregion

        #region Propiedades
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string NombreProvincia
        {
            set
            {
                nombreProvincia = value;
            }
            get
            {
                return nombreProvincia;
            }
        }
        #endregion

        #region Constructores
        public Provincias(string pNombreProvincias)
        {
            NombreProvincia = pNombreProvincias;
        }
        #endregion

        #region Metodos
        public bool crearProvincia()
        {
            bool cumplio;
            string consultaDB = "INSERT INTO Provincias (nombreProvincia) VALUES ('" + NombreProvincia + "')";
            cumplio = BaseDatos.EfectuarConsultaDB(consultaDB);
            return cumplio;
        }

        public bool modificarProvincia()
        {
            bool cumplio;
            string consultaDB = "UPDATE Provincias SET nombreProvincia = '" + NombreProvincia + "' WHERE id = " + Id;
            cumplio = BaseDatos.EfectuarConsultaDB(consultaDB);
            return cumplio;
        }

        static public bool eliminarProvincia(int idEliminar)
        {
            bool cumplio;
            string consultaDB = "DELETE FROM Provincias WHERE id = " + idEliminar;
            cumplio = BaseDatos.EfectuarConsultaDB(consultaDB);
            return cumplio;
        }

        static public DataTable buscarTodas()
        {
            DataTable dTable = new DataTable();
            string consultaDB = "SELECT * FROM Provincias";
            dTable = BaseDatos.Buscar(consultaDB);
            return dTable;
        }

        static public DataTable buscarPorId(int idBuscado)
        {
            DataTable dTable = new DataTable();
            string consultaDB = "SELECT * FROM Provincias WHERE id = " + idBuscado;
            dTable = BaseDatos.Buscar(consultaDB);
            return dTable;
        }

        static public DataTable buscarProvincia(string provinciaBuscada)
        {
            DataTable dTable = new DataTable();
            string consultaDB = "SELECT * FROM Provincias WHERE  nombreProvincia '" + provinciaBuscada + "'";
            dTable = BaseDatos.Buscar(consultaDB);
            return dTable;
        }
        #endregion
    }
}
