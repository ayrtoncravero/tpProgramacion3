using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2PorgRefactor
{
    public partial class formularioModificarLocalidad : Form
    {
        Localidades localidad = new Localidades();

        public formularioModificarLocalidad(int idLocalidad)
        {
            InitializeComponent();

            cmbProvincia.ValueMember = "id";
            cmbProvincia.DisplayMember = "nombreProvincia";
            cmbProvincia.DataSource = Provincias.buscarTodas();

            if (idLocalidad > 0)
            {
                DataTable dTable = new DataTable();
                dTable = Localidades.buscarId(idLocalidad);

                if (dTable.Rows.Count > 0)
                {
                    localidad.Id = Convert.ToInt32(dTable.Rows[0]["id"]);
                    localidad.Provincia = Convert.ToInt32(dTable.Rows[0]["provincia"]);
                    localidad.NombreLocalidad = dTable.Rows[0]["nombreLocalidad"].ToString();
                    localidad.CodPostal = Convert.ToInt32(dTable.Rows[0]["codPostal"]);
                    localidad.NombreIntendente = dTable.Rows[0]["nombreIntendente"].ToString();
                    localidad.ObrasPublicas = dTable.Rows[0]["obrasPublicas"].ToString();

                    txtId.Text = localidad.Id.ToString();
                    cmbProvincia.SelectedValue = localidad.Provincia;
                    txtNombre.Text = localidad.NombreLocalidad;
                    txtCodPostal.Text = localidad.CodPostal.ToString();
                    txtNombreIntendente.Text = localidad.NombreIntendente;
                    txtObrasPublicas.Text = localidad.ObrasPublicas;
                }
            }
            else
            {
                MessageBox.Show("El codigo de localidad no es valido");
            }
        }

        private void formularioModificarLocalidad_Load(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool cumplio = true;

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre de la localidad no puede ser vacio");
                cumplio = false;
            }

            if (txtCodPostal.Text.Trim() == "")
            {
                MessageBox.Show("El codigo postal no puede ser vacio");
                cumplio = false;
            }

            if (txtNombreIntendente.Text.Trim() == "")
            {
                MessageBox.Show("El nombre del intendente no puede ser vacio");
                cumplio = false;
            }

            if (txtObrasPublicas.Text.Trim() == "")
            {
                MessageBox.Show("La descripcion de las obras publicas, no pueden ser vacias");
                cumplio = false;
            }

            if (cumplio)
            {
                localidad.Provincia = Convert.ToInt32(cmbProvincia.SelectedValue);
                localidad.NombreLocalidad = txtNombre.Text.Trim();
                localidad.CodPostal = Convert.ToInt32(txtCodPostal.Text.Trim());
                localidad.NombreIntendente = txtNombreIntendente.Text.Trim();
                localidad.ObrasPublicas = txtObrasPublicas.Text.Trim();

                if (localidad.modificarLocalidad())
                {
                    MessageBox.Show("La localidad se modifico");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al modificar la localidad");
                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
