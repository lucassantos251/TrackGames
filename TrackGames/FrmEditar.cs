
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace TrackGames
{
    public partial class FrmEditar : MaterialForm
    {
        #region Variaveis
        private SqlConnection conexaoSQLServer;
        SqlCommand sqlCmd = default(SqlCommand);
        private string conexaoSQL = @"Data Source=CELESTIA\SQLEXPRESS;Initial Catalog = GameTracker; Integrated Security = True;";

        private int idUsuario = 0;
        private FrmPrincipal frmPrincipal;

        private long tamanhoArquivoImagem = 0;
        private byte[] vetorImagens;
        #endregion
        public FrmEditar(int usuario, FrmPrincipal frmPrincipal1)
        {
            InitializeComponent();

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            idUsuario = usuario;
            frmPrincipal = frmPrincipal1;
            tbIDUsuario.Text = idUsuario.ToString();
        }

        private void FrmEditar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'gameTrackerDataSet.Game'. Você pode movê-la ou removê-la conforme necessário.
            //this.gameTableAdapter.Fill(this.gameTrackerDataSet.Game);
            conexaoSQLServer = new SqlConnection(conexaoSQL);
            resgatarDadosTabela(conexaoSQLServer);
        }

        private void resgatarDadosTabela(SqlConnection conexaoSQLServer)
        {
            try
            {
                SqlDataAdapter ADAP = new SqlDataAdapter("SELECT * FROM Game WHERE fk_usuario=@ID", conexaoSQLServer);
                ADAP.SelectCommand.Parameters.AddWithValue("@ID", idUsuario);
                DataSet DS = new DataSet();
                ADAP.Fill(DS, "Game");
                dgvEditar.DataSource = DS.Tables["Game"];
                dgvEditar.Sort(this.dgvEditar.Columns[1], ListSortDirection.Ascending);
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

        private void dgvEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbID.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["id_game"].Value.ToString();
                tbJogo.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["nome_game"].Value.ToString();
                tbAno.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["ano_game"].Value.ToString();
                tbHoras.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["media_horas"].Value.ToString();
                tbPlataforma1.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["plataforma1_game"].Value.ToString();
                tbPlataforma2.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["plataforma2_game"].Value.ToString();
                tbPlataforma3.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["plataforma3_game"].Value.ToString();
                tbPlataforma4.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["plataforma4_game"].Value.ToString();
                tbPlataforma5.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["plataforma5_game"].Value.ToString();
                tbDescricao.Text = (string)dgvEditar.Rows[e.RowIndex].Cells["descricao_game"].Value.ToString();

                if (dgvEditar.Rows[e.RowIndex].Cells["usuario_jogou"].Value.ToString() == "False")
                    mcbJogou.Checked = false;
                else
                    mcbJogou.Checked = true;

                if (dgvEditar.Rows[e.RowIndex].Cells["usuario_finalizou"].Value.ToString() == "False")
                    mcbFinalizou.Checked = false;
                else
                    mcbFinalizou.Checked = true;
            }
            catch
            {
                return;
            }

            resgatarNomeUsuario();
            resgatarImagemJogo();
        }

        private void resgatarNomeUsuario()
        {
            try
            {
                if (tbIDUsuario.Text == null)
                {
                    return;
                }

                if (tbIDUsuario.Text == "")
                {
                    return;
                }

                SqlCommand cmdSelect = new SqlCommand("SELECT nome_usuario FROM Usuario WHERE id_usuario=@ID", this.conexaoSQLServer);
                cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);                
                cmdSelect.Parameters["@ID"].Value = Convert.ToInt32(tbIDUsuario.Text);
                this.conexaoSQLServer.Open();

                if (cmdSelect.ExecuteScalar().GetType().ToString() != "System.DBNull")
                {
                    tbUsuarioNome.Text = (string)cmdSelect.ExecuteScalar();
                }
                else
                {
                    return;
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
        }

        private void resgatarImagemJogo()
        {
            try
            {
                if (tbID.Text == null)
                {
                    pbJogo.Image = null;
                    return;
                }

                if (tbID.Text == "")
                {
                    pbJogo.Image = null;
                    return;
                }
                SqlCommand cmdSelect = new SqlCommand("SELECT capa_game FROM Game WHERE id_game=@ID", this.conexaoSQLServer);
                    cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
                    cmdSelect.Parameters["@ID"].Value = Convert.ToInt32(tbID.Text);
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

                    pbJogo.Image = Image.FromFile(strNomeArquivo);
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

        private void alterarImagemJogo()
        {
            try
            {
                this.fdImagem.ShowDialog(this);
                string strFn = this.fdImagem.FileName;

                if (string.IsNullOrEmpty(strFn))
                {
                    return;
                }                    

                this.pbJogo.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
                strFn = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateImagemJogo(int escolha)
        {
            if(escolha == 1)
            {
                try
                {
                    /*this.conexaoSQLServer.Open();
                    this.sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conexaoSQLServer;*/
                    this.sqlCmd.CommandText = "UPDATE Game SET capa_game=@imagem WHERE id_game=@ID";

                    this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.sqlCmd.Parameters["@imagem"].Value = this.vetorImagens;

                    int iresultado = Convert.ToInt32(this.sqlCmd.ExecuteNonQuery());

                    if (iresultado <= 0)
                        MessageBox.Show("Falha ao alterar imagem no banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (escolha == 2)
            {
                try
                {
                    /*this.conexaoSQLServer.Open();
                    this.sqlCmd = new SqlCommand();
                    sqlCmd.Connection = conexaoSQLServer;*/
                    this.sqlCmd.CommandText = "UPDATE Game SET capa_game=@imagem WHERE nome_game=@nome AND ano_game=@ano AND fk_usuario=@usuario";

                    this.sqlCmd.Parameters.Add("@imagem", System.Data.SqlDbType.Image);
                    this.sqlCmd.Parameters["@imagem"].Value = this.vetorImagens;

                    int iresultado = Convert.ToInt32(this.sqlCmd.ExecuteNonQuery());

                    if (iresultado <= 0)
                        MessageBox.Show("Falha ao alterar imagem no banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void atualizarJogo()
        {
            bool erro = verificacaoDeCampos(1);

            if (erro == true)
                return;

            try
            {
                this.conexaoSQLServer.Open();
                this.sqlCmd = new SqlCommand();
                sqlCmd.Connection = conexaoSQLServer;
                if (sqlCmd.Parameters.Count == 0)
                {
                    this.sqlCmd.CommandText = "UPDATE Game SET nome_game=@nome, ano_game=@ano, media_horas=@horas, plataforma1_game=@plataforma1, plataforma2_game=@plataforma2, plataforma3_game=@plataforma3, plataforma4_game=@plataforma4, plataforma5_game=@plataforma5, descricao_game=@descricao, fk_usuario=@usuario, usuario_jogou=@jogou, usuario_finalizou=@finalizou WHERE id_game=@ID";
                    
                    this.sqlCmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@nome"].Value = (string)tbJogo.Text;

                    this.sqlCmd.Parameters.Add("@ano", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@ano"].Value = Convert.ToInt32(tbAno.Text);

                    this.sqlCmd.Parameters.Add("@horas", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@horas"].Value = Convert.ToInt32(tbHoras.Text);

                    this.sqlCmd.Parameters.Add("@plataforma1", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma1"].Value = (string)tbPlataforma1.Text;

                    this.sqlCmd.Parameters.Add("@plataforma2", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma2"].Value = (string)tbPlataforma2.Text;

                    this.sqlCmd.Parameters.Add("@plataforma3", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma3"].Value = (string)tbPlataforma3.Text;

                    this.sqlCmd.Parameters.Add("@plataforma4", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma4"].Value = (string)tbPlataforma4.Text;

                    this.sqlCmd.Parameters.Add("@plataforma5", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma5"].Value = (string)tbPlataforma5.Text;

                    this.sqlCmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@descricao"].Value = (string)tbDescricao.Text;

                    this.sqlCmd.Parameters.Add("@usuario", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@usuario"].Value = Convert.ToInt32(tbIDUsuario.Text);

                    this.sqlCmd.Parameters.Add("@jogou", System.Data.SqlDbType.Bit);
                    this.sqlCmd.Parameters["@jogou"].Value = (bool)mcbJogou.Checked;

                    this.sqlCmd.Parameters.Add("@finalizou", System.Data.SqlDbType.Bit);
                    this.sqlCmd.Parameters["@finalizou"].Value = (bool)mcbFinalizou.Checked;
                    
                    this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                    this.sqlCmd.Parameters["@ID"].Value = Convert.ToInt32(tbID.Text);
                }

                if(vetorImagens != null)
                {
                    updateImagemJogo(1);
                }

                int iresultado = this.sqlCmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao alterar informações no banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Informações alteradas com sucesso.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.conexaoSQLServer.Close();
            }
            resgatarDadosTabela(conexaoSQLServer);
        }

        private void inserirJogo()
        {
            bool erro = verificacaoDeCampos(2);

            if (erro == true)
                return;

            try
            {
                this.conexaoSQLServer.Open();
                this.sqlCmd = new SqlCommand();
                sqlCmd.Connection = conexaoSQLServer;
                if (sqlCmd.Parameters.Count == 0)
                {
                    this.sqlCmd.CommandText = "INSERT INTO Game (nome_game, ano_game, media_horas, plataforma1_game, plataforma2_game, plataforma3_game, plataforma4_game, plataforma5_game, descricao_game, fk_usuario, usuario_jogou, usuario_finalizou) VALUES (@nome, @ano, @horas, @plataforma1, @plataforma2, @plataforma3, @plataforma4, @plataforma5, @descricao, @usuario, @jogou, @finalizou)";

                    this.sqlCmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@nome"].Value = (string)tbJogo.Text;

                    this.sqlCmd.Parameters.Add("@ano", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@ano"].Value = Convert.ToInt32(tbAno.Text);

                    this.sqlCmd.Parameters.Add("@horas", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@horas"].Value = Convert.ToInt32(tbHoras.Text);

                    this.sqlCmd.Parameters.Add("@plataforma1", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma1"].Value = (string)tbPlataforma1.Text;

                    this.sqlCmd.Parameters.Add("@plataforma2", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma2"].Value = (string)tbPlataforma2.Text;

                    this.sqlCmd.Parameters.Add("@plataforma3", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma3"].Value = (string)tbPlataforma3.Text;

                    this.sqlCmd.Parameters.Add("@plataforma4", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma4"].Value = (string)tbPlataforma4.Text;

                    this.sqlCmd.Parameters.Add("@plataforma5", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@plataforma5"].Value = (string)tbPlataforma5.Text;

                    this.sqlCmd.Parameters.Add("@descricao", System.Data.SqlDbType.VarChar);
                    this.sqlCmd.Parameters["@descricao"].Value = (string)tbDescricao.Text;

                    this.sqlCmd.Parameters.Add("@usuario", System.Data.SqlDbType.Int);
                    this.sqlCmd.Parameters["@usuario"].Value = Convert.ToInt32(tbIDUsuario.Text);

                    this.sqlCmd.Parameters.Add("@jogou", System.Data.SqlDbType.Bit);
                    this.sqlCmd.Parameters["@jogou"].Value = (bool)mcbJogou.Checked;

                    this.sqlCmd.Parameters.Add("@finalizou", System.Data.SqlDbType.Bit);
                    this.sqlCmd.Parameters["@finalizou"].Value = (bool)mcbFinalizou.Checked;
                    
                    //this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                    //this.sqlCmd.Parameters["@ID"].Value = Convert.ToInt32(tbID.Text);
                }

                int iresultado = this.sqlCmd.ExecuteNonQuery();

                if (iresultado <= 0)
                    MessageBox.Show("Falha ao alterar informações no banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Informações inseridas com sucesso.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (vetorImagens != null)
                {
                    updateImagemJogo(2);
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
            resgatarDadosTabela(conexaoSQLServer);
        }

        private bool verificacaoDeCampos(int escolha)
        {
            bool exibir = false;
            string mensagem = "";
            int[] valores = new int[4];

            if (escolha == 1)
            {
                try
                {
                    if (tbID.Text == "" || tbID.Text == null)
                    {
                        mensagem += "Insira um valor no campo ID. \n";
                        exibir = true;
                    }                    

                    if (tbJogo.Text == "" || tbJogo.Text == null)
                    {
                        mensagem += "Insira um nome no campo Jogo. \n";
                        exibir = true;
                    }

                    if (tbAno.Text == "" || tbAno.Text == null)
                    {
                        mensagem += "Insira um valor no campo Ano. \n";
                        exibir = true;
                    }
                    

                    if (tbHoras.Text == "" || tbHoras.Text == null)
                    {
                        mensagem += "Insira um valor no campo Horas. \n";
                        exibir = true;
                    }                  

                    if (tbPlataforma1.Text == "" || tbPlataforma1.Text == null)
                    {
                        mensagem += "Insira um nome no campo Plataforma. \n";
                        exibir = true;
                    }

                    if (tbIDUsuario.Text == "" || tbIDUsuario.Text == null)
                    {
                        mensagem += "Insira um valor no campo ID do Usuário. \n";
                        exibir = true;
                    }

                    valores[0] = Convert.ToInt32(tbID.Text);
                    valores[1] = Convert.ToInt32(tbAno.Text);
                    valores[2] = Convert.ToInt32(tbHoras.Text);
                    valores[3] = Convert.ToInt32(tbIDUsuario.Text);

                    if (exibir == true)
                    {
                        MessageBox.Show(mensagem, "Verificação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor insira os valores corretamente.", "Erro na verificação dos valores");
                    exibir = true;
                }
            }
            else if (escolha == 2)
            {
                try
                {

                    if (tbJogo.Text == "" || tbJogo.Text == null)
                    {
                        mensagem += "Insira um nome no campo Jogo. \n";
                        exibir = true;
                    }

                    if (tbAno.Text == "" || tbAno.Text == null)
                    {
                        mensagem += "Insira um valor no campo Ano. \n";
                        exibir = true;
                    }

                    if (tbHoras.Text == "" || tbHoras.Text == null)
                    {
                        mensagem += "Insira um valor no campo Horas. \n";
                        exibir = true;
                    }

                    if (tbPlataforma1.Text == "" || tbPlataforma1.Text == null)
                    {
                        mensagem += "Insira um nome no campo Plataforma. \n";
                        exibir = true;
                    }

                    if (tbIDUsuario.Text == "" || tbIDUsuario.Text == null)
                    {
                        mensagem += "Insira um valor no campo ID do Usuário. \n";
                        exibir = true;
                    }

                    valores[0] = Convert.ToInt32(tbAno.Text);
                    valores[1] = Convert.ToInt32(tbHoras.Text);
                    valores[2] = Convert.ToInt32(tbIDUsuario.Text);

                    if (exibir == true)
                    {
                        MessageBox.Show(mensagem, "Verificação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Por favor insira os valores corretamente.", "Erro na verificação dos valores");
                    exibir = true;
                }
            }

            return exibir;
        }

        private void mbtnLimpar_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbJogo.Text = "";
            tbAno.Text = "";
            tbHoras.Text = "";
            tbPlataforma1.Text = "";
            tbPlataforma2.Text = "";
            tbPlataforma3.Text = "";
            tbPlataforma4.Text = "";
            tbPlataforma5.Text = "";
            tbDescricao.Text = "";
            pbJogo.Image = null;
            mcbJogou.Checked = false;
            mcbFinalizou.Checked = false;
        }

        private void mbtnAlterarImagem_Click(object sender, EventArgs e)
        {
            alterarImagemJogo();
        }

        private void FrmEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPrincipal.Show();
        }

        private void mbtnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seção de Ajuda! \n\n-Adicionar um novo jogo:\n\n1. Clique em uma linha vazia\n2. Preencha os campos 'Jogo', 'Ano', 'Duração', 'Jogou', 'Plataformas', 'Finalizou' e 'Descrição'.\n3. Clique em 'Alterar Imagem' para inserir uma imagem da capa do jogo.\n4. Clique em Adicionar.\n\n-Editar um jogo:\n\n1. Clique no jogo que deseja editar.\n2. Altere os campos desejados\n3. Clique em Editar. \n\nSó é possível editar um por vez.\nUse o botão Limpar para limpar os campos.\nUse o botão Excluir para excluir um jogo.", "Ajuda - Editar", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void mbtnEditar_Click(object sender, EventArgs e)
        {
            atualizarJogo();
        }

        private void mbtnAdicionar_Click(object sender, EventArgs e)
        {
            inserirJogo();
        }

        private void mbtnExcluir_Click(object sender, EventArgs e)
        {
            if(tbID.Text != null || tbID.Text != "")
            {
                DialogResult escolha = MessageBox.Show("Deseja excluir essa linha?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (escolha == DialogResult.Yes)
                {
                    try
                    {
                        this.conexaoSQLServer.Open();
                        this.sqlCmd = new SqlCommand();
                        sqlCmd.Connection = conexaoSQLServer;
                        if (sqlCmd.Parameters.Count == 0)
                        {
                            this.sqlCmd.CommandText = "DELETE FROM Game WHERE id_game=@ID";

                            this.sqlCmd.Parameters.Add("@ID", System.Data.SqlDbType.Int, 4);
                            this.sqlCmd.Parameters["@ID"].Value = Convert.ToInt32(tbID.Text);
                        }

                        int iresultado = this.sqlCmd.ExecuteNonQuery();

                        if (iresultado <= 0)
                            MessageBox.Show("Falha ao alterar informações no banco de dados.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Entrada excluida com sucesso.", "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Comunicação com o Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.conexaoSQLServer.Close();
                    }
                    resgatarDadosTabela(conexaoSQLServer);
                }
                else if (escolha == DialogResult.No)
                {
                    resgatarDadosTabela(conexaoSQLServer);
                }
            }
        }
    }
}
