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
            textBox12 = new TextBox();
            Filtrar = new Button();
            Cobrar = new Button();
            Detalle = new Button();
            dataGridView1 = new DataGridView();
            idVentaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            imputacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            TipoComprobante = new DataGridViewTextBoxColumn();
            numero = new DataGridViewTextBoxColumn();
            punto = new DataGridViewTextBoxColumn();
            Moneda = new DataGridViewTextBoxColumn();
            tipoCambio = new DataGridViewTextBoxColumn();
            netoGravado = new DataGridViewTextBoxColumn();
            iva = new DataGridViewTextBoxColumn();
            netoNoGravado = new DataGridViewTextBoxColumn();
            exento = new DataGridViewTextBoxColumn();
            percIVA = new DataGridViewTextBoxColumn();
            percIIBB = new DataGridViewTextBoxColumn();
            percMunicipalidad = new DataGridViewTextBoxColumn();
            Cuenta = new DataGridViewTextBoxColumn();
            CentroCosto = new DataGridViewTextBoxColumn();
            ventaBindingSource = new BindingSource(components);
            Eliminar = new Button();
            Modificar = new Button();
            Cargar = new Button();
            button4 = new Button();
            button3 = new Button();
            comboBox5 = new ComboBox();
            centroCostoBindingSource = new BindingSource(components);
            label16 = new Label();
            label15 = new Label();
            comboBox4 = new ComboBox();
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
            comboBox3 = new ComboBox();
            monedaBindingSource = new BindingSource(components);
            label6 = new Label();
            textBoxNumero = new TextBox();
            label5 = new Label();
            comboBox2 = new ComboBox();
            tipoComprobanteBindingSource = new BindingSource(components);
            label4 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            comboBox1 = new ComboBox();
            clienteBindingSource = new BindingSource(components);
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label3 = new Label();
            textBoxPunto = new TextBox();
            label17 = new Label();
            textBoxImputacion = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ventaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)centroCostoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuentaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)monedaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoComprobanteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox12);
            groupBox1.Controls.Add(Filtrar);
            groupBox1.Controls.Add(Cobrar);
            groupBox1.Controls.Add(Detalle);
            groupBox1.Controls.Add(dataGridView1);
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
            // textBox12
            // 
            textBox12.Location = new Point(11, 19);
            textBox12.Margin = new Padding(2);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(331, 23);
            textBox12.TabIndex = 47;
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
            Cobrar.Click += Cobrar_Click;
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idVentaDataGridViewTextBoxColumn, fechaDataGridViewTextBoxColumn, imputacionDataGridViewTextBoxColumn, Cliente, TipoComprobante, numero, punto, Moneda, tipoCambio, netoGravado, iva, netoNoGravado, exento, percIVA, percIIBB, percMunicipalidad, Cuenta, CentroCosto });
            dataGridView1.DataSource = ventaBindingSource;
            dataGridView1.Location = new Point(16, 50);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(694, 330);
            dataGridView1.TabIndex = 43;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            idVentaDataGridViewTextBoxColumn.DataPropertyName = "idVenta";
            idVentaDataGridViewTextBoxColumn.HeaderText = "idVenta";
            idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // imputacionDataGridViewTextBoxColumn
            // 
            imputacionDataGridViewTextBoxColumn.DataPropertyName = "imputacion";
            imputacionDataGridViewTextBoxColumn.HeaderText = "imputacion";
            imputacionDataGridViewTextBoxColumn.Name = "imputacionDataGridViewTextBoxColumn";
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "idVenta";
            Cliente.HeaderText = "Cliente";
            Cliente.Name = "Cliente";
            Cliente.Resizable = DataGridViewTriState.True;
            Cliente.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // TipoComprobante
            // 
            TipoComprobante.HeaderText = "TipoComprobante";
            TipoComprobante.Name = "TipoComprobante";
            TipoComprobante.Resizable = DataGridViewTriState.True;
            TipoComprobante.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // numero
            // 
            numero.DataPropertyName = "numero";
            numero.HeaderText = "numero";
            numero.Name = "numero";
            // 
            // punto
            // 
            punto.DataPropertyName = "punto";
            punto.HeaderText = "punto";
            punto.Name = "punto";
            // 
            // Moneda
            // 
            Moneda.DataPropertyName = "punto";
            Moneda.HeaderText = "Moneda";
            Moneda.Name = "Moneda";
            // 
            // tipoCambio
            // 
            tipoCambio.DataPropertyName = "tipoCambio";
            tipoCambio.HeaderText = "tipoCambio";
            tipoCambio.Name = "tipoCambio";
            // 
            // netoGravado
            // 
            netoGravado.DataPropertyName = "netoGravado";
            netoGravado.HeaderText = "netoGravado";
            netoGravado.Name = "netoGravado";
            // 
            // iva
            // 
            iva.DataPropertyName = "iva";
            iva.HeaderText = "iva";
            iva.Name = "iva";
            // 
            // netoNoGravado
            // 
            netoNoGravado.DataPropertyName = "netoNoGravado";
            netoNoGravado.HeaderText = "netoNoGravado";
            netoNoGravado.Name = "netoNoGravado";
            // 
            // exento
            // 
            exento.DataPropertyName = "exento";
            exento.HeaderText = "exento";
            exento.Name = "exento";
            // 
            // percIVA
            // 
            percIVA.DataPropertyName = "percIVA";
            percIVA.HeaderText = "percIVA";
            percIVA.Name = "percIVA";
            // 
            // percIIBB
            // 
            percIIBB.DataPropertyName = "percIIBB";
            percIIBB.HeaderText = "percIIBB";
            percIIBB.Name = "percIIBB";
            // 
            // percMunicipalidad
            // 
            percMunicipalidad.DataPropertyName = "percMunicipalidad";
            percMunicipalidad.HeaderText = "percMunicipalidad";
            percMunicipalidad.Name = "percMunicipalidad";
            // 
            // Cuenta
            // 
            Cuenta.DataPropertyName = "percMunicipalidad";
            Cuenta.HeaderText = "cuenta";
            Cuenta.Name = "Cuenta";
            // 
            // CentroCosto
            // 
            CentroCosto.DataPropertyName = "percMunicipalidad";
            CentroCosto.HeaderText = "CentroCosto";
            CentroCosto.Name = "CentroCosto";
            // 
            // ventaBindingSource
            // 
            ventaBindingSource.DataSource = typeof(Modelos.Venta);
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
            // comboBox5
            // 
            comboBox5.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox5.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox5.DataSource = centroCostoBindingSource;
            comboBox5.DisplayMember = "descripcion";
            comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(60, 367);
            comboBox5.Margin = new Padding(2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(210, 23);
            comboBox5.TabIndex = 73;
            comboBox5.ValueMember = "idCentro";
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
            // comboBox4
            // 
            comboBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox4.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox4.DataSource = cuentaBindingSource;
            comboBox4.DisplayMember = "detalle";
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(60, 332);
            comboBox4.Margin = new Padding(2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(210, 23);
            comboBox4.TabIndex = 70;
            comboBox4.ValueMember = "idCuenta";
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
            // comboBox3
            // 
            comboBox3.DataSource = monedaBindingSource;
            comboBox3.DisplayMember = "Descripcion";
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(78, 163);
            comboBox3.Margin = new Padding(2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(85, 23);
            comboBox3.TabIndex = 51;
            comboBox3.ValueMember = "idMoneda";
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
            // comboBox2
            // 
            comboBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.DataSource = tipoComprobanteBindingSource;
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(76, 101);
            comboBox2.Margin = new Padding(2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(173, 23);
            comboBox2.TabIndex = 46;
            comboBox2.ValueMember = "idTipo";
            // 
            // tipoComprobanteBindingSource
            // 
            tipoComprobanteBindingSource.DataSource = typeof(Modelos.TipoComprobante);
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
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.DataSource = clienteBindingSource;
            comboBox1.DisplayMember = "nombre";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 69);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 23);
            comboBox1.TabIndex = 39;
            comboBox1.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(Modelos.Cliente);
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
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
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 475);
            Controls.Add(textBoxImputacion);
            Controls.Add(label17);
            Controls.Add(textBoxPunto);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(Cargar);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox5);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(comboBox4);
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
            Controls.Add(comboBox3);
            Controls.Add(label6);
            Controls.Add(textBoxNumero);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)tipoComprobanteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox12;
        private Button Filtrar;
        private Button Cobrar;
        private Button Detalle;
        private Button Eliminar;
        private Button Modificar;
        private Button Cargar;
        private Button button4;
        private Button button3;
        private ComboBox comboBox5;
        private Label label16;
        private Label label15;
        private ComboBox comboBox4;
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
        private ComboBox comboBox3;
        private Label label6;
        private TextBox textBoxNumero;
        private Label label5;
        private ComboBox comboBox2;
        private Label label4;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private ComboBox comboBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private BindingSource ventaBindingSource;
        private Label label3;
        private TextBox textBoxPunto;
        private Label label17;
        private TextBox textBoxImputacion;
        private BindingSource clienteBindingSource;
        private BindingSource tipoComprobanteBindingSource;
        private BindingSource cuentaBindingSource;
        private BindingSource monedaBindingSource;
        private BindingSource centroCostoBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn imputacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn TipoComprobante;
        private DataGridViewTextBoxColumn numero;
        private DataGridViewTextBoxColumn punto;
        private DataGridViewTextBoxColumn Moneda;
        private DataGridViewTextBoxColumn tipoCambio;
        private DataGridViewTextBoxColumn netoGravado;
        private DataGridViewTextBoxColumn iva;
        private DataGridViewTextBoxColumn netoNoGravado;
        private DataGridViewTextBoxColumn exento;
        private DataGridViewTextBoxColumn percIVA;
        private DataGridViewTextBoxColumn percIIBB;
        private DataGridViewTextBoxColumn percMunicipalidad;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn CentroCosto;
    }
}