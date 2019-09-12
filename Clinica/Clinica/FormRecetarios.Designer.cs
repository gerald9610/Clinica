namespace Clinica
{
    partial class FormRecetarios
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label descripcionLabel1;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label categoriaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecetarios));
            this.listaRecetasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaRecetasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listaRecetasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.listaCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.categoriaIdComboBox = new System.Windows.Forms.ComboBox();
            activoLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            descripcionLabel1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            categoriaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecetasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecetasBindingNavigator)).BeginInit();
            this.listaRecetasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(160, 53);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 8;
            activoLabel.Text = "Activo:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(13, 154);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 11;
            cantidadLabel.Text = "Cantidad:";
            // 
            // descripcionLabel1
            // 
            descripcionLabel1.AutoSize = true;
            descripcionLabel1.Location = new System.Drawing.Point(13, 84);
            descripcionLabel1.Name = "descripcionLabel1";
            descripcionLabel1.Size = new System.Drawing.Size(66, 13);
            descripcionLabel1.TabIndex = 9;
            descripcionLabel1.Text = "Descripcion:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(13, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 13;
            idLabel.Text = "Id:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(181, 154);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(49, 13);
            precioLabel.TabIndex = 12;
            precioLabel.Text = "Precio L.";
            // 
            // categoriaIdLabel
            // 
            categoriaIdLabel.AutoSize = true;
            categoriaIdLabel.Location = new System.Drawing.Point(13, 116);
            categoriaIdLabel.Name = "categoriaIdLabel";
            categoriaIdLabel.Size = new System.Drawing.Size(55, 13);
            categoriaIdLabel.TabIndex = 13;
            categoriaIdLabel.Text = "Categoria:";
            // 
            // listaRecetasBindingSource
            // 
            this.listaRecetasBindingSource.DataSource = typeof(Clinica.BL.Receta);
            // 
            // listaRecetasBindingNavigator
            // 
            this.listaRecetasBindingNavigator.AddNewItem = null;
            this.listaRecetasBindingNavigator.BindingSource = this.listaRecetasBindingSource;
            this.listaRecetasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaRecetasBindingNavigator.DeleteItem = null;
            this.listaRecetasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaRecetasBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaRecetasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaRecetasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaRecetasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaRecetasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaRecetasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaRecetasBindingNavigator.Name = "listaRecetasBindingNavigator";
            this.listaRecetasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaRecetasBindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.listaRecetasBindingNavigator.TabIndex = 0;
            this.listaRecetasBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            // listaRecetasBindingNavigatorSaveItem
            // 
            this.listaRecetasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaRecetasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaRecetasBindingNavigatorSaveItem.Image")));
            this.listaRecetasBindingNavigatorSaveItem.Name = "listaRecetasBindingNavigatorSaveItem";
            this.listaRecetasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaRecetasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaRecetasBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaRecetasBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // listaCategoriaBindingSource
            // 
            this.listaCategoriaBindingSource.DataSource = typeof(Clinica.BL.Categoria);
            this.listaCategoriaBindingSource.CurrentChanged += new System.EventHandler(this.listaCategoriaBindingSource_CurrentChanged);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaRecetasBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(206, 48);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 7;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRecetasBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(71, 151);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(104, 20);
            this.cantidadTextBox.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRecetasBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(86, 81);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(253, 20);
            this.descripcionTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRecetasBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(38, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 12;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaRecetasBindingSource, "Precio", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
            this.precioTextBox.Location = new System.Drawing.Point(235, 151);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(104, 20);
            this.precioTextBox.TabIndex = 6;
            // 
            // categoriaIdComboBox
            // 
            this.categoriaIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaRecetasBindingSource, "CategoriaId", true));
            this.categoriaIdComboBox.DataSource = this.listaCategoriaBindingSource;
            this.categoriaIdComboBox.DisplayMember = "Descripcion";
            this.categoriaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaIdComboBox.FormattingEnabled = true;
            this.categoriaIdComboBox.Location = new System.Drawing.Point(86, 113);
            this.categoriaIdComboBox.Name = "categoriaIdComboBox";
            this.categoriaIdComboBox.Size = new System.Drawing.Size(121, 21);
            this.categoriaIdComboBox.TabIndex = 2;
            this.categoriaIdComboBox.ValueMember = "Id";
            // 
            // FormRecetarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 191);
            this.Controls.Add(categoriaIdLabel);
            this.Controls.Add(this.categoriaIdComboBox);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(descripcionLabel1);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(precioLabel);
            this.Controls.Add(this.precioTextBox);
            this.Controls.Add(this.listaRecetasBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRecetarios";
            this.Text = "Recetarios";
            ((System.ComponentModel.ISupportInitialize)(this.listaRecetasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaRecetasBindingNavigator)).EndInit();
            this.listaRecetasBindingNavigator.ResumeLayout(false);
            this.listaRecetasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaRecetasBindingSource;
        private System.Windows.Forms.BindingNavigator listaRecetasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaRecetasBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.BindingSource listaCategoriaBindingSource;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.ComboBox categoriaIdComboBox;
    }
}