using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaEntidades;
using capaNegocio;
using capaDatos;

namespace FormReservacionHotel
{
    public partial class FormHoteles : Form
    {
        logicaNegocioHoteles lN = new logicaNegocioHoteles();
        public FormHoteles()
        {
            InitializeComponent();
        }

        private void FormHoteles_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lbid.Visible = false;
            dgvHoteles.DataSource = lN.listaHotel();
        }

        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
        //    List<Hoteles> lista = lN.BuscaHotelesDatos(txtbuscar.Text);
        //    dgvHoteles.DataSource = lista;
        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {

            txtid.Visible = true;
            txtid.Enabled = false;
            lbid.Visible = true;

            txtNombre.Text = dgvHoteles.CurrentRow.Cells["Nombre"].Value.ToString();
            txtdireccion.Text = dgvHoteles.CurrentRow.Cells["Direccion"].Value.ToString();
            txtcategoria.Text = dgvHoteles.CurrentRow.Cells["Categoria"].Value.ToString();

            tabHoteles.SelectedTab = tabPage2;
            btnEditar.Text = "Actualizar";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Hoteles objHoteles = new Hoteles();
                    objHoteles.Nombre = txtNombre.Text;
                    objHoteles.Direccion = txtdireccion.Text;
                    objHoteles.Categoria = txtcategoria.Text;

                    if (lN.insertarHotel(objHoteles) > 0)
                    {
                        MessageBox.Show("Agregado con éxito!");
                        dgvHoteles.DataSource = lN.listaHotel();
                        txtNombre.Text = "";
                        txtdireccion.Text = "";
                        txtcategoria.Text = "";
                        //txtNombre.Text = dgvHoteles.CurrentRow.Cells["Nombre"].Value.ToString();
                        //txtdireccion.Text = dgvHoteles.CurrentRow.Cells["Direccion"].Value.ToString();
                        //txtcategoria.Text = dgvHoteles.CurrentRow.Cells["Categoria"].Value.ToString();
                        tabHoteles.SelectedTab = tabPage2;

                       
                    }
                    else 
                    { 
                        MessageBox.Show("Error al agregar Hotel"); 
                    }

                }

                if (btnGuardar.Text == "Actualizar")
                {
                    Hoteles objHoteles = new Hoteles();
                    objHoteles.Codigo = Convert.ToInt32(txtid.Text);
                    objHoteles.Nombre = txtNombre.Text;
                    objHoteles.Direccion = txtdireccion.Text;
                    objHoteles.Categoria = txtcategoria.Text;

                    if (lN.EditarHotel(objHoteles) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito!");
                        txtNombre.Text = "";
                        txtdireccion.Text = "";
                        txtcategoria.Text = "";

                    }

                    else { MessageBox.Show("Error al actualizar Hotel"); }

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
            int Codigo = Convert.ToInt32(dgvHoteles.CurrentRow.Cells["Codigo"].Value.ToString());

            try
            {
                if (lN.EliminarHotel(Codigo) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvHoteles.DataSource = lN.listaHotel();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar Hotel");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<Hoteles> lista = lN.BuscaHotelesDatos(txtbuscar.Text);
            dgvHoteles.DataSource = lista;
        }




    }
}
