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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelModelo = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.comboBoxVeiculo = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(193, 69);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 20;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoCliente,
            this.ColumnDocumento,
            this.ColumnNome});
            this.dataGridViewClientes.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(591, 250);
            this.dataGridViewClientes.TabIndex = 19;
            // 
            // ColumnCodigoCliente
            // 
            this.ColumnCodigoCliente.HeaderText = "Codigo Do Cliente";
            this.ColumnCodigoCliente.Name = "ColumnCodigoCliente";
            this.ColumnCodigoCliente.Visible = false;
            // 
            // ColumnDocumento
            // 
            this.ColumnDocumento.HeaderText = "Documento";
            this.ColumnDocumento.Name = "ColumnDocumento";
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 300;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(274, 69);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 18;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
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
            // textBoxNome
            // 
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Location = new System.Drawing.Point(112, 39);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(346, 20);
            this.textBoxNome.TabIndex = 15;
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Location = new System.Drawing.Point(112, 69);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCliente.TabIndex = 14;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            // 
            // comboBoxVeiculo
            // 
            this.comboBoxVeiculo.FormattingEnabled = true;
            this.comboBoxVeiculo.Location = new System.Drawing.Point(112, 12);
            this.comboBoxVeiculo.Name = "comboBoxVeiculo";
            this.comboBoxVeiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVeiculo.TabIndex = 22;
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(66, 15);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 23;
            this.labelMarca.Text = "Marca:";
            this.labelMarca.Click += new System.EventHandler(this.label3_Click);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 354);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.comboBoxVeiculo);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btSalvarCliente);
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de veículos";
            this.Load += new System.EventHandler(this.FormVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.ComboBox comboBoxVeiculo;
        private System.Windows.Forms.Label labelMarca;
    }
}