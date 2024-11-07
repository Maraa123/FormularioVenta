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
            List<Cliente> list = new List<Cliente>();
            list = BCliente.Get();
            clienteBindingSource.DataSource = list;
        }

        private void CargarTipoComprobante()
        {
            List<TipoComprobante> list = new List<TipoComprobante>();
            list = BTipoComprobante.Get();
            tipoComprobanteBindingSource.DataSource = list;
        }

        private void CargarMoneda()
        {
            List<Moneda> list = new List<Moneda>();
            list = BMoneda.Get();
            monedaBindingSource.DataSource = list;
        }

        private void CargarCuenta()
        {
            List<Cuenta> list = new List<Cuenta>();
            list = BCuenta.Get();
            cuentaBindingSource.DataSource = list;
        }

        private void CargarCentro()
        {
            List<CentroCosto> list = new List<CentroCosto>();
            list = BCentroCosto.Get();
            centroCostoBindingSource.DataSource = list;
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

                int codCliente = (int)comboBox1.SelectedValue;
                int codTipoComprobante = (int)comboBox2.SelectedValue;
                int codMoneda = (int)comboBox3.SelectedValue;
                int codCuenta = (int)comboBox4.SelectedValue;
                int codCentroCosto = (int)comboBox5.SelectedValue;

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
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (ventaList.Count > 0)
                {
                    // Obtener la venta seleccionada desde el BindingSource
                    Venta venta = (Venta)ventaBindingSource.Current;

                    if (venta != null)
                    {
                        comboBox1.SelectedValue = venta.Cliente;
                        comboBox2.SelectedValue = venta.TipoComprobante;
                        comboBox3.SelectedValue = venta.Moneda;
                        comboBox4.SelectedValue = venta.Cuenta;
                        comboBox5.SelectedValue = venta.CentroCosto;

                        // Asignar valores de los campos adicionales
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

                        // Asignar fecha
                        dateTimePicker1.Value = venta.fecha;
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
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
                // Manejo de errores
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Obtener el id de la venta seleccionada desde el label o cualquier otro control
                int idVenta = int.Parse(label5.Text); // Asumiendo que el id de la venta está en el label5

                // Obtener los nuevos valores desde los controles
                DateTime fecha = dateTimePicker1.Value;
                int codCliente = (int)comboBox1.SelectedValue;
                int codTipoComprobante = (int)comboBox2.SelectedValue;
                int codMoneda = (int)comboBox3.SelectedValue;
                int codCuenta = (int)comboBox4.SelectedValue;
                int codCentroCosto = (int)comboBox5.SelectedValue;

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
                BVenta.Update(codCliente, codTipoComprobante, codMoneda, codCuenta, fecha, imputacion,
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
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cobrar_Click(object sender, EventArgs e)
        {

            FormCobros formCobros = new FormCobros();
            formCobros.Show();


        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            try
            { 
                if (string.IsNullOrEmpty(textBoxImputacion.Text) || !int.TryParse(textBoxImputacion.Text, out int imputacion))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido para Imputación", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DateTime fecha = dateTimePicker1.Value.Date;

                // Filtrar la lista de ventas por imputacion y fecha
                var ventasFiltradas = ventaList.Where(v => v.imputacion == imputacion && v.fecha.Date == fecha).ToList();

                // Actualizar el BindingSource con las ventas filtradas
                ventaBindingSource.DataSource = ventasFiltradas;

                // Actualizar el DataGridView
                dataGridView1.Refresh();

                // Verifica si hay resultados después del filtro
                if (ventasFiltradas.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados para los filtros especificados.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


