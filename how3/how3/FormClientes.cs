using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace how3
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            textBoxDocumento.Clear();
            textBoxNome.Clear();
            IDCliente.Text = ""; 
        }

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxDocumento.Text == "")
            {
                MessageBox.Show("Documento não preenchido, inclusão cancelada.");
                return;
            }

            if (textBoxNome.Text == "")
            {
                MessageBox.Show("Nome não preenchido, inclusão cancelada.");
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

                if (IDCliente.Text == "")
                {
                    comandoMySql.CommandText = "INSERT INTO clientes (documento_cliente, nome, tipo_pessoa) " +
                    "VALUES('" + textBoxDocumento.Text + "', '" + textBoxNome.Text + "', 0)";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Cliente inserido com sucesso."); //Exibo mensagem de aviso
                }
                else
                {
                    comandoMySql.CommandText = "UPDATE clientes " +
                                                "  SET documento_cliente = '"+ textBoxDocumento.Text +"',"+
                                                                  " nome = '"+ textBoxNome.Text      + "'"+
                                               " WHERE codigo_cliente = " + IDCliente.Text;
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Cliente atualizado com sucesso."); //Exibo mensagem de aviso
                }

                atualizarGridClientes();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGridClientes();
        }

        private void atualizarGridClientes()
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
                comandoMySql.CommandText = "SELECT * FROM CLIENTES";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewClientes.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewClientes.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    dataGridViewClientes.Rows.Add(row);
                }

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (IDCliente.Text == "")
            {
                MessageBox.Show("Selecioe ao menos um registro.");
                return;
            }

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
                
                comandoMySql.CommandText = "DELETE from clientes " +
                                            " WHERE codigo_cliente = " + IDCliente.Text;
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Cliente excluído com sucesso."); //Exibo mensagem de aviso
                
                atualizarGridClientes();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewClientes.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewClientes.CurrentRow.Selected = true;
                textBoxNome.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                textBoxDocumento.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnDocumento"].FormattedValue.ToString();
                IDCliente.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnCodigoCliente"].FormattedValue.ToString();
            }
        }
    }
}
