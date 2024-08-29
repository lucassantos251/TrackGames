using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackGames
{
    public partial class FrmEditarUsuario : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = StringDB.GetDB();

        private int idUsuario = 0;
        private int horasUsuario = 0;
        private int usuarioJogou = 0;
        private int usuarioFinalizou = 0;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;

        private FrmUsuario frmUsuario;
        #endregion
        public FrmEditarUsuario(int idUsuario1, FrmUsuario frmUsuario1)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            conexaoSQLServer = new SqlConnection(conexaoSQL);

            idUsuario = idUsuario1;
            frmUsuario = frmUsuario1;
        }

        private void resgatarDadosUsuario()
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Usuario WHERE id_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = (int)idUsuario;
                this.conexaoSQLServer.Open();

                using (SqlDataReader cmdReader = cmdSelect.ExecuteReader())
                {
                    while (cmdReader.Read())
                    {
                        if (cmdReader["nome_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbLogin.Text = cmdReader["nome_usuario"].ToString();
                        }

                        if (cmdReader["senha_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbSenha.UseSystemPasswordChar = true;
                            tbSenha.Text = cmdReader["senha_usuario"].ToString();
                        }

                        if (cmdReader["plataforma1_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbPlataforma1.Text = cmdReader["plataforma1_usuario"].ToString();
                        }

                        if (cmdReader["plataforma2_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbPlataforma2.Text = cmdReader["plataforma2_usuario"].ToString();
                        }
                        else
                        {
                            tbPlataforma2.Text = "";
                        }

                        if (cmdReader["plataforma3_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbPlataforma3.Text = cmdReader["plataforma3_usuario"].ToString();
                        }
                        else
                        {
                            tbPlataforma3.Text = "";
                        }

                        if (cmdReader["plataforma4_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbPlataforma4.Text = cmdReader["plataforma4_usuario"].ToString();
                        }
                        else
                        {
                            tbPlataforma4.Text = "";
                        }

                        if (cmdReader["plataforma5_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            tbPlataforma5.Text = cmdReader["plataforma5_usuario"].ToString();
                        }
                        else
                        {
                            tbPlataforma5.Text = "";
                        }

                        if (cmdReader["foto_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            vetorImagens = (byte[])cmdReader["foto_usuario"];
                            string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                            FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                            fs.Write(vetorImagens, 0, vetorImagens.Length);
                            fs.Flush();
                            fs.Close();

                            pbUsuario.Image = Image.FromFile(strNomeArquivo);
                        }
                        else
                        {
                            pbUsuario.Image = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
        }
        private void carregarImagem()
        {
            try
            {
                this.fdImagem.ShowDialog(this);
                string strFn = this.fdImagem.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.pbUsuario.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool verificarCampos()
        {
            string mensagem = "";
            bool exibir = false;

            if (tbLogin.Text == "" || tbLogin.Text == null)
            {
                mensagem += "O campo Login não pode ser vazio\n";
                exibir = true;
            }

            if (tbSenha.Text == "" || tbSenha.Text == null)
            {
                mensagem += "O campo Senha não pode ser vazio\n";
                exibir = true;
            }

            if (tbPlataforma1.Text == "" || tbPlataforma1.Text == null)
            {
                mensagem += "O campo Plataforma 1 não pode ser vazio\n";
                exibir = true;
            }

            if (exibir == true)
            {
                MessageBox.Show(mensagem, "Verificação de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exibir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuario.Show();
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pbUsuario.Image = null;
            tbLogin.Text = string.Empty;
            tbSenha.Text = string.Empty;
            tbPlataforma1.Text = string.Empty;
            tbPlataforma2.Text = string.Empty;
            tbPlataforma3.Text = string.Empty;
            tbPlataforma4.Text = string.Empty;
            tbPlataforma5.Text = string.Empty;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool erro = verificarCampos();

            if (erro)
                return;

            try
            {
                this.conexaoSQLServer.Open();
                this.sqlCmd = new SqlCommand();
                sqlCmd.Connection = conexaoSQLServer;

                this.sqlCmd.CommandText = "UPDATE Usuario SET nome_usuario=@nome, senha_usuario=@senha, foto_usuario=@imagem, plataforma1_usuario=@plataforma1, plataforma2_usuario=@plataforma2, plataforma3_usuario=@plataforma3, plataforma4_usuario=@plataforma4, plataforma5_usuario=@plataforma5 WHERE id_usuario=@ID";

                this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                this.sqlCmd.Parameters["@ID"].Value = (int)idUsuario;

                this.sqlCmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@nome"].Value = (string)tbLogin.Text;

                this.sqlCmd.Parameters.Add("@senha", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@senha"].Value = (string)tbSenha.Text;

                if(vetorImagens != null)
                {
                    this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.sqlCmd.Parameters["@imagem"].Value = this.vetorImagens;
                }
                else
                {
                    this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.sqlCmd.Parameters["@imagem"].Value = (System.DBNull)DBNull.Value;
                }
                

                this.sqlCmd.Parameters.Add("@plataforma1", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@plataforma1"].Value = (string)tbPlataforma1.Text;

                if (tbPlataforma2.Text != null)
                {
                    this.sqlCmd.Parameters.Add("@plataforma2", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma2"].Value = (string)tbPlataforma2.Text;
                }
                else
                {
                    this.sqlCmd.Parameters.Add("@plataforma2", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma2"].Value = (string)"";
                }

                if (tbPlataforma3 != null)
                {
                    this.sqlCmd.Parameters.Add("@plataforma3", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma3"].Value = (string)tbPlataforma3.Text;
                }
                else
                {
                    this.sqlCmd.Parameters.Add("@plataforma3", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma3"].Value = (string)"";
                }

                if (tbPlataforma4 != null)
                {
                    this.sqlCmd.Parameters.Add("@plataforma4", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma4"].Value = (string)tbPlataforma4.Text;
                }
                else
                {
                    this.sqlCmd.Parameters.Add("@plataforma4", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma4"].Value = (string)"";
                }

                if (tbPlataforma5 != null)
                {
                    this.sqlCmd.Parameters.Add("@plataforma5", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma5"].Value = (string)tbPlataforma5.Text;
                }
                else
                {
                    this.sqlCmd.Parameters.Add("@plataforma5", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma5"].Value = (string)"";
                }

                int iresultado = this.sqlCmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao editar usuário no banco de dados.");
                else
                {
                    MessageBox.Show("Informações editadas com sucesso.", "OK", MessageBoxButtons.OK);
                    this.Hide();
                    frmUsuario.Show();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (tbSenha.UseSystemPasswordChar == true)
                tbSenha.UseSystemPasswordChar = false;
            else
                tbSenha.UseSystemPasswordChar = true;
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            carregarImagem();
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            resgatarDadosUsuario();
        }
    }
}
