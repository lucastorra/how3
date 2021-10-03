namespace how3
{
    partial class FormVeiculo
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
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.dataGridViewVeiculos = new System.Windows.Forms.DataGridView();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxModelo = new System.Windows.Forms.TextBox();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.comboBoxVeiculo = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.IDVeiculo = new System.Windows.Forms.Label();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(193, 69);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 15;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // dataGridViewVeiculos
            // 
            this.dataGridViewVeiculos.AllowUserToOrderColumns = true;
            this.dataGridViewVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoCliente,
            this.ColumnMarca,
            this.Marca,
            this.ColumnModelo});
            this.dataGridViewVeiculos.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewVeiculos.Name = "dataGridViewVeiculos";
            this.dataGridViewVeiculos.Size = new System.Drawing.Size(591, 250);
            this.dataGridViewVeiculos.TabIndex = 100;
            this.dataGridViewVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeiculos_CellClick);
            this.dataGridViewVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVeiculos_CellDoubleClick);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(274, 69);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(61, 42);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 17;
            this.labelModelo.Text = "Modelo:";
            // 
            // textBoxModelo
            // 
            this.textBoxModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxModelo.Location = new System.Drawing.Point(112, 39);
            this.textBoxModelo.Name = "textBoxModelo";
            this.textBoxModelo.Size = new System.Drawing.Size(346, 20);
            this.textBoxModelo.TabIndex = 5;
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Location = new System.Drawing.Point(112, 69);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCliente.TabIndex = 10;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvarCliente_Click);
            // 
            // comboBoxVeiculo
            // 
            this.comboBoxVeiculo.FormattingEnabled = true;
            this.comboBoxVeiculo.Items.AddRange(new object[] {
            "FIAT",
            "CHEVROLET",
            "VOLKSWAGEN",
            "JEEP"});
            this.comboBoxVeiculo.Location = new System.Drawing.Point(112, 12);
            this.comboBoxVeiculo.Name = "comboBoxVeiculo";
            this.comboBoxVeiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVeiculo.TabIndex = 1;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(66, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 23;
            this.labelMarca.Text = "Marca:";
            // 
            // IDVeiculo
            // 
            this.IDVeiculo.AutoSize = true;
            this.IDVeiculo.Location = new System.Drawing.Point(422, 14);
            this.IDVeiculo.Name = "IDVeiculo";
            this.IDVeiculo.Size = new System.Drawing.Size(56, 13);
            this.IDVeiculo.TabIndex = 24;
            this.IDVeiculo.Text = "ID Veiculo";
            // 
            // ColumnCodigoCliente
            // 
            this.ColumnCodigoCliente.HeaderText = "Codigo Do Veículo";
            this.ColumnCodigoCliente.Name = "ColumnCodigoCliente";
            this.ColumnCodigoCliente.Visible = false;
            // 
            // ColumnMarca
            // 
            this.ColumnMarca.HeaderText = "MarcaCod";
            this.ColumnMarca.Name = "ColumnMarca";
            this.ColumnMarca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnMarca.Visible = false;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // ColumnModelo
            // 
            this.ColumnModelo.HeaderText = "Modelo";
            this.ColumnModelo.Name = "ColumnModelo";
            this.ColumnModelo.Width = 300;
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 354);
            this.Controls.Add(this.IDVeiculo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.comboBoxVeiculo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.dataGridViewVeiculos);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxModelo);
            this.Controls.Add(this.btSalvarCliente);
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de veículos";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewVeiculos;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxModelo;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.ComboBox comboBoxVeiculo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label IDVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModelo;
    }
}