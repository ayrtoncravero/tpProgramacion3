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
    public partial class agregarNuevaLocalidad : Form
    {
        public agregarNuevaLocalidad()
        {
            InitializeComponent();
            cmbProvincia.ValueMember = "id";
            cmbProvincia.DisplayMember = "nombreProvincia";
            cmbProvincia.DataSource = Provincias.buscarTodas();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool cumplio = true;
            int codigoPostal;

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre de la localidad no puede ser vacio");
                cumplio = false;
            }

            if (!int.TryParse(txtCodPostal.Text.Trim(), out codigoPostal))
            {
                MessageBox.Show("El codigo postal no puede ser vacio, y no pueden ser letras");
                cumplio = false;
            }

            if (txtNombreIntendente.Text.Trim() == "")
            {
                MessageBox.Show("El nombre del intendente no puede ser vacio");
                cumplio = false;
            }

            if(txtObrasPublicas.Text.Trim() == "")
            {
                MessageBox.Show("Las obras publicas no pueden ser vacias");
                cumplio = false;
            }


            if (cumplio)
            {
                Localidades nuevo = new Localidades(Convert.ToInt32(cmbProvincia.SelectedValue), txtNombre.Text.Trim(), codigoPostal, txtNombreIntendente.Text.Trim(), txtObrasPublicas.Text.Trim());
                if (nuevo.guardarLocalidad())
                {
                    MessageBox.Show("La localidad se guardo");
                    Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar la localidad");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarNuevaLocalidad_Load(object sender, EventArgs e)
        {

        }
    }
}
