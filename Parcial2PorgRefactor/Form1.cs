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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarNuevaLocalidad formularioNuevaLocalidad = new agregarNuevaLocalidad();
            formularioNuevaLocalidad.Show();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable = Localidades.buscarTodasLasLocalidades();
            LlenarGrilla(dTable);
        }

        private void LlenarGrilla(DataTable dTable)
        {
            dgvLocalidades.DataSource = null;
            dgvLocalidades.DataSource = dTable;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvLocalidades.SelectedRows.Count > 0)
            {
                formularioModificarLocalidad formularioModificarLocalidad = new formularioModificarLocalidad(Convert.ToInt32(dgvLocalidades.CurrentRow.Cells[0].Value));
                formularioModificarLocalidad.Show();
            }
            else
            {
                MessageBox.Show("Seleccione una localidad");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgvLocalidades.Rows.Count > 0)
            {
                int idEliminar;
                idEliminar = Convert.ToInt32(dgvLocalidades.CurrentRow.Cells[0].Value);
                DialogResult confirmarEliminacion = MessageBox.Show("¿Desea eliminar esta localidad?", "Advertencia", MessageBoxButtons.YesNo);

                if (confirmarEliminacion == DialogResult.Yes)
                {
                    Localidades.eliminarLocalidad(idEliminar);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una localidad");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int idBuscado;

            if (!int.TryParse(txtId.Text.Trim(), out idBuscado))
            {
                MessageBox.Show("El codigo ingresado no es valido");
            }

            DataTable dTable = new DataTable();
            dTable = Localidades.buscarId(idBuscado);
            LlenarGrilla(dTable);
        }

        private void btnBuscarIntendente_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable = Localidades.buscarIntendente(txtBuscarIntendente.Text.Trim());
            LlenarGrilla(dTable);
        }

        private void btnObrasPublicas_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable = Localidades.buscarObrasPublicas(txtObrasPublicas.Text.Trim());
            LlenarGrilla(dTable);
        }

        private void btnBuscarCodPost_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            dTable = Localidades.buscarCodPostal(Convert.ToInt32(txtBuscarCodPostal.Text.Trim()));
            LlenarGrilla(dTable);
        }
    }
}
