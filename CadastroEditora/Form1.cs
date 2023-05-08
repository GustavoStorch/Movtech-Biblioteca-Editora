using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroEditora
{
    public partial class Form1 : Form
    {

        private SqlConnection conn;
        private bool btnAtivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table_load();
            CarregaID();          
            btnAtivo = false;
            botaoAtivado();
        }

        //Cria a conexão com o banco de dados.
        private SqlConnection Conexao()
        {
            conn = new SqlConnection(@"Data Source=localhost\sqlexpress;Initial Catalog=Treinamento;Integrated Security=True");
            return conn;
        }

        //Método para ativar ou desativar o botão de excluir do usuário.
        private void botaoAtivado()
        {
            if (btnAtivo)
            {
                btnExcluir.Enabled = true;
            }
            else
            {
                btnExcluir.Enabled = false;
            }
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            conn = Conexao();
            conn.Open();

            SqlCommand cm = new SqlCommand("SELECT IDENT_CURRENT('mvtBibEditora') + 1", conn);
            int nextCod = Convert.ToInt32(cm.ExecuteScalar());

            txtCodEditora.Text = nextCod.ToString();
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            conn = Conexao();
            String sql;

            try
            {
                //Verifica se o campo do código está vazio e realiza o insert.
                if (string.IsNullOrEmpty(this.txtCodEditora.Text))
                {
                    sql = "INSERT INTO mvtBibEditora(nomeEditora) VALUES(@nomeEditora)";
                    SqlCommand c = new SqlCommand(sql, conn);

                    if (String.IsNullOrWhiteSpace(txtNomeEditora.Text))
                    {
                        MessageBox.Show("Erro: Preencha o nome da Editora!");
                    }
                    else
                    {
                        c.Parameters.Add(new SqlParameter("@nomeEditora", this.txtNomeEditora.Text));
                    }

                    conn.Open();
                    c.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Enviado com sucesso!");

                    limparForm();
                    table_load();
                    CarregaID();
                }
                else
                {
                    //Verifica se o código presente no textbox já está registrado dentro do banco de dados.
                    conn.Open();
                    string sql2 = "SELECT COUNT(*) FROM mvtBibEditora WHERE codEditora = @codEditora";
                    SqlCommand cmdSelect = new SqlCommand(sql2, conn);
                    cmdSelect.Parameters.AddWithValue("@codEditora", txtCodEditora.Text);
                    int count = Convert.ToInt32(cmdSelect.ExecuteScalar());
                    conn.Close();

                    //Se o código estiver registrado no banco de dados realiza apenas o update.
                    if (count > 0) {
                        sql = "UPDATE mvtBibEditora SET nomeEditora = @nomeEditora WHERE codEditora = @codEditora";
                        SqlCommand c = new SqlCommand(sql, conn);

                        c.Parameters.AddWithValue("@codEditora", txtCodEditora.Text);

                        if (String.IsNullOrWhiteSpace(txtNomeEditora.Text))
                        {
                            MessageBox.Show("Erro: Preencha o nome da Editora!");
                        }
                        else
                        {
                            c.Parameters.Add(new SqlParameter("@nomeEditora", this.txtNomeEditora.Text));
                        }
                        conn.Open();

                        c.ExecuteNonQuery();

                        conn.Close();

                        MessageBox.Show("Atualizado com sucesso!");

                        limparForm();
                        table_load();
                        CarregaID();
                        btnAtivo = false;
                        botaoAtivado();
                    } else
                    {
                        //Se não estiver registrado no banco de dados realiza o insert.
                        sql = "INSERT INTO mvtBibEditora(nomeEditora) VALUES(@nomeEditora)";
                        SqlCommand c = new SqlCommand(sql, conn);

                        if (String.IsNullOrWhiteSpace(txtNomeEditora.Text))
                        {
                            MessageBox.Show("Erro: Preencha o nome da Editora!");
                        }
                        else
                        {
                            c.Parameters.Add(new SqlParameter("@nomeEditora", this.txtNomeEditora.Text));
                        }

                        conn.Open();
                        c.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Enviado com sucesso!");

                        limparForm();
                        table_load();
                        CarregaID();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conn = Conexao();
            String sql = "DELETE mvtBibEditora WHERE codEditora = @codEditora";

            try
            {
                SqlCommand c = new SqlCommand(sql, conn);

                c.Parameters.AddWithValue("@codEditora", txtCodEditora.Text);

                conn.Open();
                c.ExecuteNonQuery();

                limparForm();
                table_load();
                CarregaID();
                //btnAtivo = false;
                botaoAtivado();

                MessageBox.Show("Excluído com sucesso!");

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodEditora.Text = String.Empty;
            txtNomeEditora.Text = String.Empty;
        }

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void table_load()
        {
            conn = Conexao();
            String sql = "SELECT codEditora AS Código, nomeEditora AS Nome FROM mvtBibEditora ORDER BY Código";

            try
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                conn.Open();
                da.Fill(ds);
                gridCadEditora.DataSource = ds.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu o erro: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        //Método que realiza o double click em uma linha da grid e joga todos os seus dados para as textBox.
        private void gridCadEditora_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gridCadEditora.SelectedRows.Count > 0)
            {
                txtCodEditora.Text = gridCadEditora.SelectedRows[0].Cells[0].Value.ToString();
                txtNomeEditora.Text = gridCadEditora.SelectedRows[0].Cells[1].Value.ToString();               

                if (string.IsNullOrEmpty(this.txtNomeEditora.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                } else
                {
                    btnExcluir.Enabled = true;
                }

            }
        }

        //Método que faz com que apenas seja digitado números no campo do código.
        public static void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCodEditora_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntNumber(e);
        }

        private void txtCodEditora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
