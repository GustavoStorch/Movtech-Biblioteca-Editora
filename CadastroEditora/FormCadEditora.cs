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
    public partial class FormCadEditora : Form
    {
        public FormCadEditora()
        {
            InitializeComponent();
        }

        private void FormCadEditora_Load(object sender, EventArgs e)
        {
            InitializeTable();
            CarregaID();
            btnExcluir.Enabled = false;
        }

        //Botão com a funcionalidade de salvar/persistir os dados inseridos no banco de dados.
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                { 
                    EditoraDAO dao = new EditoraDAO(connection);

                    bool verificaCampos = dao.VerificaCampos(new EditoraModel()
                    {
                        CodEditora = txtCodEditora.Text,
                        NomeEditora = txtNomeEditora.Text
                    });

                    if (verificaCampos)
                    {

                        int count = dao.VerificaRegistros(new EditoraModel()
                        {
                            CodEditora = txtCodEditora.Text
                        });

                        if (count > 0)
                        {
                            dao.Editar(new EditoraModel()
                            {
                                CodEditora = txtCodEditora.Text,
                                NomeEditora = txtNomeEditora.Text
                            });
                            MessageBox.Show("Editora atualizada com sucesso!");
                        }
                        else
                        {
                            dao.Salvar(new EditoraModel()
                            {
                                CodEditora = txtCodEditora.Text,
                                NomeEditora = txtNomeEditora.Text
                            });
                            MessageBox.Show("Editora salvo com sucesso!");
                        }
                    }
                    
                }
                InitializeTable();
                limparForm();
                CarregaID();
                btnExcluir.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar a editora!\n{ex.Message}");
            }
        }

        //Botão que realiza o Delete de um registro no banco de dados.
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir a editora?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {
                if (conf == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        EditoraDAO dao = new EditoraDAO(connection);

                        bool verificaCampos = dao.VerificaCampos(new EditoraModel()
                        {
                            CodEditora = txtCodEditora.Text,
                            NomeEditora = txtNomeEditora.Text
                        });

                        if (verificaCampos)
                        {
                            dao.Excluir(new EditoraModel()
                            {
                                CodEditora = txtCodEditora.Text
                            });
                            MessageBox.Show("Editora excluída com sucesso!");
                        }
                    }
                    
                    InitializeTable();
                    limparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a editora!\n{ex.Message}");
            }
        }

        //Método que limpa o formulário toda vez que é salvo ou deletado um registro.
        public void limparForm()
        {
            txtCodEditora.Text = String.Empty;
            txtNomeEditora.Text = String.Empty;
        }        

        //Carrega todos os registros contidos no banco de dados para a DataGridView.
        private void InitializeTable()
        {
            dtgDadosEditora.Rows.Clear();
            using(SqlConnection connection = DaoConnection.GetConexao())
            {
                EditoraDAO dao = new EditoraDAO(connection);
                List<EditoraModel> editoras = dao.GetEditoras();
                foreach(EditoraModel editora in editoras)
                {
                    DataGridViewRow row = dtgDadosEditora.Rows[dtgDadosEditora.Rows.Add()];
                    row.Cells[colCodEditora.Index].Value = editora.CodEditora;
                    row.Cells[colNomeEditora.Index].Value = editora.NomeEditora;
                }
            }
        }

        //Recupera o próximo id a ser cadastrado e joga ele para o textBox.
        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('mvtBibEditora') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodEditora.Text = nextCod.ToString();
            }
        }

        //Método que realiza o double click em uma linha da grid e joga todos os seus dados para as textBox.
        private void dtgDadosEditora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodEditora.Text = dtgDadosEditora.Rows[e.RowIndex].Cells[colCodEditora.Index].Value + "";
                txtNomeEditora.Text = dtgDadosEditora.Rows[e.RowIndex].Cells[colNomeEditora.Index].Value + "";

                if (string.IsNullOrEmpty(this.txtNomeEditora.Text))
                {
                    btnExcluir.Enabled = false;
                    CarregaID();
                }
                else
                {
                    btnExcluir.Enabled = true;
                }
            }
        }
    }
}
