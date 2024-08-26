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
    public partial class FrmPrincipal : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";

        private int idUsuario = 0;
        #endregion

        public FrmPrincipal(int usuario)
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

            //identificação do usuário
            idUsuario = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gameTrackerDataSet.Game'. Você pode movê-la ou removê-la conforme necessário.
            RecarregarDGV();

            conexaoSQLServer = new SqlConnection(conexaoSQL);
            ResgatarDadosUsuario(conexaoSQLServer);
        }

        private void ResgatarDadosUsuario(SqlConnection conexaoSQLServer)
        {
            try
            {
                SqlCommand cmdSelect = new SqlCommand("SELECT foto_usuario, nome_usuario FROM Usuario WHERE id_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int);
                cmdSelect.Parameters["@ID"].Value = idUsuario;

                this.conexaoSQLServer.Open();

                byte[] vetorImagem;

                using (SqlDataReader cmdReader = cmdSelect.ExecuteReader())
                {
                    while (cmdReader.Read())
                    {
                        if (cmdReader["foto_usuario"].GetType().ToString()  != "System.DBNull")
                        {
                            vetorImagem = (byte[])cmdReader["foto_usuario"];

                            //carregar imagem
                            string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                            FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                            fs.Write(vetorImagem, 0, vetorImagem.Length);
                            fs.Flush();
                            fs.Close();
                            pbUsuario.Image = Image.FromFile(strNomeArquivo);
                        }

                        if (cmdReader["nome_usuario"].GetType().ToString() != "System.DBNull")
                        {
                            lblUsuario.Text = (string)cmdReader["nome_usuario"];
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

        private void RecarregarDGV()
        {
            this.gameTableAdapter.FillByID(this.gameTrackerDataSet.Game, this.idUsuario);
            dgvPrincipal.Sort(this.dgvPrincipal.Columns[1], ListSortDirection.Ascending);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RecarregarDGV();
            ResgatarDadosUsuario(this.conexaoSQLServer);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario frmUsuario = new FrmUsuario(idUsuario);
            frmUsuario.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmEditar frmEditar = new FrmEditar(idUsuario, this);
            frmEditar.Show();
        }
    }
}
