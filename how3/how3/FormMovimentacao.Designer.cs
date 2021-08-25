namespace how3
{
    partial class FormMovimentacao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.btSalvarCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxVeiculo = new System.Windows.Forms.ComboBox();
            this.IDMovimentacao = new System.Windows.Forms.Label();
            this.textBoxPlaca = new System.Windows.Forms.MaskedTextBox();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxDataLocacao = new System.Windows.Forms.MaskedTextBox();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigoVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnVeiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCodigoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDataMovto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxClientes = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placa";
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(204, 120);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(75, 23);
            this.buttonExcluir.TabIndex = 15;
            this.buttonExcluir.Text = "Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(285, 120);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // btSalvarCliente
            // 
            this.btSalvarCliente.Location = new System.Drawing.Point(123, 120);
            this.btSalvarCliente.Name = "btSalvarCliente";
            this.btSalvarCliente.Size = new System.Drawing.Size(75, 23);
            this.btSalvarCliente.TabIndex = 13;
            this.btSalvarCliente.Text = "Salvar";
            this.btSalvarCliente.UseVisualStyleBackColor = true;
            this.btSalvarCliente.Click += new System.EventHandler(this.btSalvarCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnCodigoVeiculo,
            this.ColumnVeiculo,
            this.ColumnCodigoCliente,
            this.ColumnCliente,
            this.ColumnDataMovto,
            this.ColumnOperacao,
            this.ColumnPlaca});
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(647, 275);
            this.dataGridView1.TabIndex = 16;
            // 
            // comboBoxVeiculo
            // 
            this.comboBoxVeiculo.FormattingEnabled = true;
            this.comboBoxVeiculo.Location = new System.Drawing.Point(122, 12);
            this.comboBoxVeiculo.Name = "comboBoxVeiculo";
            this.comboBoxVeiculo.Size = new System.Drawing.Size(100, 21);
            this.comboBoxVeiculo.TabIndex = 17;
            // 
            // IDMovimentacao
            // 
            this.IDMovimentacao.AutoSize = true;
            this.IDMovimentacao.Location = new System.Drawing.Point(284, 18);
            this.IDMovimentacao.Name = "IDMovimentacao";
            this.IDMovimentacao.Size = new System.Drawing.Size(0, 13);
            this.IDMovimentacao.TabIndex = 18;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(122, 42);
            this.textBoxPlaca.Mask = "LLL-9999";
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlaca.TabIndex = 19;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(22, 97);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(75, 13);
            this.labelData.TabIndex = 21;
            this.labelData.Text = "Data Locação";
            // 
            // textBoxDataLocacao
            // 
            this.textBoxDataLocacao.Enabled = false;
            this.textBoxDataLocacao.Location = new System.Drawing.Point(123, 94);
            this.textBoxDataLocacao.Mask = "00/00/0000 90:00";
            this.textBoxDataLocacao.Name = "textBoxDataLocacao";
            this.textBoxDataLocacao.Size = new System.Drawing.Size(100, 20);
            this.textBoxDataLocacao.TabIndex = 22;
            this.textBoxDataLocacao.ValidatingType = typeof(System.DateTime);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.Visible = false;
            // 
            // ColumnCodigoVeiculo
            // 
            this.ColumnCodigoVeiculo.HeaderText = "CodigoVeiculo";
            this.ColumnCodigoVeiculo.Name = "ColumnCodigoVeiculo";
            this.ColumnCodigoVeiculo.Visible = false;
            // 
            // ColumnVeiculo
            // 
            this.ColumnVeiculo.HeaderText = "Modelo";
            this.ColumnVeiculo.Name = "ColumnVeiculo";
            // 
            // ColumnCodigoCliente
            // 
            this.ColumnCodigoCliente.HeaderText = "Cliente";
            this.ColumnCodigoCliente.Name = "ColumnCodigoCliente";
            // 
            // ColumnCliente
            // 
            this.ColumnCliente.FillWeight = 200F;
            this.ColumnCliente.HeaderText = "Nome";
            this.ColumnCliente.Name = "ColumnCliente";
            this.ColumnCliente.Width = 200;
            // 
            // ColumnDataMovto
            // 
            this.ColumnDataMovto.FillWeight = 140F;
            this.ColumnDataMovto.HeaderText = "Data Locação";
            this.ColumnDataMovto.Name = "ColumnDataMovto";
            this.ColumnDataMovto.Width = 140;
            // 
            // ColumnOperacao
            // 
            this.ColumnOperacao.HeaderText = "Operacao";
            this.ColumnOperacao.Name = "ColumnOperacao";
            this.ColumnOperacao.Visible = false;
            // 
            // ColumnPlaca
            // 
            this.ColumnPlaca.HeaderText = "Placa";
            this.ColumnPlaca.Name = "ColumnPlaca";
            // 
            // textBoxClientes
            // 
            this.textBoxClientes.Location = new System.Drawing.Point(122, 68);
            this.textBoxClientes.Mask = "999,999,999-99";
            this.textBoxClientes.Name = "textBoxClientes";
            this.textBoxClientes.Size = new System.Drawing.Size(100, 20);
            this.textBoxClientes.TabIndex = 23;
            // 
            // FormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 432);
            this.Controls.Add(this.textBoxClientes);
            this.Controls.Add(this.textBoxDataLocacao);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.IDMovimentacao);
            this.Controls.Add(this.comboBoxVeiculo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonExcluir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.btSalvarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locações";
            this.Load += new System.EventHandler(this.FormMovimentacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button btSalvarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxVeiculo;
        private System.Windows.Forms.Label IDMovimentacao;
        private System.Windows.Forms.MaskedTextBox textBoxPlaca;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.MaskedTextBox textBoxDataLocacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataMovto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlaca;
        private System.Windows.Forms.MaskedTextBox textBoxClientes;
    }
}