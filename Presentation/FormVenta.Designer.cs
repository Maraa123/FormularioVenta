namespace Presentacion
{
    partial class FormVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imputacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoCambioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            puntoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeroDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            netoGravadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            netoNoGravadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            exentoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ivaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percIVADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percIIBBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            percMunicipalidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clienteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoComprobanteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monedaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            centroCostoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cuentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ventaBindingSource = new BindingSource(components);
            textBoxFiltro = new TextBox();
            Filtrar = new Button();
            Cobrar = new Button();
            Detalle = new Button();
            Eliminar = new Button();
            Modificar = new Button();
            Cargar = new Button();
            button4 = new Button();
            button3 = new Button();
            comboBoxCentro = new ComboBox();
            centroCostoBindingSource = new BindingSource(components);
            label16 = new Label();
            label15 = new Label();
            comboBoxCuenta = new ComboBox();
            cuentaBindingSource = new BindingSource(components);
            textBoxPerMun = new TextBox();
            label14 = new Label();
            label13 = new Label();
            textBoxPerIibb = new TextBox();
            label12 = new Label();
            textBoxPerIva = new TextBox();
            textBoxExento = new TextBox();
            label11 = new Label();
            label10 = new Label();
            textBoxNoGravado = new TextBox();
            textBoxIva = new TextBox();
            label9 = new Label();
            CargarDetalle = new Button();
            button1 = new Button();
            label8 = new Label();
            textBoxGravado = new TextBox();
            textBoxCambio = new TextBox();
            label7 = new Label();
            comboBoxMoneda = new ComboBox();
            monedaBindingSource = new BindingSource(components);
            label6 = new Label();
            textBoxNumero = new TextBox();
            label5 = new Label();
            comboBoxTipo = new ComboBox();
            tipoComprobantebindingSource = new BindingSource(components);
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBoxCliente = new ComboBox();
            clienteBindingSource = new BindingSource(components);
            label3 = new Label();
            textBoxPunto = new TextBox();
            label17 = new Label();
            textBoxImputacion = new TextBox();
            labelId = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centroCostoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monedaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoComprobantebindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(textBoxFiltro);
            groupBox1.Controls.Add(Filtrar);
            groupBox1.Controls.Add(Cobrar);
            groupBox1.Controls.Add(Detalle);
            groupBox1.Controls.Add(Eliminar);
            groupBox1.Controls.Add(Modificar);
            groupBox1.Location = new Point(367, 7);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(710, 442);
            groupBox1.TabIndex = 77;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idVentaDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, imputacionDataGridViewTextBoxColumn, tipoCambioDataGridViewTextBoxColumn, puntoDataGridViewTextBoxColumn, numeroDataGridViewTextBoxColumn, netoGravadoDataGridViewTextBoxColumn, netoNoGravadoDataGridViewTextBoxColumn, exentoDataGridViewTextBoxColumn, ivaDataGridViewTextBoxColumn, percIVADataGridViewTextBoxColumn, percIIBBDataGridViewTextBoxColumn, percMunicipalidadDataGridViewTextBoxColumn, clienteDataGridViewTextBoxColumn, tipoComprobanteDataGridViewTextBoxColumn, monedaDataGridViewTextBoxColumn, centroCostoDataGridViewTextBoxColumn, cuentaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ventaBindingSource;
            dataGridView1.Location = new Point(11, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(679, 315);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged_1;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            idVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta";
            idVentaDataGridViewTextBoxColumn.HeaderText = "idVenta";
            idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imputacionDataGridViewTextBoxColumn
            // 
            imputacionDataGridViewTextBoxColumn.DataPropertyName = "imputacion";
            imputacionDataGridViewTextBoxColumn.HeaderText = "imputacion";
            imputacionDataGridViewTextBoxColumn.Name = "imputacionDataGridViewTextBoxColumn";
            imputacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoCambioDataGridViewTextBoxColumn
            // 
            tipoCambioDataGridViewTextBoxColumn.DataPropertyName = "tipoCambio";
            tipoCambioDataGridViewTextBoxColumn.HeaderText = "tipoCambio";
            tipoCambioDataGridViewTextBoxColumn.Name = "tipoCambioDataGridViewTextBoxColumn";
            tipoCambioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puntoDataGridViewTextBoxColumn
            // 
            puntoDataGridViewTextBoxColumn.DataPropertyName = "punto";
            puntoDataGridViewTextBoxColumn.HeaderText = "punto";
            puntoDataGridViewTextBoxColumn.Name = "puntoDataGridViewTextBoxColumn";
            puntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netoGravadoDataGridViewTextBoxColumn
            // 
            netoGravadoDataGridViewTextBoxColumn.DataPropertyName = "netoGravado";
            netoGravadoDataGridViewTextBoxColumn.HeaderText = "netoGravado";
            netoGravadoDataGridViewTextBoxColumn.Name = "netoGravadoDataGridViewTextBoxColumn";
            netoGravadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netoNoGravadoDataGridViewTextBoxColumn
            // 
            netoNoGravadoDataGridViewTextBoxColumn.DataPropertyName = "netoNoGravado";
            netoNoGravadoDataGridViewTextBoxColumn.HeaderText = "netoNoGravado";
            netoNoGravadoDataGridViewTextBoxColumn.Name = "netoNoGravadoDataGridViewTextBoxColumn";
            netoNoGravadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // exentoDataGridViewTextBoxColumn
            // 
            exentoDataGridViewTextBoxColumn.DataPropertyName = "exento";
            exentoDataGridViewTextBoxColumn.HeaderText = "exento";
            exentoDataGridViewTextBoxColumn.Name = "exentoDataGridViewTextBoxColumn";
            exentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            ivaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percIVADataGridViewTextBoxColumn
            // 
            percIVADataGridViewTextBoxColumn.DataPropertyName = "percIVA";
            percIVADataGridViewTextBoxColumn.HeaderText = "percIVA";
            percIVADataGridViewTextBoxColumn.Name = "percIVADataGridViewTextBoxColumn";
            percIVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percIIBBDataGridViewTextBoxColumn
            // 
            percIIBBDataGridViewTextBoxColumn.DataPropertyName = "percIIBB";
            percIIBBDataGridViewTextBoxColumn.HeaderText = "percIIBB";
            percIIBBDataGridViewTextBoxColumn.Name = "percIIBBDataGridViewTextBoxColumn";
            percIIBBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // percMunicipalidadDataGridViewTextBoxColumn
            // 
            percMunicipalidadDataGridViewTextBoxColumn.DataPropertyName = "percMunicipalidad";
            percMunicipalidadDataGridViewTextBoxColumn.HeaderText = "percMunicipalidad";
            percMunicipalidadDataGridViewTextBoxColumn.Name = "percMunicipalidadDataGridViewTextBoxColumn";
            percMunicipalidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            clienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoComprobanteDataGridViewTextBoxColumn
            // 
            tipoComprobanteDataGridViewTextBoxColumn.DataPropertyName = "TipoComprobante";
            tipoComprobanteDataGridViewTextBoxColumn.HeaderText = "TipoComprobante";
            tipoComprobanteDataGridViewTextBoxColumn.Name = "tipoComprobanteDataGridViewTextBoxColumn";
            tipoComprobanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // monedaDataGridViewTextBoxColumn
            // 
            monedaDataGridViewTextBoxColumn.DataPropertyName = "Moneda";
            monedaDataGridViewTextBoxColumn.HeaderText = "Moneda";
            monedaDataGridViewTextBoxColumn.Name = "monedaDataGridViewTextBoxColumn";
            monedaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // centroCostoDataGridViewTextBoxColumn
            // 
            centroCostoDataGridViewTextBoxColumn.DataPropertyName = "CentroCosto";
            centroCostoDataGridViewTextBoxColumn.HeaderText = "CentroCosto";
            centroCostoDataGridViewTextBoxColumn.Name = "centroCostoDataGridViewTextBoxColumn";
            centroCostoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cuentaDataGridViewTextBoxColumn
            // 
            cuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta";
            cuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            cuentaDataGridViewTextBoxColumn.Name = "cuentaDataGridViewTextBoxColumn";
            cuentaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ventaBindingSource
            // 
            ventaBindingSource.DataSource = typeof(Modelos.Venta);
            // 
            // textBoxFiltro
            // 
            textBoxFiltro.Location = new Point(11, 19);
            textBoxFiltro.Margin = new Padding(2);
            textBoxFiltro.Name = "textBoxFiltro";
            textBoxFiltro.Size = new Size(331, 23);
            textBoxFiltro.TabIndex = 47;
            // 
            // Filtrar
            // 
            Filtrar.Location = new Point(356, 18);
            Filtrar.Margin = new Padding(2);
            Filtrar.Name = "Filtrar";
            Filtrar.Size = new Size(78, 20);
            Filtrar.TabIndex = 46;
            Filtrar.Text = "Filtrar";
            Filtrar.UseVisualStyleBackColor = true;
            Filtrar.Click += Filtrar_Click;
            // 
            // Cobrar
            // 
            Cobrar.Location = new Point(575, 18);
            Cobrar.Margin = new Padding(2);
            Cobrar.Name = "Cobrar";
            Cobrar.Size = new Size(78, 20);
            Cobrar.TabIndex = 45;
            Cobrar.Text = "Cobrar";
            Cobrar.UseVisualStyleBackColor = true;
            // 
            // Detalle
            // 
            Detalle.Location = new Point(464, 18);
            Detalle.Margin = new Padding(2);
            Detalle.Name = "Detalle";
            Detalle.Size = new Size(78, 20);
            Detalle.TabIndex = 44;
            Detalle.Text = "Detalle";
            Detalle.UseVisualStyleBackColor = true;
            // 
            // Eliminar
            // 
            Eliminar.Location = new Point(103, 402);
            Eliminar.Margin = new Padding(2);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(78, 20);
            Eliminar.TabIndex = 39;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // Modificar
            // 
            Modificar.Location = new Point(11, 402);
            Modificar.Margin = new Padding(2);
            Modificar.Name = "Modificar";
            Modificar.Size = new Size(78, 20);
            Modificar.TabIndex = 38;
            Modificar.Text = "Modificar";
            Modificar.UseVisualStyleBackColor = true;
            Modificar.Click += Modificar_Click;
            // 
            // Cargar
            // 
            Cargar.Location = new Point(139, 401);
            Cargar.Margin = new Padding(2);
            Cargar.Name = "Cargar";
            Cargar.Size = new Size(78, 20);
            Cargar.TabIndex = 76;
            Cargar.Text = "Aceptar";
            Cargar.UseVisualStyleBackColor = true;
            Cargar.Click += Cargar_Click;
            // 
            // button4
            // 
            button4.Location = new Point(273, 367);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(21, 20);
            button4.TabIndex = 75;
            button4.Text = ">";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(279, 332);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(21, 20);
            button3.TabIndex = 74;
            button3.Text = ">";
            button3.UseVisualStyleBackColor = true;
            // 
            // comboBoxCentro
            // 
            comboBoxCentro.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCentro.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCentro.DataSource = centroCostoBindingSource;
            comboBoxCentro.DisplayMember = "idCentro";
            comboBoxCentro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCentro.FormattingEnabled = true;
            comboBoxCentro.Location = new Point(60, 367);
            comboBoxCentro.Margin = new Padding(2);
            comboBoxCentro.Name = "comboBoxCentro";
            comboBoxCentro.Size = new Size(210, 23);
            comboBoxCentro.TabIndex = 73;
            comboBoxCentro.ValueMember = "idCentro";
            // 
            // centroCostoBindingSource
            // 
            centroCostoBindingSource.DataSource = typeof(Modelos.CentroCosto);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(11, 372);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 72;
            label16.Text = "Centro";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(2, 334);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(45, 15);
            label15.TabIndex = 71;
            label15.Text = "Cuenta";
            // 
            // comboBoxCuenta
            // 
            comboBoxCuenta.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCuenta.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCuenta.DataSource = cuentaBindingSource;
            comboBoxCuenta.DisplayMember = "idCuenta";
            comboBoxCuenta.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCuenta.FormattingEnabled = true;
            comboBoxCuenta.Location = new Point(60, 332);
            comboBoxCuenta.Margin = new Padding(2);
            comboBoxCuenta.Name = "comboBoxCuenta";
            comboBoxCuenta.Size = new Size(210, 23);
            comboBoxCuenta.TabIndex = 70;
            comboBoxCuenta.ValueMember = "idCuenta";
            // 
            // cuentaBindingSource
            // 
            cuentaBindingSource.DataSource = typeof(Modelos.Cuenta);
            // 
            // textBoxPerMun
            // 
            textBoxPerMun.Location = new Point(271, 294);
            textBoxPerMun.Margin = new Padding(2);
            textBoxPerMun.Name = "textBoxPerMun";
            textBoxPerMun.Size = new Size(81, 23);
            textBoxPerMun.TabIndex = 69;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(218, 296);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 68;
            label14.Text = "Per.Mun.";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(111, 296);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(47, 15);
            label13.TabIndex = 67;
            label13.Text = "Per.IIBB";
            // 
            // textBoxPerIibb
            // 
            textBoxPerIibb.Location = new Point(157, 296);
            textBoxPerIibb.Margin = new Padding(2);
            textBoxPerIibb.Name = "textBoxPerIibb";
            textBoxPerIibb.Size = new Size(62, 23);
            textBoxPerIibb.TabIndex = 66;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(7, 296);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 65;
            label12.Text = "Per.IVA";
            // 
            // textBoxPerIva
            // 
            textBoxPerIva.Location = new Point(51, 296);
            textBoxPerIva.Margin = new Padding(2);
            textBoxPerIva.Name = "textBoxPerIva";
            textBoxPerIva.Size = new Size(56, 23);
            textBoxPerIva.TabIndex = 64;
            // 
            // textBoxExento
            // 
            textBoxExento.Location = new Point(229, 260);
            textBoxExento.Margin = new Padding(2);
            textBoxExento.Name = "textBoxExento";
            textBoxExento.Size = new Size(123, 23);
            textBoxExento.TabIndex = 63;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(181, 263);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(43, 15);
            label11.TabIndex = 62;
            label11.Text = "Exento";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 263);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 61;
            label10.Text = "No Gravado";
            // 
            // textBoxNoGravado
            // 
            textBoxNoGravado.Location = new Point(85, 260);
            textBoxNoGravado.Margin = new Padding(2);
            textBoxNoGravado.Name = "textBoxNoGravado";
            textBoxNoGravado.Size = new Size(92, 23);
            textBoxNoGravado.TabIndex = 60;
            // 
            // textBoxIva
            // 
            textBoxIva.Location = new Point(229, 231);
            textBoxIva.Margin = new Padding(2);
            textBoxIva.Name = "textBoxIva";
            textBoxIva.Size = new Size(123, 23);
            textBoxIva.TabIndex = 59;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(197, 235);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 58;
            label9.Text = "IVA";
            // 
            // CargarDetalle
            // 
            CargarDetalle.Location = new Point(18, 193);
            CargarDetalle.Margin = new Padding(2);
            CargarDetalle.Name = "CargarDetalle";
            CargarDetalle.Size = new Size(333, 20);
            CargarDetalle.TabIndex = 57;
            CargarDetalle.Text = "Cargar Detalle";
            CargarDetalle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(330, 69);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(21, 20);
            button1.TabIndex = 56;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 235);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 55;
            label8.Text = "Gravado";
            // 
            // textBoxGravado
            // 
            textBoxGravado.Location = new Point(76, 231);
            textBoxGravado.Margin = new Padding(2);
            textBoxGravado.Name = "textBoxGravado";
            textBoxGravado.Size = new Size(120, 23);
            textBoxGravado.TabIndex = 54;
            // 
            // textBoxCambio
            // 
            textBoxCambio.Location = new Point(229, 163);
            textBoxCambio.Margin = new Padding(2);
            textBoxCambio.Name = "textBoxCambio";
            textBoxCambio.Size = new Size(123, 23);
            textBoxCambio.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(173, 167);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 52;
            label7.Text = "Cambio";
            // 
            // comboBoxMoneda
            // 
            comboBoxMoneda.DataSource = monedaBindingSource;
            comboBoxMoneda.DisplayMember = "idMoneda";
            comboBoxMoneda.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMoneda.FormattingEnabled = true;
            comboBoxMoneda.Location = new Point(78, 163);
            comboBoxMoneda.Margin = new Padding(2);
            comboBoxMoneda.Name = "comboBoxMoneda";
            comboBoxMoneda.Size = new Size(85, 23);
            comboBoxMoneda.TabIndex = 51;
            comboBoxMoneda.ValueMember = "idMoneda";
            // 
            // monedaBindingSource
            // 
            monedaBindingSource.DataSource = typeof(Modelos.Moneda);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 167);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 50;
            label6.Text = "Moneda";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(76, 133);
            textBoxNumero.Margin = new Padding(2);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(101, 23);
            textBoxNumero.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 136);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 47;
            label5.Text = "Numero";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxTipo.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxTipo.DataSource = tipoComprobantebindingSource;
            comboBoxTipo.DisplayMember = "idTipo";
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(76, 101);
            comboBoxTipo.Margin = new Padding(2);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(173, 23);
            comboBoxTipo.TabIndex = 46;
            comboBoxTipo.ValueMember = "idTipo";
            // 
            // tipoComprobantebindingSource
            // 
            tipoComprobantebindingSource.DataSource = typeof(Modelos.TipoComprobante);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 106);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 45;
            label4.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 41);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 42;
            label2.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(76, 35);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(111, 23);
            dateTimePicker1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 40;
            label1.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCliente.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCliente.DataSource = clienteBindingSource;
            comboBoxCliente.DisplayMember = "idCliente";
            comboBoxCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(76, 69);
            comboBoxCliente.Margin = new Padding(2);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(239, 23);
            comboBoxCliente.TabIndex = 39;
            comboBoxCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Modelos.Cliente);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 136);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 78;
            label3.Text = "Punto";
            // 
            // textBoxPunto
            // 
            textBoxPunto.Location = new Point(230, 133);
            textBoxPunto.Name = "textBoxPunto";
            textBoxPunto.Size = new Size(122, 23);
            textBoxPunto.TabIndex = 79;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(191, 41);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 80;
            label17.Text = "Imputacion";
            // 
            // textBoxImputacion
            // 
            textBoxImputacion.Location = new Point(262, 38);
            textBoxImputacion.Name = "textBoxImputacion";
            textBoxImputacion.Size = new Size(90, 23);
            textBoxImputacion.TabIndex = 81;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(20, 10);
            labelId.Name = "labelId";
            labelId.Size = new Size(0, 15);
            labelId.TabIndex = 82;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 475);
            Controls.Add(labelId);
            Controls.Add(textBoxImputacion);
            Controls.Add(label17);
            Controls.Add(textBoxPunto);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(Cargar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBoxCentro);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(comboBoxCuenta);
            Controls.Add(textBoxPerMun);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(textBoxPerIibb);
            Controls.Add(label12);
            Controls.Add(textBoxPerIva);
            Controls.Add(textBoxExento);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBoxNoGravado);
            Controls.Add(textBoxIva);
            Controls.Add(label9);
            Controls.Add(CargarDetalle);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(textBoxGravado);
            Controls.Add(textBoxCambio);
            Controls.Add(label7);
            Controls.Add(comboBoxMoneda);
            Controls.Add(label6);
            Controls.Add(textBoxNumero);
            Controls.Add(label5);
            Controls.Add(comboBoxTipo);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBoxCliente);
            Margin = new Padding(2);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)centroCostoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)monedaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoComprobantebindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxFiltro;
        private Button Filtrar;
        private Button Cobrar;
        private Button Detalle;
        private Button Eliminar;
        private Button Modificar;
        private Button Cargar;
        private Button button4;
        private Button button3;
        private ComboBox comboBoxCentro;
        private Label label16;
        private Label label15;
        private ComboBox comboBoxCuenta;
        private TextBox textBoxPerMun;
        private Label label14;
        private Label label13;
        private TextBox textBoxPerIibb;
        private Label label12;
        private TextBox textBoxPerIva;
        private TextBox textBoxExento;
        private Label label11;
        private Label label10;
        private TextBox textBoxNoGravado;
        private TextBox textBoxIva;
        private Label label9;
        private Button CargarDetalle;
        private Button button1;
        private Label label8;
        private TextBox textBoxGravado;
        private TextBox textBoxCambio;
        private Label label7;
        private ComboBox comboBoxMoneda;
        private Label label6;
        private TextBox textBoxNumero;
        private Label label5;
        private ComboBox comboBoxTipo;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBoxCliente;
        private BindingSource ventaBindingSource;
        private Label label3;
        private TextBox textBoxPunto;
        private Label label17;
        private TextBox textBoxImputacion;
        private Label labelId;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imputacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoCambioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn puntoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netoGravadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netoNoGravadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn exentoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percIVADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percIIBBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn percMunicipalidadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoComprobanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monedaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn centroCostoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cuentaDataGridViewTextBoxColumn;
        private BindingSource centroCostoBindingSource;
        private BindingSource cuentaBindingSource;
        private BindingSource monedaBindingSource;
        private BindingSource tipoComprobantebindingSource;
        private BindingSource clienteBindingSource;
    }
}