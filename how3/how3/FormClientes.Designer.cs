namespace how3
{
    partial class FormVeiculos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.how3DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.how3DataSet = new how3.how3DataSet();
            this.IDCliente = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxDocumento = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.how3DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.how3DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Location = new System.Drawing.Point(118, 77);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCliente.TabIndex = 0;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvarCliente_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNome.Location = new System.Drawing.Point(118, 51);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(346, 20);
            this.textBoxNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome:";
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(280, 77);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 7;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigoCliente,
            this.ColumnDocumento,
            this.ColumnNome});
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 106);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(591, 250);
            this.dataGridViewClientes.TabIndex = 10;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
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
            // how3DataSetBindingSource
            // 
            this.how3DataSetBindingSource.DataSource = this.how3DataSet;
            this.how3DataSetBindingSource.Position = 0;
            // 
            // how3DataSet
            // 
            this.how3DataSet.DataSetName = "how3DataSet";
            this.how3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IDCliente
            // 
            this.IDCliente.AutoSize = true;
            this.IDCliente.Location = new System.Drawing.Point(429, 25);
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.Size = new System.Drawing.Size(0, 13);
            this.IDCliente.TabIndex = 11;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(199, 77);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 12;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxDocumento
            // 
            this.textBoxDocumento.Location = new System.Drawing.Point(118, 25);
            this.textBoxDocumento.Mask = "999,999,999-99";
            this.textBoxDocumento.Name = "textBoxDocumento";
            this.textBoxDocumento.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocumento.TabIndex = 13;
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 360);
            this.Controls.Add(this.textBoxDocumento);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.IDCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.btSalvarCliente);
            this.Name = "FormClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.how3DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.how3DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.BindingSource how3DataSetBindingSource;
        private how3DataSet how3DataSet;
        private System.Windows.Forms.Label IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.MaskedTextBox textBoxDocumento;
    }
}

