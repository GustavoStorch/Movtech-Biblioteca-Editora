using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroEditora
{
    public class EditoraDAO
    {
        private SqlConnection Connection { get; }

        public EditoraDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(EditoraModel editora)
        {
            using (SqlCommand command = Connection.CreateCommand())
            { 
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO mvtBibEditora(nomeEditora) VALUES(@nomeEditora)");
                    command.CommandText = sql.ToString();   
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(EditoraModel editora)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE mvtBibEditora SET nomeEditora = @nomeEditora WHERE codEditora = @codEditora");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codEditora", editora.CodEditora);
                    command.Parameters.Add(new SqlParameter("@nomeEditora", editora.NomeEditora));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                } catch(Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(EditoraModel editora, SqlTransaction t = null)
        {
            using(SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM mvtBibEditora WHERE codEditora = @codEditora");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@codEditora", editora.CodEditora));
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(EditoraModel editora)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(*) FROM mvtBibEditora WHERE codEditora = @codEditora");
                command.CommandText= sql.ToString();
                command.Parameters.AddWithValue("@codEditora", editora.CodEditora);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public List<EditoraModel> GetEditoras()
        {
            List<EditoraModel> editoras = new List<EditoraModel> ();
            using (SqlCommand command = Connection.CreateCommand ())
            {
                StringBuilder sql = new StringBuilder ();
                sql.AppendLine("SELECT EDI.codEditora, EDI.nomeEditora FROM mvtBibEditora EDI ORDER BY EDI.codEditora");
                command.CommandText = sql.ToString ();
                using(SqlDataReader dr = command.ExecuteReader ())
                {
                    while (dr.Read ())
                    {
                        editoras.Add(PopulateDr(dr));
                    }
                }
            }
            return editoras;
        }

        private EditoraModel PopulateDr(SqlDataReader dr)
        {
            string codEditora = "";
            string nomeEditora = "";

            if(DBNull.Value != dr["codEditora"])
            {
                codEditora = dr["codEditora"] + "";
            }
            if (DBNull.Value != dr["nomeEditora"])
            {
                nomeEditora = dr["nomeEditora"] + "";
            }
            return new EditoraModel()
            {
                CodEditora = codEditora,
                NomeEditora = nomeEditora
            };
        }
    }
}
