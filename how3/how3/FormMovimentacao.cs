using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace how3
{
    public partial class FormMovimentacao : Form
    {
        public FormMovimentacao()
        {
            InitializeComponent();
        }

        private void FormMovimentacao_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            IDMovimentacao.Text = "";
            textBoxPlaca.Text = "";
            textBoxClientes.Text = "";
            textBoxDataLocacao.Text = DateTime.Now.ToString();
            CarregaVeiculos();
            AtualizarGridLocacoes();
        }

        private void CarregaVeiculos()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "how3";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "12345678";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = new MySqlCommand("SELECT codigo_veiculo, modelo FROM VEICULOS order by modelo", realizaConexacoBD);
                MySqlDataReader reader = comandoMySql.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                comboBoxVeiculo.DisplayMember = "modelo";
                comboBoxVeiculo.ValueMember = "codigo_veiculo";
                comboBoxVeiculo.Text = "Selecione um veículo";
                comboBoxVeiculo.DataSource = dataTable;

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxPlaca.Text == "")
            {
                MessageBox.Show("A placa não foi preenchida, inclusão cancelada.");
                return;
            }

            if (textBoxClientes.Text == "")
            {
                MessageBox.Show("Cliente não preenchido, inclusão cancelada.");
                return;
            }

            int idCliente = BuscaCliente();
            if (idCliente ==  0)
            {
                MessageBox.Show("Cliente inexistente, inclusão cancelada.");
                return;
            }
            
            //Crio a estrutura da conexão com o banco e passa os parametros
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "how3";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "12345678";
            //Realizo a conexão com o banco
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL

                if (IDMovimentacao.Text == "")
                {
                    comandoMySql.CommandText = "INSERT INTO movimentacoes (codigo_veiculo, " +
                                                                          "codigo_cliente, " +
                                                                          "data_movto, " +
                                                                          "operacao, " +
                                                                          "placa) " +
                                                                  "VALUES(" + comboBoxVeiculo.SelectedValue + ", " +
                                                                             idCliente + ", " +
                                                                             "STR_TO_DATE('"+ textBoxDataLocacao.Text + "', '%d/%m/%Y %H:%i:%s'), " +
                                                                             1 + ", " +
                                                                             "'"+ textBoxPlaca.Text + "')";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Locação inserida com sucesso."); //Exibo mensagem de aviso                    
                }
                else
                {
                    comandoMySql.CommandText = "UPDATE movimentacoes " +
                                                "  SET codigo_veiculo = " + comboBoxVeiculo.SelectedValue + "," +
                                                "      codigo_cliente = " + idCliente + "," +
                                                "          data_movto = STR_TO_DATE('"+ textBoxDataLocacao.Text + "', '%d/%m/%Y %H:%i:%s'), " +
                                                "          placa      =  '" + textBoxPlaca.Text + "'" +
                                               " WHERE codigo_movto = " + IDMovimentacao.Text;
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); 
                    MessageBox.Show("Locação atualizada com sucesso."); //Exibo mensagem de aviso
                }
                
                InicializarFormulario();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private int BuscaCliente()
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "how3";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "12345678";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "   SELECT CODIGO_CLIENTE " +                                                  
                                               " FROM CLIENTES " +
                                              " WHERE documento_cliente = '" + textBoxClientes.Text + "'";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return 0;
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("excluir");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            InicializarFormulario();
        }
        
        private void AtualizarGridLocacoes() 
        {
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "how3";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "12345678";
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                comandoMySql.CommandText = "   SELECT M.CODIGO_MOVTO, " +
                                                  "   M.CODIGO_VEICULO, " +
                                                  "   V.MODELO, " +
                                                  "   C.DOCUMENTO_CLIENTE, " +
                                                  "   C.NOME, " +
                                                  "   M.DATA_MOVTO, " +
                                                  "   M.OPERACAO, " +
                                                  "   M.PLACA " +
                                               " FROM MOVIMENTACOES M " +
                                              " INNER JOIN VEICULOS V ON(M.CODIGO_VEICULO = V.CODIGO_VEICULO) " +
                                              " INNER JOIN CLIENTES C ON(M.CODIGO_CLIENTE = C.CODIGO_CLIENTE)  ";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewMovimentacoes.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewMovimentacoes.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                    row.Cells[6].Value = reader.GetString(6);
                    row.Cells[7].Value = reader.GetString(7);
                    dataGridViewMovimentacoes.Rows.Add(row);
                }

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int lCodigoVeiculo;
            if (dataGridViewMovimentacoes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {

                dataGridViewMovimentacoes.CurrentRow.Selected = true;
                IDMovimentacao.Text = dataGridViewMovimentacoes.Rows[e.RowIndex].Cells["ColumnId"].FormattedValue.ToString();
                textBoxClientes.Text = dataGridViewMovimentacoes.Rows[e.RowIndex].Cells["ColumnCodigoCliente"].FormattedValue.ToString();
                textBoxDataLocacao.Text = dataGridViewMovimentacoes.Rows[e.RowIndex].Cells["ColumnDataMovto"].FormattedValue.ToString();
                textBoxPlaca.Text = dataGridViewMovimentacoes.Rows[e.RowIndex].Cells["ColumnPlaca"].FormattedValue.ToString();
                lCodigoVeiculo = int.Parse(dataGridViewMovimentacoes.Rows[e.RowIndex].Cells["ColumnCodigoVeiculo"].FormattedValue.ToString());
                comboBoxVeiculo.SelectedValue = lCodigoVeiculo;

//                ColumnVeiculo

                //sColumnCliente

                //ColumnOperacao


            }
        }

        private void dataGridViewMovimentacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
