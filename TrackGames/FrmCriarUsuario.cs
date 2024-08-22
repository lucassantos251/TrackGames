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
using MaterialSkin;
using MaterialSkin.Controls;

namespace TrackGames
{
    public partial class FrmCriarUsuario : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";
        FrmLogin frmLogin;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        #endregion

        public FrmCriarUsuario(FrmLogin frmLogin1)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            /*materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );*/

            conexaoSQLServer = new SqlConnection(conexaoSQL);
            frmLogin = frmLogin1;
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

            if(tbLogin.Text == "" || tbLogin.Text == null)
            {
                mensagem += "O campo Login não pode ser vazio\n";
                exibir = true;
            }

            if(tbSenha.Text == "" || tbSenha.Text == null)
            {
                mensagem += "O campo Senha não pode ser vazio\n";
                exibir = true;
            }

            if (tbPlataforma1.Text == "" || tbPlataforma1.Text == null)
            {
                mensagem += "O campo Plataforma 1 não pode ser vazio\n";
                exibir = true;
            }

            if(exibir == true)
            {
                MessageBox.Show(mensagem, "Verificação de Dados",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return exibir;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pbUsuario.Image = null;
            tbLogin.Text = string.Empty;
            tbSenha.Text = string.Empty;
            tbPlataforma1.Text = string.Empty;
            tbPlataforma2.Text = string.Empty;
            tbPlataforma3.Text = string.Empty;
            tbPlataforma4.Text = string.Empty;
            tbPlataforma5.Text = string.Empty;
            this.Hide(); 
            frmLogin.Show();
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
                
                this.sqlCmd.CommandText = "INSERT INTO Usuario (nome_usuario, senha_usuario, foto_usuario, plataforma1_usuario, plataforma2_usuario, plataforma3_usuario, plataforma4_usuario, plataforma5_usuario) VALUES (@nome, @senha, @imagem, @plataforma1, @plataforma2, @plataforma3, @plataforma4, @plataforma5)";

                this.sqlCmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@nome"].Value = (string)tbLogin.Text;

                this.sqlCmd.Parameters.Add("@senha", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@senha"].Value = (string)tbSenha.Text;

                this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                this.sqlCmd.Parameters["@imagem"].Value = this.vetorImagens;

                this.sqlCmd.Parameters.Add("@plataforma1", System.Data.SqlDbType.VarChar);
                this.sqlCmd.Parameters["@plataforma1"].Value = (string)tbPlataforma1.Text;

                if(tbPlataforma2.Text != null)
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
                    MessageBox.Show("Falha ao criar usuário no banco de dados.");
                else
                {
                    MessageBox.Show("Usuário criado com Sucesso", "OK", MessageBoxButtons.OK);
                    this.Hide();
                    frmLogin.Show();
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
    }
}
