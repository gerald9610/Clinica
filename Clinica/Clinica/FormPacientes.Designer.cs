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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPacientes));
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label tallaLabel;
            this.listaPacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaPacientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.listaPacientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.sexoTextBox = new System.Windows.Forms.TextBox();
            this.tallaTextBox = new System.Windows.Forms.TextBox();
            activoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            tallaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).BeginInit();
            this.listaPacientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaPacientesBindingSource
            // 
            this.listaPacientesBindingSource.DataSource = typeof(Clinica.BL.Paciente);
            // 
            // listaPacientesBindingNavigator
            // 
            this.listaPacientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaPacientesBindingNavigator.BindingSource = this.listaPacientesBindingSource;
            this.listaPacientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaPacientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.listaPacientesBindingNavigatorSaveItem});
            this.listaPacientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaPacientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaPacientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaPacientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaPacientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaPacientesBindingNavigator.Name = "listaPacientesBindingNavigator";
            this.listaPacientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaPacientesBindingNavigator.Size = new System.Drawing.Size(380, 25);
            this.listaPacientesBindingNavigator.TabIndex = 0;
            this.listaPacientesBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
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
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // listaPacientesBindingNavigatorSaveItem
            // 
            this.listaPacientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaPacientesBindingNavigatorSaveItem.Enabled = false;
            this.listaPacientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaPacientesBindingNavigatorSaveItem.Image")));
            this.listaPacientesBindingNavigatorSaveItem.Name = "listaPacientesBindingNavigatorSaveItem";
            this.listaPacientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaPacientesBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(194, 40);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 1;
            activoLabel.Text = "Activo:";
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaPacientesBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(247, 35);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.activoCheckBox.TabIndex = 2;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.Location = new System.Drawing.Point(20, 108);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 3;
            edadLabel.Text = "Edad:";
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(73, 105);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(104, 20);
            this.edadTextBox.TabIndex = 4;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(20, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 5;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(73, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(104, 20);
            this.idTextBox.TabIndex = 6;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(20, 75);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(73, 72);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(278, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(21, 142);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(34, 13);
            pesoLabel.TabIndex = 9;
            pesoLabel.Text = "Peso:";
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(74, 139);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(104, 20);
            this.pesoTextBox.TabIndex = 10;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(194, 108);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(34, 13);
            sexoLabel.TabIndex = 11;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoTextBox
            // 
            this.sexoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Sexo", true));
            this.sexoTextBox.Location = new System.Drawing.Point(247, 105);
            this.sexoTextBox.Name = "sexoTextBox";
            this.sexoTextBox.Size = new System.Drawing.Size(104, 20);
            this.sexoTextBox.TabIndex = 12;
            // 
            // tallaLabel
            // 
            tallaLabel.AutoSize = true;
            tallaLabel.Location = new System.Drawing.Point(195, 142);
            tallaLabel.Name = "tallaLabel";
            tallaLabel.Size = new System.Drawing.Size(33, 13);
            tallaLabel.TabIndex = 13;
            tallaLabel.Text = "Talla:";
            // 
            // tallaTextBox
            // 
            this.tallaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaPacientesBindingSource, "Talla", true));
            this.tallaTextBox.Location = new System.Drawing.Point(248, 139);
            this.tallaTextBox.Name = "tallaTextBox";
            this.tallaTextBox.Size = new System.Drawing.Size(104, 20);
            this.tallaTextBox.TabIndex = 14;
            // 
            // FormPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 185);
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
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPacientesBindingNavigator)).EndInit();
            this.listaPacientesBindingNavigator.ResumeLayout(false);
            this.listaPacientesBindingNavigator.PerformLayout();
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
    }
}