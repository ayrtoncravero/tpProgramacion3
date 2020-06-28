using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2PorgRefactor
{
    class Localidades
    {
        #region Atributos
        private int id;
        private int provincia;
        private string nombreLocalidad;
        private int codPostal;
        private string nombreIntendente;
        private string obrasPublicas;
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

        public int Provincia
        {
            set
            {
                provincia = value;
            }
            get
            {
                return provincia;
            }
        }

        public string NombreLocalidad
        {
            set
            {
                nombreLocalidad = value;
            }
            get
            {
                return nombreLocalidad;
            }
        }

        public int CodPostal
        {
            set
            {
                codPostal = value;
            }
            get
            {
                return codPostal;
            }
        }

        public string NombreIntendente
        {
            set
            {
                nombreIntendente = value;
            }
            get
            {
                return nombreIntendente;
            }
        }

        public string ObrasPublicas
        {
            set
            {
                obrasPublicas = value;
            }
            get
            {
                return obrasPublicas;
            }
        }
        #endregion

        #region Constructores
        public Localidades()
        {

        }
        public Localidades(int pProvincia, string pNombreLocalidad, int pCodPostal, string pNombreIntendente, string pObrasPublicas)
        {
            Provincia = pProvincia;
            NombreLocalidad = pNombreLocalidad;
            CodPostal = pCodPostal;
            NombreIntendente = pNombreIntendente;
            ObrasPublicas = pObrasPublicas;
        }
        #endregion

        #region Metodos
        public bool guardarLocalidad()
        {
            bool cumplido;
            string consultaDB = "INSERT INTO Localidades (provincia, nombreLocalidad, codPostal, nombreIntendente, obrasPublicas)" +
                " VALUES (" + Provincia + ", '" + NombreLocalidad + "', " + CodPostal + ", '" + nombreIntendente + "', '" + ObrasPublicas + "')";
            cumplido = BaseDatos.EfectuarConsultaDB(consultaDB);
            return cumplido;
        }

        public bool modificarLocalidad()
        {
            string consultaDB = string.Format("UPDATE Localidades SET provincia = {0} ,nombreLocalidad = '{1}', codPostal = {2}, nombreIntendente = '{3}', obrasPublicas = '{4}' WHERE Localidades.id = {5}", Provincia, NombreLocalidad, CodPostal, NombreIntendente, ObrasPublicas, Id);
            return BaseDatos.EfectuarConsultaDB(consultaDB);
        }

        static public DataTable buscarId(int idBuscado)
        {
            string consultaDB = "SELECT Localidades.id, Localidades.nombreLocalidad, Localidades.provincia, Localidades.codPostal, Localidades.nombreIntendente, Localidades.obrasPublicas, Provincias.nombreProvincia FROM Localidades INNER JOIN Provincias ON Localidades.provincia = Provincias.id WHERE Localidades.id = " + idBuscado;
            return BaseDatos.Buscar(consultaDB);
        }

        static public DataTable buscarCodPostal(int codPostal)
        {
            string consultaDB = "SELECT provincia" +
                "FROM Localidades" +
                "INNER JOIN Provincias ON Localidades.provincia = Provincias.id WHERE codPostal = " + codPostal;
            return BaseDatos.Buscar(consultaDB);
        }

        static public DataTable buscarIntendente(string intendenteBuscado)
        {
            string consultaDB = "SELECT Localidades.id, Localidades.provincia, Localidades.nombreLocalidad, Localidades.codPostal, Localidades.nombreIntendente, Localidades.obrasPublicas, Provincias.nombreProvincia FROM Localidades INNER JOIN Provincias ON Localidades.provincia = Provincias.id WHERE nombreIntendente = '" + intendenteBuscado + "'";
            return BaseDatos.Buscar(consultaDB);
        }

        static public DataTable buscarObrasPublicas(string obraPublica)
        {
            string consultaDB = "SELECT Localidades.id, Localidades.nombreLocalidad, Localidades.provincia, Localidades.codPostal, Localidades.nombreIntendente, Localidades.obrasPublicas, Provincias.nombreProvincia FROM Localidades INNER JOIN Provincias ON Localidades.provincia = Provincias.id WHERE Localidades.obrasPublicas LIKE '%" + obraPublica + "%'";
            return BaseDatos.Buscar(consultaDB);
        }

        static public DataTable buscarTodasLasLocalidades()
        {
            string consultaDB = "SELECT * FROM Localidades";
            return BaseDatos.Buscar(consultaDB);
        }

        static public DataTable buscarLocalidad(string localidadBuscada)
        {
            string consultaDB = "SELECT provincia" +
                "FROM Localidades" +
                "INNER JOIN Provincias ON Localidades.provincia = Provincias.id WHERE nombreLocalidad = '" + localidadBuscada + "'";
            return BaseDatos.Buscar(consultaDB);
        }

        static public bool eliminarLocalidad(int LocalidadABorar)
        {
            string consultaDB = "DELETE FROM Localidades WHERE id = " + LocalidadABorar;
            return BaseDatos.EfectuarConsultaDB(consultaDB);
        }
        #endregion
    }
}
