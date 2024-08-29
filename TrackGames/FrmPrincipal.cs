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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TrackGames
{
    public partial class FrmPrincipal : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = StringDB.GetDB();

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
            conexaoSQLServer = new SqlConnection(conexaoSQL);
            RecarregarDGV();
            //resgatarDadosTabela(conexaoSQLServer);
            ResgatarDadosUsuario(conexaoSQLServer);
        }

        /*private void resgatarDadosTabela(SqlConnection conexaoSQLServer)
        {
            try
            {
                SqlDataAdapter ADAP = new SqlDataAdapter("SELECT nome_game, media_horas, ano_game, plataforma1_game, plataforma2_game, plataforma3_game, plataforma4_game, plataforma5_game, usuario_jogou, usuario_finalizou, descricao_game FROM Game WHERE fk_usuario=@ID", conexaoSQLServer);
                ADAP.SelectCommand.Parameters.AddWithValue("@ID", idUsuario);
                DataSet DS = new DataSet();
                ADAP.Fill(DS, "Game");
                dgvPrincipal.DataSource = DS.Tables["Game"];

                dgvPrincipal.Columns[0].HeaderText = "Game";
                dgvPrincipal.Columns[1].HeaderText = "Horas";
                dgvPrincipal.Columns[2].HeaderText = "Ano";
                dgvPrincipal.Columns[3].HeaderText = "Plataforma";
                dgvPrincipal.Columns[4].HeaderText = "Plataforma";
                dgvPrincipal.Columns[5].HeaderText = "Plataforma";
                dgvPrincipal.Columns[6].Visible = false;
                dgvPrincipal.Columns[7].Visible = false;
                dgvPrincipal.Columns[8].HeaderText = "Jogou";
                dgvPrincipal.Columns[9].HeaderText = "Finalizou";
                dgvPrincipal.Columns[10].Visible = false;



                dgvPrincipal.Sort(this.dgvPrincipal.Columns[1], ListSortDirection.Ascending);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
        }*/

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

        /*private void dgvPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                mlblNomeValor.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Game"].Value.ToString();
                mlblAnoValor.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Ano"].Value.ToString();
                mlblDuracaoValor.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Horas"].Value.ToString();
                mlblPlataformaValor1.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Plataforma"].Value.ToString();
                mlblPlataformaValor2.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Plataforma"].Value.ToString();
                mlblPlataformaValor3.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Plataforma"].Value.ToString();
                mlblPlataformaValor4.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Plataforma"].Value.ToString();
                mlblPlataformaValor5.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Plataforma"].Value.ToString();
                mlblDescricaoValor.Text = (string)dgvPrincipal.Rows[e.RowIndex].Cells["Descrição"].Value.ToString();

                if (dgvPrincipal.Rows[e.RowIndex].Cells["usuario_jogou"].Value.ToString() == "False")
                    mcbJogou.Checked = false;
                else
                    mcbJogou.Checked = true;

                if (dgvPrincipal.Rows[e.RowIndex].Cells["usuario_finalizou"].Value.ToString() == "False")
                    mcbFinalizou.Checked = false;
                else
                    mcbFinalizou.Checked = true;
            }
            catch
            {
                return;
            }
        }*/

            private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //resgatarDadosTabela(this.conexaoSQLServer);
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
