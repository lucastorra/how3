using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormVeiculo : Form
    {
        public FormVeiculo()
        {
            InitializeComponent();
        }

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            limparCampos();
            atualizarGridVeiculos();
            comboBoxVeiculo.SelectedIndex = 0;
        }

        private void limparCampos()
        {
            textBoxModelo.Clear();
            IDVeiculo.Text = "";
        }

        private void atualizarGridVeiculos()
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
                comandoMySql.CommandText = "SELECT codigo_veiculo, marca, " +
                    " CASE marca WHEN 0 THEN 'FIAT' WHEN 1 THEN 'CHEVROLET' WHEN 2 THEN 'VOLKSWAGN' WHEN 3 THEN 'JEEP' END, " +
                    "                              modelo " +
                    "FROM VEICULOS";
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewVeiculos.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewVeiculos.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);

                    dataGridViewVeiculos.Rows.Add(row);
                }

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
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

        private void btSalvarCliente_Click(object sender, EventArgs e)
        {
            if (textBoxModelo.Text == "")
            {
                MessageBox.Show("Modelo não preenchido, inclusão cancelada.");
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

                if (IDVeiculo.Text == "")
                {
                    comandoMySql.CommandText = "INSERT INTO veiculos (marca, modelo) " +
                    "VALUES(" + comboBoxVeiculo.SelectedIndex + ", '" + textBoxModelo.Text + "')";
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Veículo inserido com sucesso."); //Exibo mensagem de aviso
                }
                else
                {
                    comandoMySql.CommandText = "UPDATE veiculos " +
                                                "  SET marca = " + comboBoxVeiculo.SelectedIndex + "," +
                                                     " modelo = '" + textBoxModelo.Text + "'" +
                                               " WHERE codigo_veiculo = " + IDVeiculo.Text;
                    comandoMySql.ExecuteNonQuery();

                    realizaConexacoBD.Close(); // Fecho a conexão com o banco
                    MessageBox.Show("Veículo atualizado com sucesso."); //Exibo mensagem de aviso
                }

                atualizarGridVeiculos();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (IDVeiculo.Text == "")
            {
                MessageBox.Show("Seleciona ao menos um registro.");
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

                comandoMySql.CommandText = "DELETE from veiculos " +
                                           " WHERE codigo_veiculo = " + IDVeiculo.Text;
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Cliente excluído com sucesso."); //Exibo mensagem de aviso

                atualizarGridVeiculos();
                limparCampos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void selecionaVeiculo(DataGridViewCellEventArgs e)
        {
            if (dataGridViewVeiculos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewVeiculos.CurrentRow.Selected = true;
                textBoxModelo.Text = dataGridViewVeiculos.Rows[e.RowIndex].Cells["ColumnModelo"].FormattedValue.ToString();
                comboBoxVeiculo.SelectedIndex = int.Parse(dataGridViewVeiculos.Rows[e.RowIndex].Cells["ColumnMarca"].FormattedValue.ToString());
                IDVeiculo.Text = dataGridViewVeiculos.Rows[e.RowIndex].Cells["ColumnCodigoCliente"].FormattedValue.ToString();
            }
        }

        private void dataGridViewVeiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionaVeiculo(e);
        }

        private void dataGridViewVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selecionaVeiculo(e);
        }
    }
}
