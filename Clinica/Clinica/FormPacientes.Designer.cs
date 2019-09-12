namespace Clinica
{
    partial class FormPacientes
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
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label tallaLabel;
            System.Windows.Forms.Label estadoIdLabel;
            System.Windows.Forms.Label tipoIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            this.listaPacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.listaPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.listaPacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.tallaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listaEstadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaTiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoIdComboBox = new System.Windows.Forms.ComboBox();
            this.tipoIdComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            tallaLabel = new System.Windows.Forms.Label();
            estadoIdLabel = new System.Windows.Forms.Label();
            tipoIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).BeginInit();
            this.listaPacientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(360, 41);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 23;
            activoLabel.Text = "Activo:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(186, 109);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 25;
            edadLabel.Text = "Edad:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(186, 41);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 26;
            idLabel.Text = "Id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(186, 76);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 30;
            nombreLabel.Text = "Nombre:";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(187, 186);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(34, 13);
            pesoLabel.TabIndex = 31;
            pesoLabel.Text = "Peso:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(360, 109);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 24;
            sexoLabel.Text = "Sexo:";
            // 
            // tallaLabel
            // 
            tallaLabel.AutoSize = true;
            tallaLabel.Location = new System.Drawing.Point(361, 186);
            tallaLabel.Name = "tallaLabel";
            tallaLabel.Size = new System.Drawing.Size(33, 13);
            tallaLabel.TabIndex = 13;
            tallaLabel.Text = "Talla:";
            // 
            // estadoIdLabel
            // 
            estadoIdLabel.AutoSize = true;
            estadoIdLabel.Location = new System.Drawing.Point(187, 149);
            estadoIdLabel.Name = "estadoIdLabel";
            estadoIdLabel.Size = new System.Drawing.Size(65, 13);
            estadoIdLabel.TabIndex = 31;
            estadoIdLabel.Text = "Estado Civil:";
            // 
            // tipoIdLabel
            // 
            tipoIdLabel.AutoSize = true;
            tipoIdLabel.Location = new System.Drawing.Point(186, 220);
            tipoIdLabel.Name = "tipoIdLabel";
            tipoIdLabel.Size = new System.Drawing.Size(83, 13);
            tipoIdLabel.TabIndex = 32;
            tipoIdLabel.Text = "Tipo de Seguro:";
            // 
            // listaPacientesBindingNavigator
            // 
            this.listaPacientesBindingNavigator.AddNewItem = null;
            this.listaPacientesBindingNavigator.BindingSource = this.listaPacientesBindingSource;
            this.listaPacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaPacientesBindingNavigator.DeleteItem = null;
            this.listaPacientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaPacientesBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaPacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaPacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaPacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaPacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaPacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaPacientesBindingNavigator.Name = "listaPacientesBindingNavigator";
            this.listaPacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaPacientesBindingNavigator.Size = new System.Drawing.Size(554, 25);
            this.listaPacientesBindingNavigator.TabIndex = 0;
            this.listaPacientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // listaPacientesBindingSource
            // 
            this.listaPacientesBindingSource.DataSource = typeof(Clinica.BL.Paciente);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // listaPacientesBindingNavigatorSaveItem
            // 
            this.listaPacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaPacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaPacientesBindingNavigatorSaveItem.Image")));
            this.listaPacientesBindingNavigatorSaveItem.Name = "listaPacientesBindingNavigatorSaveItem";
            this.listaPacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaPacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaPacientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaPacientesBindingNavigatorSaveItem_Click);
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
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaPacientesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(413, 36);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 8;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(239, 106);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(104, 20);
            this.edadTextBox.TabIndex = 2;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(239, 38);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 27;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(239, 73);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(278, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(240, 183);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(104, 20);
            this.pesoTextBox.TabIndex = 5;
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(413, 106);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(104, 20);
            this.sexoTextBox.TabIndex = 3;
            // 
            // tallaTextBox
            // 
            this.tallaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Talla", true));
            this.tallaTextBox.Location = new System.Drawing.Point(414, 183);
            this.tallaTextBox.Name = "tallaTextBox";
            this.tallaTextBox.Size = new System.Drawing.Size(104, 20);
            this.tallaTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(343, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(517, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(517, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(431, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "* Campos Obligatorios";
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.listaPacientesBindingSource, "Foto", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.fotoPictureBox.Location = new System.Drawing.Point(22, 43);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(148, 168);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 20;
            this.fotoPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar Foto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg, png, gif | *.jpg; *.png, *.gif";
            // 
            // listaEstadosBindingSource
            // 
            this.listaEstadosBindingSource.DataSource = typeof(Clinica.BL.Estado);
            // 
            // listaTiposBindingSource
            // 
            this.listaTiposBindingSource.DataSource = typeof(Clinica.BL.Tipo);
            this.listaTiposBindingSource.CurrentChanged += new System.EventHandler(this.listaTiposBindingSource_CurrentChanged);
            // 
            // estadoIdComboBox
            // 
            this.estadoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaPacientesBindingSource, "EstadoId", true));
            this.estadoIdComboBox.DataSource = this.listaEstadosBindingSource;
            this.estadoIdComboBox.DisplayMember = "Descripcion";
            this.estadoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoIdComboBox.FormattingEnabled = true;
            this.estadoIdComboBox.Location = new System.Drawing.Point(258, 146);
            this.estadoIdComboBox.Name = "estadoIdComboBox";
            this.estadoIdComboBox.Size = new System.Drawing.Size(136, 21);
            this.estadoIdComboBox.TabIndex = 4;
            this.estadoIdComboBox.ValueMember = "Id";
            // 
            // tipoIdComboBox
            // 
            this.tipoIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaPacientesBindingSource, "TipoId", true));
            this.tipoIdComboBox.DataSource = this.listaTiposBindingSource;
            this.tipoIdComboBox.DisplayMember = "Descripcion";
            this.tipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoIdComboBox.FormattingEnabled = true;
            this.tipoIdComboBox.Location = new System.Drawing.Point(275, 217);
            this.tipoIdComboBox.Name = "tipoIdComboBox";
            this.tipoIdComboBox.Size = new System.Drawing.Size(141, 21);
            this.tipoIdComboBox.TabIndex = 7;
            this.tipoIdComboBox.ValueMember = "Id";
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 273);
            this.Controls.Add(tipoIdLabel);
            this.Controls.Add(this.tipoIdComboBox);
            this.Controls.Add(estadoIdLabel);
            this.Controls.Add(this.estadoIdComboBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(pesoLabel);
            this.Controls.Add(this.pesoTextBox);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoTextBox);
            this.Controls.Add(tallaLabel);
            this.Controls.Add(this.tallaTextBox);
            this.Controls.Add(this.listaPacientesBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPacientes";
            this.Text = "Datos de Pacientes";
            this.Load += new System.EventHandler(this.FormPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).EndInit();
            this.listaPacientesBindingNavigator.ResumeLayout(false);
            this.listaPacientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEstadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaTiposBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaPacientesBindingSource;
        private System.Windows.Forms.BindingNavigator listaPacientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton listaPacientesBindingNavigatorSaveItem;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.TextBox sexoTextBox;
        private System.Windows.Forms.TextBox tallaTextBox;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource listaEstadosBindingSource;
        private System.Windows.Forms.BindingSource listaTiposBindingSource;
        private System.Windows.Forms.ComboBox estadoIdComboBox;
        private System.Windows.Forms.ComboBox tipoIdComboBox;
    }
}