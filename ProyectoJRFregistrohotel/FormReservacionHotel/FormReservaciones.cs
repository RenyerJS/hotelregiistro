using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaDatos;
using capaEntidades;

namespace FormReservacionHotel
{
    public partial class FormReservaciones : Form
    {
        logicaNegocioReservaciones lN = new logicaNegocioReservaciones();
        public FormReservaciones()
        {
            InitializeComponent();
        }

        private void FormReservaciones_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            lbId.Visible = false;
            dgvReservaciones.DataSource = lN.ListaReservacion();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Reservaciones> lista = lN.BuscaReservacionDatos(txtBuscar.Text);
            dgvReservaciones.DataSource = lista;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtId.Visible = true;
            txtId.Enabled = false;
            lbId.Visible = true;

            txtFecha.Text = dgvReservaciones.CurrentRow.Cells["fecha"].Value.ToString();
            txtTiempo.Text = dgvReservaciones.CurrentRow.Cells["tiempo"].Value.ToString();
            txtNumeroCliente.Text = dgvReservaciones.CurrentRow.Cells["apellidos"].Value.ToString();
            txtNumero.Text = dgvReservaciones.CurrentRow.Cells["direccion"].Value.ToString();
           
            tabReservaciones.SelectedTab = tabPage1;
            btnEditar.Text = "Actualizar";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Reservaciones objReservaciones = new Reservaciones();
                    objReservaciones.Fecha = txtFecha.Text;
                    objReservaciones.Tiempo = txtTiempo.Text;
                    objReservaciones.NumeroCliente = txtNumeroCliente.Text;
                    objReservaciones.Numero = txtNumero.Text;

                    if (lN.insertarReservacion(objReservaciones) > 0)
                    {
                        MessageBox.Show("Agregado con éxito!");
                        dgvReservaciones.DataSource = lN.ListaReservacion();
                        txtFecha.Text = "";
                        txtTiempo.Text = "";
                        txtNumeroCliente.Text = "";
                        txtNumero.Text = "";
                        tabReservaciones.SelectedTab = tabPage2;
                    }
                    else { 
                        MessageBox.Show("Error al agregar Reservacion"); 
                    }
                }

                if (btnGuardar.Text == "Actualizar")
                {
                    Reservaciones objReservaciones = new Reservaciones();
                    objReservaciones.Fecha = txtFecha.Text;
                    objReservaciones.Tiempo = txtTiempo.Text;
                    objReservaciones.NumeroCliente = txtNumeroCliente.Text;
                    objReservaciones.Numero = txtNumero.Text;

                    if (lN.EditarReservacion(objReservaciones) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito!");
                        txtFecha.Text = "";
                        txtTiempo.Text = "";
                        txtNumeroCliente.Text = "";
                        txtNumero.Text = "";
                        tabReservaciones.SelectedTab = tabPage2;
                    }

                    else { MessageBox.Show("Error al actualizar Reservacion"); }

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
            int Id = Convert.ToInt32(dgvReservaciones.CurrentRow.Cells["Id"].Value.ToString());

            try
            {
                if (lN.EliminarReservacion(Id) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvReservaciones.DataSource = lN.ListaReservacion();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }


       }
}
