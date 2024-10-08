﻿namespace TrackGames
{
    partial class FrmEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditar));
            this.pnEditar = new System.Windows.Forms.Panel();
            this.dgvEditar = new System.Windows.Forms.DataGridView();
            this.gameTrackerDataSet = new TrackGames.GameTrackerDataSet();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTableAdapter = new TrackGames.GameTrackerDataSetTableAdapters.GameTableAdapter();
            this.mlblDuracao = new MaterialSkin.Controls.MaterialLabel();
            this.mlblDescricao = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformas = new MaterialSkin.Controls.MaterialLabel();
            this.mlblAno = new MaterialSkin.Controls.MaterialLabel();
            this.mlblJogo = new MaterialSkin.Controls.MaterialLabel();
            this.tbJogo = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbHoras = new System.Windows.Forms.TextBox();
            this.tbPlataforma1 = new System.Windows.Forms.TextBox();
            this.tbPlataforma2 = new System.Windows.Forms.TextBox();
            this.tbPlataforma4 = new System.Windows.Forms.TextBox();
            this.tbPlataforma3 = new System.Windows.Forms.TextBox();
            this.tbPlataforma5 = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.mlblID = new MaterialSkin.Controls.MaterialLabel();
            this.mbtnAlterarImagem = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mbtnLimpar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.fdImagem = new System.Windows.Forms.OpenFileDialog();
            this.tbIDUsuario = new System.Windows.Forms.TextBox();
            this.mlblIDUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.tbUsuarioNome = new System.Windows.Forms.TextBox();
            this.mbtnAjuda = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mcbFinalizou = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbJogou = new MaterialSkin.Controls.MaterialCheckBox();
            this.mbtnExcluir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAdicionarEditar = new System.Windows.Forms.Button();
            this.tbPesquisar = new System.Windows.Forms.TextBox();
            this.btnLimparPesquisa = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pbJogo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnEditar
            // 
            this.pnEditar.Controls.Add(this.dgvEditar);
            this.pnEditar.Location = new System.Drawing.Point(0, 64);
            this.pnEditar.Name = "pnEditar";
            this.pnEditar.Size = new System.Drawing.Size(961, 306);
            this.pnEditar.TabIndex = 0;
            // 
            // dgvEditar
            // 
            this.dgvEditar.AllowUserToDeleteRows = false;
            this.dgvEditar.AllowUserToResizeRows = false;
            this.dgvEditar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dgvEditar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEditar.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEditar.Location = new System.Drawing.Point(0, 0);
            this.dgvEditar.Name = "dgvEditar";
            this.dgvEditar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditar.Size = new System.Drawing.Size(961, 306);
            this.dgvEditar.TabIndex = 0;
            this.dgvEditar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditar_CellClick);
            // 
            // gameTrackerDataSet
            // 
            this.gameTrackerDataSet.DataSetName = "GameTrackerDataSet";
            this.gameTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.gameTrackerDataSet;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // mlblDuracao
            // 
            this.mlblDuracao.AutoSize = true;
            this.mlblDuracao.BackColor = System.Drawing.Color.Transparent;
            this.mlblDuracao.Depth = 0;
            this.mlblDuracao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDuracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDuracao.Location = new System.Drawing.Point(171, 534);
            this.mlblDuracao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDuracao.Name = "mlblDuracao";
            this.mlblDuracao.Size = new System.Drawing.Size(120, 19);
            this.mlblDuracao.TabIndex = 33;
            this.mlblDuracao.Text = "Duração (Horas)";
            // 
            // mlblDescricao
            // 
            this.mlblDescricao.AutoSize = true;
            this.mlblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.mlblDescricao.Depth = 0;
            this.mlblDescricao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDescricao.Location = new System.Drawing.Point(541, 379);
            this.mlblDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDescricao.Name = "mlblDescricao";
            this.mlblDescricao.Size = new System.Drawing.Size(77, 19);
            this.mlblDescricao.TabIndex = 32;
            this.mlblDescricao.Text = "Descrição";
            // 
            // mlblPlataformas
            // 
            this.mlblPlataformas.AutoSize = true;
            this.mlblPlataformas.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformas.Depth = 0;
            this.mlblPlataformas.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformas.Location = new System.Drawing.Point(373, 379);
            this.mlblPlataformas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformas.Name = "mlblPlataformas";
            this.mlblPlataformas.Size = new System.Drawing.Size(91, 19);
            this.mlblPlataformas.TabIndex = 27;
            this.mlblPlataformas.Text = "Plataformas";
            // 
            // mlblAno
            // 
            this.mlblAno.AutoSize = true;
            this.mlblAno.BackColor = System.Drawing.Color.Transparent;
            this.mlblAno.Depth = 0;
            this.mlblAno.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblAno.Location = new System.Drawing.Point(171, 479);
            this.mlblAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblAno.Name = "mlblAno";
            this.mlblAno.Size = new System.Drawing.Size(36, 19);
            this.mlblAno.TabIndex = 26;
            this.mlblAno.Text = "Ano";
            // 
            // mlblJogo
            // 
            this.mlblJogo.AutoSize = true;
            this.mlblJogo.BackColor = System.Drawing.Color.Transparent;
            this.mlblJogo.Depth = 0;
            this.mlblJogo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblJogo.Location = new System.Drawing.Point(171, 427);
            this.mlblJogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblJogo.Name = "mlblJogo";
            this.mlblJogo.Size = new System.Drawing.Size(43, 19);
            this.mlblJogo.TabIndex = 25;
            this.mlblJogo.Text = "Jogo";
            // 
            // tbJogo
            // 
            this.tbJogo.Location = new System.Drawing.Point(190, 449);
            this.tbJogo.Name = "tbJogo";
            this.tbJogo.Size = new System.Drawing.Size(181, 20);
            this.tbJogo.TabIndex = 1;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(190, 501);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(71, 20);
            this.tbAno.TabIndex = 2;
            // 
            // tbHoras
            // 
            this.tbHoras.Location = new System.Drawing.Point(190, 556);
            this.tbHoras.Name = "tbHoras";
            this.tbHoras.Size = new System.Drawing.Size(71, 20);
            this.tbHoras.TabIndex = 3;
            // 
            // tbPlataforma1
            // 
            this.tbPlataforma1.Location = new System.Drawing.Point(396, 400);
            this.tbPlataforma1.Name = "tbPlataforma1";
            this.tbPlataforma1.Size = new System.Drawing.Size(135, 20);
            this.tbPlataforma1.TabIndex = 4;
            // 
            // tbPlataforma2
            // 
            this.tbPlataforma2.Location = new System.Drawing.Point(396, 423);
            this.tbPlataforma2.Name = "tbPlataforma2";
            this.tbPlataforma2.Size = new System.Drawing.Size(135, 20);
            this.tbPlataforma2.TabIndex = 5;
            // 
            // tbPlataforma4
            // 
            this.tbPlataforma4.Location = new System.Drawing.Point(396, 470);
            this.tbPlataforma4.Name = "tbPlataforma4";
            this.tbPlataforma4.Size = new System.Drawing.Size(135, 20);
            this.tbPlataforma4.TabIndex = 7;
            // 
            // tbPlataforma3
            // 
            this.tbPlataforma3.Location = new System.Drawing.Point(396, 447);
            this.tbPlataforma3.Name = "tbPlataforma3";
            this.tbPlataforma3.Size = new System.Drawing.Size(135, 20);
            this.tbPlataforma3.TabIndex = 6;
            // 
            // tbPlataforma5
            // 
            this.tbPlataforma5.Location = new System.Drawing.Point(396, 493);
            this.tbPlataforma5.Name = "tbPlataforma5";
            this.tbPlataforma5.Size = new System.Drawing.Size(135, 20);
            this.tbPlataforma5.TabIndex = 8;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(553, 400);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(395, 187);
            this.tbDescricao.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Location = new System.Drawing.Point(190, 398);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(71, 20);
            this.tbID.TabIndex = 0;
            // 
            // mlblID
            // 
            this.mlblID.AutoSize = true;
            this.mlblID.BackColor = System.Drawing.Color.Transparent;
            this.mlblID.Depth = 0;
            this.mlblID.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblID.Location = new System.Drawing.Point(171, 379);
            this.mlblID.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblID.Name = "mlblID";
            this.mlblID.Size = new System.Drawing.Size(23, 19);
            this.mlblID.TabIndex = 47;
            this.mlblID.Text = "ID";
            // 
            // mbtnAlterarImagem
            // 
            this.mbtnAlterarImagem.AutoSize = true;
            this.mbtnAlterarImagem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAlterarImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnAlterarImagem.Depth = 0;
            this.mbtnAlterarImagem.Icon = null;
            this.mbtnAlterarImagem.Location = new System.Drawing.Point(18, 602);
            this.mbtnAlterarImagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAlterarImagem.Name = "mbtnAlterarImagem";
            this.mbtnAlterarImagem.Primary = true;
            this.mbtnAlterarImagem.Size = new System.Drawing.Size(137, 36);
            this.mbtnAlterarImagem.TabIndex = 11;
            this.mbtnAlterarImagem.Text = "Alterar Imagem";
            this.mbtnAlterarImagem.UseVisualStyleBackColor = true;
            this.mbtnAlterarImagem.Click += new System.EventHandler(this.mbtnAlterarImagem_Click);
            // 
            // mbtnLimpar
            // 
            this.mbtnLimpar.AutoSize = true;
            this.mbtnLimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnLimpar.Depth = 0;
            this.mbtnLimpar.Icon = null;
            this.mbtnLimpar.Location = new System.Drawing.Point(705, 602);
            this.mbtnLimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLimpar.Name = "mbtnLimpar";
            this.mbtnLimpar.Primary = true;
            this.mbtnLimpar.Size = new System.Drawing.Size(71, 36);
            this.mbtnLimpar.TabIndex = 16;
            this.mbtnLimpar.Text = "Limpar";
            this.mbtnLimpar.UseVisualStyleBackColor = true;
            this.mbtnLimpar.Click += new System.EventHandler(this.mbtnLimpar_Click);
            // 
            // fdImagem
            // 
            this.fdImagem.FileName = "fdImagem";
            this.fdImagem.Filter = "\"JPEG files (*.jpeg;*.jpg)|*.jpeg;*.jpg|All files (*.*)|*.*\"";
            // 
            // tbIDUsuario
            // 
            this.tbIDUsuario.Enabled = false;
            this.tbIDUsuario.Location = new System.Drawing.Point(396, 538);
            this.tbIDUsuario.Name = "tbIDUsuario";
            this.tbIDUsuario.Size = new System.Drawing.Size(71, 20);
            this.tbIDUsuario.TabIndex = 54;
            // 
            // mlblIDUsuario
            // 
            this.mlblIDUsuario.AutoSize = true;
            this.mlblIDUsuario.BackColor = System.Drawing.Color.Transparent;
            this.mlblIDUsuario.Depth = 0;
            this.mlblIDUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblIDUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblIDUsuario.Location = new System.Drawing.Point(374, 519);
            this.mlblIDUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblIDUsuario.Name = "mlblIDUsuario";
            this.mlblIDUsuario.Size = new System.Drawing.Size(144, 19);
            this.mlblIDUsuario.TabIndex = 53;
            this.mlblIDUsuario.Text = "Usuario - ID e Nome";
            // 
            // tbUsuarioNome
            // 
            this.tbUsuarioNome.Enabled = false;
            this.tbUsuarioNome.Location = new System.Drawing.Point(396, 564);
            this.tbUsuarioNome.Name = "tbUsuarioNome";
            this.tbUsuarioNome.Size = new System.Drawing.Size(138, 20);
            this.tbUsuarioNome.TabIndex = 55;
            // 
            // mbtnAjuda
            // 
            this.mbtnAjuda.AutoSize = true;
            this.mbtnAjuda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnAjuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnAjuda.Depth = 0;
            this.mbtnAjuda.Icon = null;
            this.mbtnAjuda.Location = new System.Drawing.Point(553, 602);
            this.mbtnAjuda.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnAjuda.Name = "mbtnAjuda";
            this.mbtnAjuda.Primary = true;
            this.mbtnAjuda.Size = new System.Drawing.Size(65, 36);
            this.mbtnAjuda.TabIndex = 14;
            this.mbtnAjuda.Text = "Ajuda";
            this.mbtnAjuda.UseVisualStyleBackColor = true;
            this.mbtnAjuda.Click += new System.EventHandler(this.mbtnAjuda_Click);
            // 
            // mcbFinalizou
            // 
            this.mcbFinalizou.AutoSize = true;
            this.mcbFinalizou.BackColor = System.Drawing.Color.Transparent;
            this.mcbFinalizou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbFinalizou.Depth = 0;
            this.mcbFinalizou.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbFinalizou.Location = new System.Drawing.Point(396, 606);
            this.mcbFinalizou.Margin = new System.Windows.Forms.Padding(0);
            this.mcbFinalizou.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbFinalizou.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbFinalizou.Name = "mcbFinalizou";
            this.mcbFinalizou.Ripple = true;
            this.mcbFinalizou.Size = new System.Drawing.Size(85, 30);
            this.mcbFinalizou.TabIndex = 13;
            this.mcbFinalizou.Text = "Finalizou";
            this.mcbFinalizou.UseVisualStyleBackColor = false;
            // 
            // mcbJogou
            // 
            this.mcbJogou.AutoSize = true;
            this.mcbJogou.BackColor = System.Drawing.Color.Transparent;
            this.mcbJogou.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mcbJogou.Depth = 0;
            this.mcbJogou.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbJogou.Location = new System.Drawing.Point(187, 606);
            this.mcbJogou.Margin = new System.Windows.Forms.Padding(0);
            this.mcbJogou.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbJogou.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbJogou.Name = "mcbJogou";
            this.mcbJogou.Ripple = true;
            this.mcbJogou.Size = new System.Drawing.Size(69, 30);
            this.mcbJogou.TabIndex = 12;
            this.mcbJogou.Text = "Jogou";
            this.mcbJogou.UseVisualStyleBackColor = false;
            // 
            // mbtnExcluir
            // 
            this.mbtnExcluir.AutoSize = true;
            this.mbtnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnExcluir.Depth = 0;
            this.mbtnExcluir.Icon = null;
            this.mbtnExcluir.Location = new System.Drawing.Point(624, 602);
            this.mbtnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnExcluir.Name = "mbtnExcluir";
            this.mbtnExcluir.Primary = true;
            this.mbtnExcluir.Size = new System.Drawing.Size(75, 36);
            this.mbtnExcluir.TabIndex = 15;
            this.mbtnExcluir.Text = "Excluir";
            this.mbtnExcluir.UseVisualStyleBackColor = true;
            this.mbtnExcluir.Click += new System.EventHandler(this.mbtnExcluir_Click);
            // 
            // btnAdicionarEditar
            // 
            this.btnAdicionarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.btnAdicionarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(156)))), ((int)(((byte)(160)))));
            this.btnAdicionarEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarEditar.Font = new System.Drawing.Font("Roboto", 10F);
            this.btnAdicionarEditar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarEditar.Location = new System.Drawing.Point(781, 602);
            this.btnAdicionarEditar.Name = "btnAdicionarEditar";
            this.btnAdicionarEditar.Size = new System.Drawing.Size(167, 36);
            this.btnAdicionarEditar.TabIndex = 57;
            this.btnAdicionarEditar.Text = "ADICIONAR / EDITAR";
            this.btnAdicionarEditar.UseVisualStyleBackColor = false;
            this.btnAdicionarEditar.Click += new System.EventHandler(this.btnAdicionarEditar_Click);
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisar.ForeColor = System.Drawing.Color.Gray;
            this.tbPesquisar.Location = new System.Drawing.Point(701, 33);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Size = new System.Drawing.Size(181, 21);
            this.tbPesquisar.TabIndex = 58;
            this.tbPesquisar.Text = "Pesquisar por Nome";
            this.tbPesquisar.Click += new System.EventHandler(this.tbPesquisar_Click);
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            // 
            // btnLimparPesquisa
            // 
            this.btnLimparPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.btnLimparPesquisa.BackgroundImage = global::TrackGames.Properties.Resources.limpar32;
            this.btnLimparPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparPesquisa.FlatAppearance.BorderSize = 0;
            this.btnLimparPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparPesquisa.Location = new System.Drawing.Point(924, 27);
            this.btnLimparPesquisa.Name = "btnLimparPesquisa";
            this.btnLimparPesquisa.Size = new System.Drawing.Size(32, 32);
            this.btnLimparPesquisa.TabIndex = 60;
            this.toolTip.SetToolTip(this.btnLimparPesquisa, "Limpar Pesquisa");
            this.btnLimparPesquisa.UseVisualStyleBackColor = false;
            this.btnLimparPesquisa.Click += new System.EventHandler(this.btnLimparPesquisa_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = global::TrackGames.Properties.Resources.pesquisar32;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Location = new System.Drawing.Point(886, 27);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(32, 32);
            this.btnPesquisar.TabIndex = 59;
            this.toolTip.SetToolTip(this.btnPesquisar, "Pesquisar");
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // pbJogo
            // 
            this.pbJogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gameBindingSource, "capa_game", true));
            this.pbJogo.Location = new System.Drawing.Point(7, 376);
            this.pbJogo.Name = "pbJogo";
            this.pbJogo.Size = new System.Drawing.Size(158, 215);
            this.pbJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJogo.TabIndex = 20;
            this.pbJogo.TabStop = false;
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 650);
            this.Controls.Add(this.btnLimparPesquisa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.btnAdicionarEditar);
            this.Controls.Add(this.mbtnExcluir);
            this.Controls.Add(this.mcbFinalizou);
            this.Controls.Add(this.mcbJogou);
            this.Controls.Add(this.mbtnAjuda);
            this.Controls.Add(this.tbUsuarioNome);
            this.Controls.Add(this.tbIDUsuario);
            this.Controls.Add(this.mlblIDUsuario);
            this.Controls.Add(this.mbtnLimpar);
            this.Controls.Add(this.mbtnAlterarImagem);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.mlblID);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbPlataforma5);
            this.Controls.Add(this.tbPlataforma4);
            this.Controls.Add(this.tbPlataforma3);
            this.Controls.Add(this.tbPlataforma2);
            this.Controls.Add(this.tbPlataforma1);
            this.Controls.Add(this.tbHoras);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbJogo);
            this.Controls.Add(this.mlblDuracao);
            this.Controls.Add(this.mlblDescricao);
            this.Controls.Add(this.pbJogo);
            this.Controls.Add(this.mlblPlataformas);
            this.Controls.Add(this.mlblAno);
            this.Controls.Add(this.mlblJogo);
            this.Controls.Add(this.pnEditar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackGames - Editar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmEditar_FormClosed);
            this.Load += new System.EventHandler(this.FrmEditar_Load);
            this.pnEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnEditar;
        private System.Windows.Forms.DataGridView dgvEditar;
        private GameTrackerDataSet gameTrackerDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private GameTrackerDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private MaterialSkin.Controls.MaterialLabel mlblDuracao;
        private MaterialSkin.Controls.MaterialLabel mlblDescricao;
        private System.Windows.Forms.PictureBox pbJogo;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformas;
        private MaterialSkin.Controls.MaterialLabel mlblAno;
        private MaterialSkin.Controls.MaterialLabel mlblJogo;
        private System.Windows.Forms.TextBox tbJogo;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbHoras;
        private System.Windows.Forms.TextBox tbPlataforma1;
        private System.Windows.Forms.TextBox tbPlataforma2;
        private System.Windows.Forms.TextBox tbPlataforma4;
        private System.Windows.Forms.TextBox tbPlataforma3;
        private System.Windows.Forms.TextBox tbPlataforma5;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.TextBox tbID;
        private MaterialSkin.Controls.MaterialLabel mlblID;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAlterarImagem;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnLimpar;
        private System.Windows.Forms.OpenFileDialog fdImagem;
        private System.Windows.Forms.TextBox tbIDUsuario;
        private MaterialSkin.Controls.MaterialLabel mlblIDUsuario;
        private System.Windows.Forms.TextBox tbUsuarioNome;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnAjuda;
        private MaterialSkin.Controls.MaterialCheckBox mcbFinalizou;
        private MaterialSkin.Controls.MaterialCheckBox mcbJogou;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnExcluir;
        private System.Windows.Forms.Button btnAdicionarEditar;
        private System.Windows.Forms.TextBox tbPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimparPesquisa;
        private System.Windows.Forms.ToolTip toolTip;
    }
}