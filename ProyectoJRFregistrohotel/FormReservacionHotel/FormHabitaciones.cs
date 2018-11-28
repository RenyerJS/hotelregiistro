using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaDatos;
using capaEntidades;
using capaNegocio;

namespace FormReservacionHotel
{
    public partial class FormHabitaciones : Form
    {
        logicaNegocioHabitaciones lN = new logicaNegocioHabitaciones();
        public FormHabitaciones()
        {
            InitializeComponent();
        }

        private void FormHabitaciones_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            lbid.Visible = false;
            dgvHabitaciones.DataSource = lN.ListaHabitacion();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Habitaciones> lista = lN.BuscaHabitacionDatos(txtBuscar.Text);
            dgvHabitaciones.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Visible = true;
            txtId.Enabled = false;
            lbid.Visible = true;

            txtPrecio.Text = dgvHabitaciones.CurrentRow.Cells["Precio"].Value.ToString();
            txtCodigo.Text = dgvHabitaciones.CurrentRow.Cells["Codigo"].Value.ToString();
            txtTipo.Text = dgvHabitaciones.CurrentRow.Cells["Tipo"].Value.ToString();

            tabHabitacion.SelectedTab = tabPage1;
            btnEditar.Text = "Actualizar";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Habitaciones objHabitaciones = new Habitaciones();
                    objHabitaciones.Precio = txtPrecio.Text;
                    objHabitaciones.Codigo = txtCodigo.Text;
                    objHabitaciones.Tipo = txtTipo.Text;

                    if (lN.insertarHabitaciones(objHabitaciones) > 0)
                    {
                        MessageBox.Show("Agregado con exito!");
                        dgvHabitaciones.DataSource = lN.ListaHabitacion();
                        txtPrecio.Text = "";
                        txtCodigo.Text = "";
                        txtTipo.Text = "";
                        tabHabitacion.SelectedTab = tabPage2;
                    }

                    else { MessageBox.Show("Error al agragar Habitacion"); }
                }

                if (btnGuardar.Text == "Actualizar")
                {
                    Habitaciones objHabitaciones = new Habitaciones();
                    objHabitaciones.IdHabitacion = Convert.ToInt32(txtId.Text);
                    objHabitaciones.Precio = txtPrecio.Text;
                    objHabitaciones.Codigo = txtCodigo.Text;
                    objHabitaciones.Tipo = txtTipo.Text;

                    if (lN.EditarHabitacion(objHabitaciones) > 0)
                    {
                        MessageBox.Show("Actualizado con exito!");
                        dgvHabitaciones.DataSource = lN.ListaHabitacion();
                        txtPrecio.Text = "";
                        txtCodigo.Text = "";
                        txtTipo.Text = "";
                        tabHabitacion.SelectedTab = tabPage2;
                    }
                    else { MessageBox.Show("Error al actualizar Habitacion"); }

                    btnGuardar.Text = "Guardar";
                }
            }
            catch
            {
                MessageBox.Show("Errorrrr");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int Numero = Convert.ToInt32(dgvHabitaciones.CurrentRow.Cells["Numero"].Value.ToString());

            try
            {
                if (lN.EliminarHabitacion(Numero) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvHabitaciones.DataSource = lN.ListaHabitacion();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar Habitacion");
            }
        }

    }
}
