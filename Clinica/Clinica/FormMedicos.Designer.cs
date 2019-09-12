namespace Clinica
{
    partial class FormMedicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMedicos));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label jornadaIdLabel;
            System.Windows.Forms.Label especialidadIdLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label costoLabel;
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
            this.listaMedicosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaMedicosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaEspecialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaJornadasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaMedicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.jornadaIdComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.especialidadIdComboBox = new System.Windows.Forms.ComboBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.costoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            jornadaIdLabel = new System.Windows.Forms.Label();
            especialidadIdLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            activoLabel = new System.Windows.Forms.Label();
            costoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingNavigator)).BeginInit();
            this.listaMedicosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // listaMedicosBindingNavigatorSaveItem
            // 
            this.listaMedicosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaMedicosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaMedicosBindingNavigatorSaveItem.Image")));
            this.listaMedicosBindingNavigatorSaveItem.Name = "listaMedicosBindingNavigatorSaveItem";
            this.listaMedicosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaMedicosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaMedicosBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaMedicosBindingNavigatorSaveItem_Click);
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
            // listaMedicosBindingNavigator
            // 
            this.listaMedicosBindingNavigator.AddNewItem = null;
            this.listaMedicosBindingNavigator.BindingSource = this.listaMedicosBindingSource;
            this.listaMedicosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaMedicosBindingNavigator.DeleteItem = null;
            this.listaMedicosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaMedicosBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaMedicosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaMedicosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaMedicosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaMedicosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaMedicosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaMedicosBindingNavigator.Name = "listaMedicosBindingNavigator";
            this.listaMedicosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaMedicosBindingNavigator.Size = new System.Drawing.Size(408, 25);
            this.listaMedicosBindingNavigator.TabIndex = 13;
            this.listaMedicosBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaEspecialidadesBindingSource
            // 
            this.listaEspecialidadesBindingSource.DataSource = typeof(Clinica.BL.Especialidad);
            this.listaEspecialidadesBindingSource.CurrentChanged += new System.EventHandler(this.listaEspecialidadesBindingSource_CurrentChanged);
            // 
            // listaJornadasBindingSource
            // 
            this.listaJornadasBindingSource.DataSource = typeof(Clinica.BL.Jornada);
            this.listaJornadasBindingSource.CurrentChanged += new System.EventHandler(this.listaJornadasBindingSource_CurrentChanged);
            // 
            // listaMedicosBindingSource
            // 
            this.listaMedicosBindingSource.DataSource = typeof(Clinica.BL.Medico);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(22, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(71, 80);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(317, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(22, 83);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 12;
            nombreLabel.Text = "Nombre:";
            // 
            // jornadaIdComboBox
            // 
            this.jornadaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicosBindingSource, "JornadaId", true));
            this.jornadaIdComboBox.DataSource = this.listaJornadasBindingSource;
            this.jornadaIdComboBox.DisplayMember = "Descripcion";
            this.jornadaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.jornadaIdComboBox.FormattingEnabled = true;
            this.jornadaIdComboBox.Location = new System.Drawing.Point(98, 190);
            this.jornadaIdComboBox.Name = "jornadaIdComboBox";
            this.jornadaIdComboBox.Size = new System.Drawing.Size(181, 21);
            this.jornadaIdComboBox.TabIndex = 9;
            this.jornadaIdComboBox.ValueMember = "Id";
            // 
            // jornadaIdLabel
            // 
            jornadaIdLabel.AutoSize = true;
            jornadaIdLabel.Location = new System.Drawing.Point(22, 193);
            jornadaIdLabel.Name = "jornadaIdLabel";
            jornadaIdLabel.Size = new System.Drawing.Size(48, 13);
            jornadaIdLabel.TabIndex = 21;
            jornadaIdLabel.Text = "Jornada:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(47, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(60, 20);
            this.idTextBox.TabIndex = 20;
            // 
            // especialidadIdComboBox
            // 
            this.especialidadIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaMedicosBindingSource, "EspecialidadId", true));
            this.especialidadIdComboBox.DataSource = this.listaEspecialidadesBindingSource;
            this.especialidadIdComboBox.DisplayMember = "Descripcion";
            this.especialidadIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.especialidadIdComboBox.FormattingEnabled = true;
            this.especialidadIdComboBox.Location = new System.Drawing.Point(98, 156);
            this.especialidadIdComboBox.Name = "especialidadIdComboBox";
            this.especialidadIdComboBox.Size = new System.Drawing.Size(181, 21);
            this.especialidadIdComboBox.TabIndex = 4;
            this.especialidadIdComboBox.ValueMember = "Id";
            // 
            // especialidadIdLabel
            // 
            especialidadIdLabel.AutoSize = true;
            especialidadIdLabel.Location = new System.Drawing.Point(22, 159);
            especialidadIdLabel.Name = "especialidadIdLabel";
            especialidadIdLabel.Size = new System.Drawing.Size(70, 13);
            especialidadIdLabel.TabIndex = 17;
            especialidadIdLabel.Text = "Especialidad:";
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(98, 118);
            this.codigoTextBox.MaxLength = 8;
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(103, 20);
            this.codigoTextBox.TabIndex = 2;
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(22, 121);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(65, 13);
            codigoLabel.TabIndex = 15;
            codigoLabel.Text = "Colegiación:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaMedicosBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(275, 225);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(121, 24);
            this.activoCheckBox.TabIndex = 3;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(229, 230);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 13;
            activoLabel.Text = "Activo:";
            // 
            // costoLabel
            // 
            costoLabel.AutoSize = true;
            costoLabel.Location = new System.Drawing.Point(22, 230);
            costoLabel.Name = "costoLabel";
            costoLabel.Size = new System.Drawing.Size(93, 13);
            costoLabel.TabIndex = 21;
            costoLabel.Text = "Valor de Consulta:";
            // 
            // costoTextBox
            // 
            this.costoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaMedicosBindingSource, "Costo", true));
            this.costoTextBox.Location = new System.Drawing.Point(121, 227);
            this.costoTextBox.Name = "costoTextBox";
            this.costoTextBox.Size = new System.Drawing.Size(100, 20);
            this.costoTextBox.TabIndex = 22;
            // 
            // FormMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 256);
            this.Controls.Add(costoLabel);
            this.Controls.Add(this.costoTextBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(codigoLabel);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(especialidadIdLabel);
            this.Controls.Add(this.especialidadIdComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(jornadaIdLabel);
            this.Controls.Add(this.jornadaIdComboBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.listaMedicosBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMedicos";
            this.Text = "Datos de Medicos";
      //      this.Load += new System.EventHandler(this.FormMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingNavigator)).EndInit();
            this.listaMedicosBindingNavigator.ResumeLayout(false);
            this.listaMedicosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaEspecialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaJornadasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaMedicosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaEspecialidadesBindingSource;
        private System.Windows.Forms.BindingSource listaJornadasBindingSource;
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
        private System.Windows.Forms.ToolStripButton listaMedicosBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingNavigator listaMedicosBindingNavigator;
        private System.Windows.Forms.BindingSource listaMedicosBindingSource;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox jornadaIdComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox especialidadIdComboBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox costoTextBox;
    }
}