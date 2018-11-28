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
using capaEntidades;
using capaDatos;

namespace FormReservacionHotel
{
    public partial class Form1 : Form
    {
        logicaNegocioClientes lN = new logicaNegocioClientes();
        public Form1()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            txtid.Visible = false;
            lbid.Visible = false;
            dgvClientes.DataSource= lN.ListaCliente();
        }

        //private void txtBuscar_TextChanged(object sender, EventArgs e)
        //{
            
        //    List<Clientes> lista = lN.BuscaClienteDatos(txtbuscar.Text);
        //    //dgvClientes.Visible = true;
        //    dgvClientes.DataSource = lista;
        //}

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            txtid.Visible = true;
            txtid.Enabled = false;
            lbid.Visible = true;

            txtCedula.Text = dgvClientes.CurrentRow.Cells["Cedula"].Value.ToString();
            txtNombres.Text = dgvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
            txtapellidos.Text = dgvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
            txtdireccion.Text = dgvClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            txttelefono.Text = dgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            txttipocliente.Text = dgvClientes.CurrentRow.Cells["Tipocliente"].Value.ToString();

            tabClientes.SelectedTab = tabPage2;
            btnEditar.Text = "Actualizar";

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text == "Guardar")
                {
                    Clientes objClientes = new Clientes();
                    objClientes.Cedula = txtCedula.Text;
                    objClientes.Nombres = txtNombres.Text;
                    objClientes.Apellidos = txtapellidos.Text;
                    objClientes.Direccion = txtdireccion.Text;
                    objClientes.Telefono = txttelefono.Text;
                    objClientes.Tipocliente = txttipocliente.Text;
                    dgvClientes.DataSource = Visible;                    

                    if (lN.insertarCliente(objClientes) > 0)
                    {
                        MessageBox.Show("Agregado con éxito!");
                        dgvClientes.DataSource = lN.ListaCliente();
                        txtCedula.Text = "";
                        txtNombres.Text = "";
                        txtapellidos.Text = "";
                        txtdireccion.Text = "";
                        txttelefono.Text = "";
                        txttipocliente.Text = "";
                        tabClientes.SelectedTab = tabPage2;
                        
                    }
                    else { MessageBox.Show("Error al agregar Cliente"); }
                }

                if (btnGuardar.Text == "Actualizar")
                {
                    Clientes objClientes = new Clientes();
                    objClientes.NumeroCliente = Convert.ToInt32(txtid.Text);
                    objClientes.Cedula = txtCedula.Text;
                    objClientes.Nombres = txtNombres.Text;
                    objClientes.Apellidos = txtapellidos.Text;
                    objClientes.Direccion = txtdireccion.Text;
                    objClientes.Telefono = txttelefono.Text;
                    objClientes.Tipocliente = txttipocliente.Text;

                    if (lN.EditarCliente(objClientes) > 0)
                    {
                        MessageBox.Show("Actualizado con éxito!");
                        txtCedula.Text = "";
                        txtNombres.Text = "";
                        txtapellidos.Text = "";
                        txtdireccion.Text = "";
                        txttelefono.Text = "";
                        txttipocliente.Text = "";
                        tabClientes.SelectedTab = tabPage2;
                    }

                    else { MessageBox.Show("Error al actualizar Cliente"); }

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
            
            int NumeroCliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["NumeroCliente"].Value.ToString());

            try
            {
                if (lN.EliminarCliente(NumeroCliente) > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    dgvClientes.DataSource = lN.ListaCliente();
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar cliente");
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            List<Clientes> lista = lN.BuscaClienteDatos(txtbuscar.Text);
            dgvClientes.Visible = true;
            dgvClientes.DataSource = lista;
        }

    }
}
