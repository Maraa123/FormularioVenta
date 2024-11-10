using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data;
using Modelos;

namespace Presentacion
{
    public partial class FormVenta : Form
    {
        List<Venta> ventaList = new List<Venta>();
        public FormVenta()
        {
            InitializeComponent();
        }
        private void CargarCliente()
        {
            List<Cliente> list = BCliente.Get();
            clienteBindingSource.DataSource = list;
            comboBoxCliente.DisplayMember = "nombre"; // Asume que 'Nombre' es la propiedad de la clase Cliente que contiene la descripción
            comboBoxCliente.ValueMember = "idCliente"; // Asume que 'IdCliente' es la propiedad que contiene el ID
        }

        private void CargarTipoComprobante()
        {
            List<TipoComprobante> list = BTipoComprobante.Get();
            tipoComprobantebindingSource.DataSource = list;
            comboBoxTipo.DisplayMember = "descripcion"; // Asume que 'Descripcion' es la propiedad que contiene la descripción
            comboBoxTipo.ValueMember = "idTipo"; // Asume que 'IdTipoComprobante' es la propiedad que contiene el ID
        }

        private void CargarMoneda()
        {
            List<Moneda> list = BMoneda.Get();
            monedaBindingSource.DataSource = list;
            comboBoxMoneda.DisplayMember = "descripcion"; // Asume que 'Descripcion' es la propiedad de la clase Moneda
            comboBoxMoneda.ValueMember = "idMoneda"; // Asume que 'IdMoneda' es la propiedad que contiene el ID
        }

        private void CargarCuenta()
        {
            List<Cuenta> list = BCuenta.Get();
            cuentaBindingSource.DataSource = list;
            comboBoxCuenta.DisplayMember = "detalle"; // Asume que 'Nombre' es la propiedad de la clase Cuenta
            comboBoxCuenta.ValueMember = "idCuenta"; // Asume que 'IdCuenta' es la propiedad que contiene el ID
        }

        private void CargarCentro()
        {
            List<CentroCosto> list = BCentroCosto.Get();
            centroCostoBindingSource.DataSource = list;
            comboBoxCentro.DisplayMember = "descripcion"; // Asume que 'Descripcion' es la propiedad de la clase CentroCosto
            comboBoxCentro.ValueMember = "idCentro"; // Asume que 'IdCentroCosto' es la propiedad que contiene el ID
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            CargarCliente();
            CargarTipoComprobante();
            CargarMoneda();
            CargarCuenta();
            CargarCentro();
            ventaList = BVenta.Get();
            ventaBindingSource.DataSource = ventaList;
        }


