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
using MaterialSkin;
using MaterialSkin.Controls;

namespace TrackGames
{
    public partial class FrmLogin : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";

        private int idUsuario = 0;
        #endregion

        public FrmLogin()
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
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login()
        {
            if (tbLogin.Text.Length <= 0 || tbSenha.Text.Length <= 0)
            {
                MessageBox.Show("Login e Senha não podem ser vazios.");
            }
            else
            {
                try
                {
                    SqlCommand CmdSelect = new SqlCommand("SELECT id_usuario, senha_usuario FROM Usuario WHERE nome_usuario=@usuario", this.conexaoSQLServer);
                    CmdSelect.Parameters.Add("@usuario", SqlDbType.VarChar);
                    CmdSelect.Parameters["@usuario"].Value = tbLogin.Text;

                    this.conexaoSQLServer.Open();

                    using (SqlDataReader CmdReader = CmdSelect.ExecuteReader())
                    {
                        while (CmdReader.Read())
                        {
                            //leitura e comparação de usuário e senha
                            if (tbSenha.Text == CmdReader["senha_usuario"].ToString())
                            {
                                if (CmdReader["id_usuario"].GetType().ToString() != "System.DBNull")
                                {
                                    idUsuario = (int)CmdReader["id_usuario"];

                                    //login bem sucedido, abrir nova janela
                                    this.Hide();
                                    FrmPrincipal frmPrincipal = new FrmPrincipal(idUsuario);
                                    frmPrincipal.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Erro ao carregar dados do usuário");
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Senha incorreta.");
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
        }

        private void mbtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void tbSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }
    }
}
