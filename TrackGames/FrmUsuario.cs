using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TrackGames
{
    public partial class FrmUsuario : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";

        private int idUsuario = 0;
        private int horasUsuario = 0;
        private int usuarioJogou = 0;
        private int usuarioFinalizou = 0;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        #endregion
        public FrmUsuario(int usuario)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            conexaoSQLServer = new SqlConnection(conexaoSQL);
            idUsuario = usuario;
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            resgatarDadosUsuario();
            resgatarImagemUsuario();
            atualizarDadosUsuario();
        }

        private void resgatarDadosUsuario()
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT * FROM Usuario WHERE id_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = idUsuario;
                this.conexaoSQLServer.Open();

                mlblIDValor.Text = idUsuario.ToString();

                using (SqlDataReader cmdReader = cmdSelect.ExecuteReader())
                {
                    while (cmdReader.Read())
                    {
                        if (cmdReader["nome_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblUsuarioValor.Text = cmdReader["nome_usuario"].ToString();
                        }

                        if (cmdReader["qtd_jogados"].GetType().ToString() != "System.DBNull")
                        {
                            mlblJogosValor.Text = cmdReader["qtd_jogados"].ToString();
                        }
                        else
                        {
                            mlblJogosValor.Text = "";
                        }

                        if (cmdReader["qtd_finalizados"].GetType().ToString() != "System.DBNull")
                        {
                            mlblFinalizadosValor.Text = cmdReader["qtd_finalizados"].ToString();
                        }
                        else
                        {
                            mlblFinalizadosValor.Text = "";
                        }

                        if (cmdReader["horas_estimadas"].GetType().ToString() != "System.DBNull")
                        {
                            mlblHorasValor.Text = cmdReader["horas_estimadas"].ToString();
                        }
                        else
                        {
                            mlblHorasValor.Text = "";
                        }                        

                        if (cmdReader["plataforma1_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblPlataforma1.Text = cmdReader["plataforma1_usuario"].ToString();
                        }

                        if (cmdReader["plataforma2_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblPlataforma2.Text = cmdReader["plataforma2_usuario"].ToString();
                        }
                        else
                        {
                            mlblPlataforma2.Text = "";
                        }

                        if (cmdReader["plataforma3_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblPlataforma3.Text = cmdReader["plataforma3_usuario"].ToString();
                        }
                        else
                        {
                            mlblPlataforma3.Text = "";
                        }

                        if (cmdReader["plataforma4_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblPlataforma4.Text = cmdReader["plataforma4_usuario"].ToString();
                        }
                        else
                        {
                            mlblPlataforma4.Text = "";
                        }

                        if (cmdReader["plataforma5_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            mlblPlataforma5.Text = cmdReader["plataforma5_usuario"].ToString();
                        }
                        else
                        {
                            mlblPlataforma5.Text = "";
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

        private void resgatarImagemUsuario()
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT foto_usuario FROM Usuario WHERE id_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = idUsuario;

                this.conexaoSQLServer.Open();
                byte[] vetorImagem;
                if (cmdSelect.ExecuteScalar().GetType().ToString() != "System.DBNull")
                {
                    vetorImagem = (byte[])cmdSelect.ExecuteScalar();
                }
                else
                {
                    return;
                }

                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

                pbUsuario.Image = Image.FromFile(strNomeArquivo);
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

        /*private void alterarImagemUsuario()
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

            try
            {
                this.conexaoSQLServer.Open();
                this.sqlCmd = new SqlCommand();
                sqlCmd.Connection = conexaoSQLServer;
                if (sqlCmd.Parameters.Count == 0)
                {
                    this.sqlCmd.CommandText = "UPDATE Usuario SET foto_usuario=@imagem WHERE id_usuario=@ID";
                    this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                    this.sqlCmd.Parameters["@ID"].Value = idUsuario;
                }
                this.sqlCmd.Parameters["@imagem"].Value = this.vetorImagens;

                int iresultado = this.sqlCmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao alterar imagem no banco de dados.");
                else
                    MessageBox.Show("Imagem alterada com sucesso.", "OK", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }

            resgatarImagemUsuario();
        }*/

        private void atualizarDadosUsuario()
        {

            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT usuario_jogou, usuario_finalizou, media_horas FROM Game WHERE fk_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                cmdSelect.Parameters["@ID"].Value = Convert.ToInt32(idUsuario);
                this.conexaoSQLServer.Open();

                using (SqlDataReader cmdReader = cmdSelect.ExecuteReader())
                {
                    while (cmdReader.Read())
                    {
                        if (cmdReader["usuario_jogou"].GetType().ToString() != "System.DBNull")
                        {
                            if (cmdReader["usuario_jogou"].Equals(true))
                            {
                                usuarioJogou += 1;
                            }
                        }

                        if (cmdReader["usuario_finalizou"].GetType().ToString() != "System.DBNull")
                        {
                            if (cmdReader["usuario_Finalizou"].Equals(true))
                            {
                                usuarioFinalizou += 1;
                                horasUsuario += Convert.ToInt32(cmdReader["media_horas"].ToString());
                            }
                        }
                    }
                    mlblJogosValor.Text = usuarioJogou.ToString();
                    mlblFinalizadosValor.Text = usuarioFinalizou.ToString();
                    mlblHorasValor.Text = horasUsuario.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }

            //atualizando o banco de dados
            try
            {
                this.conexaoSQLServer.Open();
                this.sqlCmd = new SqlCommand();
                sqlCmd.Connection = conexaoSQLServer;
                if (sqlCmd.Parameters.Count == 0)
                {
                    this.sqlCmd.CommandText = "UPDATE Usuario SET qtd_jogados=@jogados, qtd_finalizados=@finalizados, horas_estimadas=@horas WHERE id_usuario=@ID";

                    this.sqlCmd.Parameters.Add("@jogados", System.Data.SqlDbType.Int, 4);
                    this.sqlCmd.Parameters["@jogados"].Value = Convert.ToInt32(usuarioJogou);

                    this.sqlCmd.Parameters.Add("@finalizados", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@finalizados"].Value = Convert.ToInt32(usuarioFinalizou);

                    this.sqlCmd.Parameters.Add("@horas", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@horas"].Value = Convert.ToInt32(horasUsuario);

                    this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                    this.sqlCmd.Parameters["@ID"].Value = Convert.ToInt32(idUsuario);
                }

                int iresultado = this.sqlCmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao atualizar o banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditarUsuario frmEditarUsuario = new FrmEditarUsuario(idUsuario, this);
            frmEditarUsuario.Show();
        }
    }
}
