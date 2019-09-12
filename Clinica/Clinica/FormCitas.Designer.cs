namespace Clinica
{
    partial class FormCitas
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label fechaCitaLabel;
            System.Windows.Forms.Label historialLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pacienteIdLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
            this.listaPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listaCitasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaCitasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaCitasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.citaDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaCitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.historialTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pacienteIdComboBox = new System.Windows.Forms.ComboBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.citaDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaEspecialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            fechaCitaLabel = new System.Windows.Forms.Label();
            historialLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            pacienteIdLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).BeginInit();
            this.listaCitasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citaDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(374, 44);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 25;
            activoLabel.Text = "Activo:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(111, 44);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 27;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaCitaLabel
            // 
            fechaCitaLabel.AutoSize = true;
            fechaCitaLabel.Location = new System.Drawing.Point(16, 107);
            fechaCitaLabel.Name = "fechaCitaLabel";
            fechaCitaLabel.Size = new System.Drawing.Size(61, 13);
            fechaCitaLabel.TabIndex = 29;
            fechaCitaLabel.Text = "Fecha Cita:";
            // 
            // historialLabel
            // 
            historialLabel.AutoSize = true;
            historialLabel.Location = new System.Drawing.Point(30, 252);
            historialLabel.Name = "historialLabel";
            historialLabel.Size = new System.Drawing.Size(68, 13);
            historialLabel.TabIndex = 31;
            historialLabel.Text = "Comentarios:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(18, 44);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 33;
            idLabel.Text = "Id:";
            // 
            // pacienteIdLabel
            // 
            pacienteIdLabel.AutoSize = true;
            pacienteIdLabel.Location = new System.Drawing.Point(16, 73);
            pacienteIdLabel.Name = "pacienteIdLabel";
            pacienteIdLabel.Size = new System.Drawing.Size(64, 13);
            pacienteIdLabel.TabIndex = 35;
            pacienteIdLabel.Text = "Paciente Id:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(454, 271);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 37;
            totalLabel.Text = "Total:";
            // 
            // listaPacientesBindingSource
            // 
            this.listaPacientesBindingSource.DataSource = typeof(Clinica.BL.Paciente);
            // 
            // listaMedicosBindingSource
            // 
            this.listaMedicosBindingSource.DataSource = typeof(Clinica.BL.Medico);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(510, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(563, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gastos Medicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(475, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "ANULADO";
            this.label3.Visible = false;
            // 
            // listaCitasBindingSource
            // 
            this.listaCitasBindingSource.DataSource = typeof(Clinica.BL.Cita);
            this.listaCitasBindingSource.CurrentChanged += new System.EventHandler(this.listaCitasBindingSource_CurrentChanged);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Anular";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaCitasBindingNavigatorSaveItem
            // 
            this.listaCitasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCitasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCitasBindingNavigatorSaveItem.Image")));
            this.listaCitasBindingNavigatorSaveItem.Name = "listaCitasBindingNavigatorSaveItem";
            this.listaCitasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaCitasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaCitasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCitasBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listaCitasBindingNavigator
            // 
            this.listaCitasBindingNavigator.AddNewItem = null;
            this.listaCitasBindingNavigator.BindingSource = this.listaCitasBindingSource;
            this.listaCitasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCitasBindingNavigator.DeleteItem = null;
            this.listaCitasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.listaCitasBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaCitasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaCitasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCitasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCitasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCitasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCitasBindingNavigator.Name = "listaCitasBindingNavigator";
            this.listaCitasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCitasBindingNavigator.Size = new System.Drawing.Size(624, 25);
            this.listaCitasBindingNavigator.TabIndex = 0;
            this.listaCitasBindingNavigator.Text = "bindingNavigator1";
            // 
            // citaDetalleBindingSource
            // 
            this.citaDetalleBindingSource.AllowNew = false;
            this.citaDetalleBindingSource.DataMember = "CitaDetalle";
            this.citaDetalleBindingSource.DataSource = this.listaCitasBindingSource;
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaCitasBindingSource, "Activo", true));
            this.activoCheckBox.Enabled = false;
            this.activoCheckBox.Location = new System.Drawing.Point(420, 39);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(30, 24);
            this.activoCheckBox.TabIndex = 26;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCitasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(157, 41);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 28;
            // 
            // fechaCitaDateTimePicker
            // 
            this.fechaCitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCitasBindingSource, "FechaCita", true));
            this.fechaCitaDateTimePicker.Location = new System.Drawing.Point(88, 101);
            this.fechaCitaDateTimePicker.Name = "fechaCitaDateTimePicker";
            this.fechaCitaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCitaDateTimePicker.TabIndex = 30;
            // 
            // historialTextBox
            // 
            this.historialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Historial", true));
            this.historialTextBox.Location = new System.Drawing.Point(21, 268);
            this.historialTextBox.Multiline = true;
            this.historialTextBox.Name = "historialTextBox";
            this.historialTextBox.Size = new System.Drawing.Size(414, 63);
            this.historialTextBox.TabIndex = 32;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Id", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "00000"));
            this.idTextBox.Location = new System.Drawing.Point(43, 41);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(52, 20);
            this.idTextBox.TabIndex = 34;
            // 
            // pacienteIdComboBox
            // 
            this.pacienteIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaCitasBindingSource, "PacienteId", true));
            this.pacienteIdComboBox.DataSource = this.listaPacientesBindingSource;
            this.pacienteIdComboBox.DisplayMember = "Nombre";
            this.pacienteIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacienteIdComboBox.FormattingEnabled = true;
            this.pacienteIdComboBox.Location = new System.Drawing.Point(88, 70);
            this.pacienteIdComboBox.Name = "pacienteIdComboBox";
            this.pacienteIdComboBox.Size = new System.Drawing.Size(347, 21);
            this.pacienteIdComboBox.TabIndex = 36;
            this.pacienteIdComboBox.ValueMember = "Id";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitasBindingSource, "Total", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.totalTextBox.Location = new System.Drawing.Point(494, 268);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.ReadOnly = true;
            this.totalTextBox.Size = new System.Drawing.Size(116, 20);
            this.totalTextBox.TabIndex = 38;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // citaDetalleDataGridView
            // 
            this.citaDetalleDataGridView.AutoGenerateColumns = false;
            this.citaDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citaDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.citaDetalleDataGridView.DataSource = this.citaDetalleBindingSource;
            this.citaDetalleDataGridView.Location = new System.Drawing.Point(12, 168);
            this.citaDetalleDataGridView.Name = "citaDetalleDataGridView";
            this.citaDetalleDataGridView.Size = new System.Drawing.Size(598, 71);
            this.citaDetalleDataGridView.TabIndex = 38;
            this.citaDetalleDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.citaDetalleDataGridView_CellEndEdit);
            this.citaDetalleDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.citaDetalleDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MedicoId";
            this.dataGridViewTextBoxColumn3.DataSource = this.listaMedicosBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Medico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "Id";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // listaEspecialidadesBindingSource
            // 
            this.listaEspecialidadesBindingSource.DataSource = typeof(Clinica.BL.Especialidad);
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(624, 338);
            this.Controls.Add(this.citaDetalleDataGridView);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(fechaCitaLabel);
            this.Controls.Add(this.fechaCitaDateTimePicker);
            this.Controls.Add(historialLabel);
            this.Controls.Add(this.historialTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(pacienteIdLabel);
            this.Controls.Add(this.pacienteIdComboBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaCitasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCitas";
            this.Text = "Citas";
            this.Load += new System.EventHandler(this.FormCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitasBindingNavigator)).EndInit();
            this.listaCitasBindingNavigator.ResumeLayout(false);
            this.listaCitasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citaDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citaDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaPacientesBindingSource;
        private System.Windows.Forms.BindingSource listaMedicosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton listaCitasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingNavigator listaCitasBindingNavigator;
        private System.Windows.Forms.BindingSource listaCitasBindingSource;
        private System.Windows.Forms.BindingSource citaDetalleBindingSource;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaCitaDateTimePicker;
        private System.Windows.Forms.TextBox historialTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox pacienteIdComboBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.DataGridView citaDetalleDataGridView;
        private System.Windows.Forms.BindingSource listaEspecialidadesBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}