        private void Cargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxImputacion.Text) || string.IsNullOrEmpty(textBoxCambio.Text) || string.IsNullOrEmpty(textBoxPunto.Text) ||
                    string.IsNullOrEmpty(textBoxGravado.Text) || string.IsNullOrEmpty(textBoxNoGravado.Text) || string.IsNullOrEmpty(textBoxExento.Text) ||
                    string.IsNullOrEmpty(textBoxIva.Text) || string.IsNullOrEmpty(textBoxPerIva.Text) || string.IsNullOrEmpty(textBoxPerIibb.Text) ||
                    string.IsNullOrEmpty(textBoxPerMun.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = dateTimePicker1.Value;

                int codCliente = (int)comboBoxCliente.SelectedValue;
                int codTipoComprobante = (int)comboBoxTipo.SelectedValue;
                int codMoneda = (int)comboBoxMoneda.SelectedValue;
                int codCuenta = (int)comboBoxCuenta.SelectedValue;
                int codCentroCosto = (int)comboBoxCentro.SelectedValue;

                int imputacion = int.Parse(textBoxImputacion.Text);
                decimal cambio = decimal.Parse(textBoxCambio.Text);
                int punto = int.Parse(textBoxPunto.Text);
                double gravado = double.Parse(textBoxGravado.Text);
                double nogravado = double.Parse(textBoxNoGravado.Text);
                double exento = double.Parse(textBoxExento.Text);
                double iva = double.Parse(textBoxIva.Text);
                double periva = double.Parse(textBoxPerIva.Text);
                double periibb = double.Parse(textBoxPerIibb.Text);
                double permun = double.Parse(textBoxPerMun.Text);

                BVenta.Insert(codCliente, codTipoComprobante, codMoneda, codCuenta, fecha, imputacion, cambio, punto, textBoxNumero.Text, gravado, nogravado, exento, iva, periva, periibb, permun, codCentroCosto);

                // Actualizar la lista y el BindingSource
                ventaList = BVenta.Get();
                ventaBindingSource.DataSource = ventaList;

            }
            catch (FormatException ex)
            {
                // Captura el error de formato si el usuario no ingresa un número válido
                MessageBox.Show("Por favor, ingrese valores válidos en los campos numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro tipo de error
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ventaList.Count == 0 || ventaBindingSource.Current == null)
                {
                    MessageBox.Show("No hay ninguna venta seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Obtener el id de la venta seleccionada
                Venta venta = (Venta)ventaBindingSource.Current;
                int idVenta = venta.idVenta;

                // Confirmar que el usuario desea eliminar
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar esta venta?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Llamar al método de eliminación
                    BVenta.Delete(idVenta);

                    // Actualizar la lista después de la eliminación
                    ventaList = BVenta.Get(); // Aquí se obtiene la lista actualizada de ventas
                    ventaBindingSource.DataSource = ventaList; // Reasignar el BindingSource para refrescar el DataGridView

                    MessageBox.Show("Venta eliminada correctamente", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
               
            }
        }


        private void Modificar_Click(object sender, EventArgs e)
        {

            try
            {
                // Verificar que los campos no estén vacíos (como lo haces en el Cargar_Click)
                if (string.IsNullOrEmpty(textBoxImputacion.Text) || string.IsNullOrEmpty(textBoxCambio.Text) ||
                    string.IsNullOrEmpty(textBoxPunto.Text) || string.IsNullOrEmpty(textBoxGravado.Text) ||
                    string.IsNullOrEmpty(textBoxNoGravado.Text) || string.IsNullOrEmpty(textBoxExento.Text) ||
                    string.IsNullOrEmpty(textBoxIva.Text) || string.IsNullOrEmpty(textBoxPerIva.Text) ||
                    string.IsNullOrEmpty(textBoxPerIibb.Text) || string.IsNullOrEmpty(textBoxPerMun.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idVenta = int.Parse(labelId.Text);

                // Obtener los nuevos valores desde los controles
                DateTime fecha = dateTimePicker1.Value;
                int codCliente = (int)comboBoxCliente.SelectedValue;
                int codTipoComprobante = (int)comboBoxTipo.SelectedValue;
                int codMoneda = (int)comboBoxMoneda.SelectedValue;
                int codCuenta = (int)comboBoxCuenta.SelectedValue;
                int codCentroCosto = (int)comboBoxCentro.SelectedValue;

                int imputacion = int.Parse(textBoxImputacion.Text);
                decimal cambio = decimal.Parse(textBoxCambio.Text);
                int punto = int.Parse(textBoxPunto.Text);
                double gravado = double.Parse(textBoxGravado.Text);
                double nogravado = double.Parse(textBoxNoGravado.Text);
                double exento = double.Parse(textBoxExento.Text);
                double iva = double.Parse(textBoxIva.Text);
                double periva = double.Parse(textBoxPerIva.Text);
                double periibb = double.Parse(textBoxPerIibb.Text);
                double permun = double.Parse(textBoxPerMun.Text);

                // Llamar al método de actualización para modificar los datos en la base de datos
                BVenta.Update(idVenta, codCliente, codTipoComprobante, codMoneda, codCuenta, fecha, imputacion,
                              cambio, punto, textBoxNumero.Text, gravado, nogravado, exento, iva, periva, periibb,
                              permun, codCentroCosto);

                // Actualizar la lista después de la modificación
                ventaList = BVenta.Get();
                ventaBindingSource.DataSource = ventaList;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos numéricos.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (ventaList.Count > 0)
                {

                    Venta venta = (Venta)ventaBindingSource.Current;
                    if (venta != null)
                    {
                        comboBoxCliente.SelectedValue = venta.Cliente;
                        comboBoxTipo.SelectedValue = venta.TipoComprobante;
                        comboBoxMoneda.SelectedValue = venta.Moneda;
                        comboBoxCuenta.SelectedValue = venta.Cuenta;
                        comboBoxCentro.SelectedValue = venta.CentroCosto;

                        labelId.Text = venta.idVenta.ToString();
                        textBoxImputacion.Text = venta.imputacion.ToString();
                        textBoxCambio.Text = venta.tipoCambio.ToString();
                        textBoxNumero.Text = venta.numero.ToString();
                        textBoxPunto.Text = venta.punto.ToString();
                        textBoxGravado.Text = venta.netoGravado.ToString();
                        textBoxNoGravado.Text = venta.netoNoGravado.ToString();
                        textBoxExento.Text = venta.exento.ToString();
                        textBoxIva.Text = venta.iva.ToString();
                        textBoxPerIva.Text = venta.percIVA.ToString();
                        textBoxPerIibb.Text = venta.percIIBB.ToString();
                        textBoxPerMun.Text = venta.percMunicipalidad.ToString();

                        dateTimePicker1.Value = venta.fecha;
                    }
                }
            }
            catch (Exception ex)
            {
               
            }

        }

        private void LimpiarCampos()
        {
            // Limpiar los campos de texto
            labelId.Text = string.Empty;
            textBoxImputacion.Text = string.Empty;
            textBoxCambio.Text = string.Empty;
            textBoxNumero.Text = string.Empty;
            textBoxPunto.Text = string.Empty;
            textBoxGravado.Text = string.Empty;
            textBoxNoGravado.Text = string.Empty;
            textBoxExento.Text = string.Empty;
            textBoxIva.Text = string.Empty;
            textBoxPerIva.Text = string.Empty;
            textBoxPerIibb.Text = string.Empty;
            textBoxPerMun.Text = string.Empty;

            // Limpiar ComboBox
            comboBoxCliente.SelectedIndex = -1;
            comboBoxTipo.SelectedIndex = -1;
            comboBoxMoneda.SelectedIndex = -1;
            comboBoxCuenta.SelectedIndex = -1;
            comboBoxCentro.SelectedIndex = -1;

            // Limpiar el DateTimePicker
            dateTimePicker1.Value = DateTime.Now;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Obtener el índice de la fila seleccionada
                int indice = e.RowIndex;

                // Verificar si la fila es válida y si es la última fila (de nuevo registro)
                if (indice == -1 || dataGridView1.Rows[indice].IsNewRow || string.IsNullOrEmpty(dataGridView1.Rows[indice].Cells[1].Value?.ToString()))
                {
                    LimpiarCampos(); // Limpiar los campos si es una fila vacía o el índice es inválido
                }
                else
                {
                    // Obtener los datos de la fila seleccionada
                    var venta = (Venta)ventaBindingSource.Current;

                    // Asignar los valores a los controles
                    comboBoxCliente.SelectedValue = venta.Cliente;
                    comboBoxTipo.SelectedValue = venta.TipoComprobante;
                    comboBoxMoneda.SelectedValue = venta.Moneda;
                    comboBoxCuenta.SelectedValue = venta.Cuenta;
                    comboBoxCentro.SelectedValue = venta.CentroCosto;

                    labelId.Text = venta.idVenta.ToString();
                    textBoxImputacion.Text = venta.imputacion.ToString();
                    textBoxCambio.Text = venta.tipoCambio.ToString();
                    textBoxNumero.Text = venta.numero.ToString();
                    textBoxPunto.Text = venta.punto.ToString();
                    textBoxGravado.Text = venta.netoGravado.ToString();
                    textBoxNoGravado.Text = venta.netoNoGravado.ToString();
                    textBoxExento.Text = venta.exento.ToString();
                    textBoxIva.Text = venta.iva.ToString();
                    textBoxPerIva.Text = venta.percIVA.ToString();
                    textBoxPerIibb.Text = venta.percIIBB.ToString();
                    textBoxPerMun.Text = venta.percMunicipalidad.ToString();

                    dateTimePicker1.Value = venta.fecha;
                }
            }
            catch (Exception ex)
            {

            }
        }
     }
 }



