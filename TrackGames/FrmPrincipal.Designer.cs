namespace TrackGames
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameTrackerDataSet = new TrackGames.GameTrackerDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPrincipal = new System.Windows.Forms.DataGridView();
            this.btnFechar = new System.Windows.Forms.Button();
            this.gameTableAdapter = new TrackGames.GameTrackerDataSetTableAdapters.GameTableAdapter();
            this.mlblNomeValor = new MaterialSkin.Controls.MaterialLabel();
            this.mlblAnoValor = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformaValor1 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblDescricaoValor = new MaterialSkin.Controls.MaterialLabel();
            this.mlblJogo = new MaterialSkin.Controls.MaterialLabel();
            this.mlblAno = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformas = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformaValor2 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformaValor3 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformaValor4 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblPlataformaValor5 = new MaterialSkin.Controls.MaterialLabel();
            this.mlblDescricao = new MaterialSkin.Controls.MaterialLabel();
            this.mlblDuracao = new MaterialSkin.Controls.MaterialLabel();
            this.mlblDuracaoValor = new MaterialSkin.Controls.MaterialLabel();
            this.mcbJogou = new MaterialSkin.Controls.MaterialCheckBox();
            this.mcbFinalizou = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbJogo = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.idgameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomegameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anogameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediahorasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma1gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma2gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma3gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma4gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plataforma5gameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fkusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariojogouDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuariofinalizouDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.descricaogameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capagameDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTrackerDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo)).BeginInit();
            this.SuspendLayout();
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "Game";
            this.gameBindingSource.DataSource = this.gameTrackerDataSet;
            // 
            // gameTrackerDataSet
            // 
            this.gameTrackerDataSet.DataSetName = "GameTrackerDataSet";
            this.gameTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.dgvPrincipal);
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 248);
            this.panel3.TabIndex = 2;
            // 
            // dgvPrincipal
            // 
            this.dgvPrincipal.AllowUserToAddRows = false;
            this.dgvPrincipal.AllowUserToDeleteRows = false;
            this.dgvPrincipal.AllowUserToResizeColumns = false;
            this.dgvPrincipal.AllowUserToResizeRows = false;
            this.dgvPrincipal.AutoGenerateColumns = false;
            this.dgvPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idgameDataGridViewTextBoxColumn,
            this.nomegameDataGridViewTextBoxColumn,
            this.anogameDataGridViewTextBoxColumn,
            this.mediahorasDataGridViewTextBoxColumn,
            this.plataforma1gameDataGridViewTextBoxColumn,
            this.plataforma2gameDataGridViewTextBoxColumn,
            this.plataforma3gameDataGridViewTextBoxColumn,
            this.plataforma4gameDataGridViewTextBoxColumn,
            this.plataforma5gameDataGridViewTextBoxColumn,
            this.fkusuarioDataGridViewTextBoxColumn,
            this.usuariojogouDataGridViewCheckBoxColumn,
            this.usuariofinalizouDataGridViewCheckBoxColumn,
            this.descricaogameDataGridViewTextBoxColumn,
            this.capagameDataGridViewImageColumn});
            this.dgvPrincipal.DataSource = this.gameBindingSource;
            this.dgvPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrincipal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrincipal.Location = new System.Drawing.Point(0, 0);
            this.dgvPrincipal.Name = "dgvPrincipal";
            this.dgvPrincipal.ReadOnly = true;
            this.dgvPrincipal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrincipal.ShowEditingIcon = false;
            this.dgvPrincipal.Size = new System.Drawing.Size(961, 248);
            this.dgvPrincipal.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(927, -1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(26, 25);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // mlblNomeValor
            // 
            this.mlblNomeValor.BackColor = System.Drawing.Color.Transparent;
            this.mlblNomeValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "nome_game", true));
            this.mlblNomeValor.Depth = 0;
            this.mlblNomeValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblNomeValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblNomeValor.Location = new System.Drawing.Point(184, 344);
            this.mlblNomeValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblNomeValor.Name = "mlblNomeValor";
            this.mlblNomeValor.Size = new System.Drawing.Size(195, 38);
            this.mlblNomeValor.TabIndex = 1;
            this.mlblNomeValor.Text = "\"Nome do Jogo\"";
            // 
            // mlblAnoValor
            // 
            this.mlblAnoValor.AutoSize = true;
            this.mlblAnoValor.BackColor = System.Drawing.Color.Transparent;
            this.mlblAnoValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "ano_game", true));
            this.mlblAnoValor.Depth = 0;
            this.mlblAnoValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblAnoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblAnoValor.Location = new System.Drawing.Point(184, 396);
            this.mlblAnoValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblAnoValor.Name = "mlblAnoValor";
            this.mlblAnoValor.Size = new System.Drawing.Size(46, 19);
            this.mlblAnoValor.TabIndex = 2;
            this.mlblAnoValor.Text = "\"Ano\"";
            // 
            // mlblPlataformaValor1
            // 
            this.mlblPlataformaValor1.AutoSize = true;
            this.mlblPlataformaValor1.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformaValor1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "plataforma1_game", true));
            this.mlblPlataformaValor1.Depth = 0;
            this.mlblPlataformaValor1.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformaValor1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformaValor1.Location = new System.Drawing.Point(393, 344);
            this.mlblPlataformaValor1.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformaValor1.Name = "mlblPlataformaValor1";
            this.mlblPlataformaValor1.Size = new System.Drawing.Size(93, 19);
            this.mlblPlataformaValor1.TabIndex = 3;
            this.mlblPlataformaValor1.Text = "\"Plataforma\"";
            // 
            // mlblDescricaoValor
            // 
            this.mlblDescricaoValor.BackColor = System.Drawing.Color.Transparent;
            this.mlblDescricaoValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "descricao_game", true));
            this.mlblDescricaoValor.Depth = 0;
            this.mlblDescricaoValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDescricaoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDescricaoValor.Location = new System.Drawing.Point(552, 344);
            this.mlblDescricaoValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDescricaoValor.Name = "mlblDescricaoValor";
            this.mlblDescricaoValor.Size = new System.Drawing.Size(401, 191);
            this.mlblDescricaoValor.TabIndex = 4;
            this.mlblDescricaoValor.Text = "\"Descrição\"";
            // 
            // mlblJogo
            // 
            this.mlblJogo.AutoSize = true;
            this.mlblJogo.BackColor = System.Drawing.Color.Transparent;
            this.mlblJogo.Depth = 0;
            this.mlblJogo.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblJogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblJogo.Location = new System.Drawing.Point(169, 322);
            this.mlblJogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblJogo.Name = "mlblJogo";
            this.mlblJogo.Size = new System.Drawing.Size(43, 19);
            this.mlblJogo.TabIndex = 5;
            this.mlblJogo.Text = "Jogo";
            // 
            // mlblAno
            // 
            this.mlblAno.AutoSize = true;
            this.mlblAno.BackColor = System.Drawing.Color.Transparent;
            this.mlblAno.Depth = 0;
            this.mlblAno.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblAno.Location = new System.Drawing.Point(169, 377);
            this.mlblAno.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblAno.Name = "mlblAno";
            this.mlblAno.Size = new System.Drawing.Size(36, 19);
            this.mlblAno.TabIndex = 6;
            this.mlblAno.Text = "Ano";
            // 
            // mlblPlataformas
            // 
            this.mlblPlataformas.AutoSize = true;
            this.mlblPlataformas.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformas.Depth = 0;
            this.mlblPlataformas.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformas.Location = new System.Drawing.Point(374, 322);
            this.mlblPlataformas.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformas.Name = "mlblPlataformas";
            this.mlblPlataformas.Size = new System.Drawing.Size(91, 19);
            this.mlblPlataformas.TabIndex = 7;
            this.mlblPlataformas.Text = "Plataformas";
            // 
            // mlblPlataformaValor2
            // 
            this.mlblPlataformaValor2.AutoSize = true;
            this.mlblPlataformaValor2.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformaValor2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "plataforma2_game", true));
            this.mlblPlataformaValor2.Depth = 0;
            this.mlblPlataformaValor2.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformaValor2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformaValor2.Location = new System.Drawing.Point(393, 363);
            this.mlblPlataformaValor2.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformaValor2.Name = "mlblPlataformaValor2";
            this.mlblPlataformaValor2.Size = new System.Drawing.Size(93, 19);
            this.mlblPlataformaValor2.TabIndex = 8;
            this.mlblPlataformaValor2.Text = "\"Plataforma\"";
            // 
            // mlblPlataformaValor3
            // 
            this.mlblPlataformaValor3.AutoSize = true;
            this.mlblPlataformaValor3.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformaValor3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "plataforma3_game", true));
            this.mlblPlataformaValor3.Depth = 0;
            this.mlblPlataformaValor3.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformaValor3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformaValor3.Location = new System.Drawing.Point(393, 382);
            this.mlblPlataformaValor3.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformaValor3.Name = "mlblPlataformaValor3";
            this.mlblPlataformaValor3.Size = new System.Drawing.Size(93, 19);
            this.mlblPlataformaValor3.TabIndex = 9;
            this.mlblPlataformaValor3.Text = "\"Plataforma\"";
            // 
            // mlblPlataformaValor4
            // 
            this.mlblPlataformaValor4.AutoSize = true;
            this.mlblPlataformaValor4.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformaValor4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "plataforma4_game", true));
            this.mlblPlataformaValor4.Depth = 0;
            this.mlblPlataformaValor4.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformaValor4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformaValor4.Location = new System.Drawing.Point(393, 401);
            this.mlblPlataformaValor4.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformaValor4.Name = "mlblPlataformaValor4";
            this.mlblPlataformaValor4.Size = new System.Drawing.Size(93, 19);
            this.mlblPlataformaValor4.TabIndex = 10;
            this.mlblPlataformaValor4.Text = "\"Plataforma\"";
            // 
            // mlblPlataformaValor5
            // 
            this.mlblPlataformaValor5.AutoSize = true;
            this.mlblPlataformaValor5.BackColor = System.Drawing.Color.Transparent;
            this.mlblPlataformaValor5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "plataforma5_game", true));
            this.mlblPlataformaValor5.Depth = 0;
            this.mlblPlataformaValor5.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblPlataformaValor5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblPlataformaValor5.Location = new System.Drawing.Point(393, 420);
            this.mlblPlataformaValor5.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblPlataformaValor5.Name = "mlblPlataformaValor5";
            this.mlblPlataformaValor5.Size = new System.Drawing.Size(93, 19);
            this.mlblPlataformaValor5.TabIndex = 11;
            this.mlblPlataformaValor5.Text = "\"Plataforma\"";
            // 
            // mlblDescricao
            // 
            this.mlblDescricao.AutoSize = true;
            this.mlblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.mlblDescricao.Depth = 0;
            this.mlblDescricao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDescricao.Location = new System.Drawing.Point(542, 322);
            this.mlblDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDescricao.Name = "mlblDescricao";
            this.mlblDescricao.Size = new System.Drawing.Size(77, 19);
            this.mlblDescricao.TabIndex = 12;
            this.mlblDescricao.Text = "Descrição";
            // 
            // mlblDuracao
            // 
            this.mlblDuracao.AutoSize = true;
            this.mlblDuracao.BackColor = System.Drawing.Color.Transparent;
            this.mlblDuracao.Depth = 0;
            this.mlblDuracao.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDuracao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDuracao.Location = new System.Drawing.Point(169, 432);
            this.mlblDuracao.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDuracao.Name = "mlblDuracao";
            this.mlblDuracao.Size = new System.Drawing.Size(120, 19);
            this.mlblDuracao.TabIndex = 13;
            this.mlblDuracao.Text = "Duração (Horas)";
            // 
            // mlblDuracaoValor
            // 
            this.mlblDuracaoValor.AutoSize = true;
            this.mlblDuracaoValor.BackColor = System.Drawing.Color.Transparent;
            this.mlblDuracaoValor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gameBindingSource, "media_horas", true));
            this.mlblDuracaoValor.Depth = 0;
            this.mlblDuracaoValor.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblDuracaoValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblDuracaoValor.Location = new System.Drawing.Point(184, 451);
            this.mlblDuracaoValor.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblDuracaoValor.Name = "mlblDuracaoValor";
            this.mlblDuracaoValor.Size = new System.Drawing.Size(60, 19);
            this.mlblDuracaoValor.TabIndex = 14;
            this.mlblDuracaoValor.Text = "\"Horas\"";
            // 
            // mcbJogou
            // 
            this.mcbJogou.AutoSize = true;
            this.mcbJogou.BackColor = System.Drawing.Color.Transparent;
            this.mcbJogou.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.gameBindingSource, "usuario_jogou", true));
            this.mcbJogou.Depth = 0;
            this.mcbJogou.Enabled = false;
            this.mcbJogou.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbJogou.Location = new System.Drawing.Point(173, 500);
            this.mcbJogou.Margin = new System.Windows.Forms.Padding(0);
            this.mcbJogou.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbJogou.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbJogou.Name = "mcbJogou";
            this.mcbJogou.Ripple = true;
            this.mcbJogou.Size = new System.Drawing.Size(69, 30);
            this.mcbJogou.TabIndex = 18;
            this.mcbJogou.Text = "Jogou";
            this.mcbJogou.UseVisualStyleBackColor = false;
            // 
            // mcbFinalizou
            // 
            this.mcbFinalizou.AutoSize = true;
            this.mcbFinalizou.BackColor = System.Drawing.Color.Transparent;
            this.mcbFinalizou.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.gameBindingSource, "usuario_finalizou", true));
            this.mcbFinalizou.Depth = 0;
            this.mcbFinalizou.Enabled = false;
            this.mcbFinalizou.Font = new System.Drawing.Font("Roboto", 10F);
            this.mcbFinalizou.Location = new System.Drawing.Point(378, 500);
            this.mcbFinalizou.Margin = new System.Windows.Forms.Padding(0);
            this.mcbFinalizou.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbFinalizou.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbFinalizou.Name = "mcbFinalizou";
            this.mcbFinalizou.Ripple = true;
            this.mcbFinalizou.Size = new System.Drawing.Size(85, 30);
            this.mcbFinalizou.TabIndex = 19;
            this.mcbFinalizou.Text = "Finalizou";
            this.mcbFinalizou.UseVisualStyleBackColor = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsuario.Location = new System.Drawing.Point(732, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(186, 23);
            this.lblUsuario.TabIndex = 20;
            this.lblUsuario.Text = "\"Usuario\"";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = global::TrackGames.Properties.Resources.sair32;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(777, 28);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 32);
            this.btnSair.TabIndex = 24;
            this.toolTip.SetToolTip(this.btnSair, "Sair");
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.Transparent;
            this.btnAtualizar.BackgroundImage = global::TrackGames.Properties.Resources.atualizar32;
            this.btnAtualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Location = new System.Drawing.Point(157, 27);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(32, 32);
            this.btnAtualizar.TabIndex = 23;
            this.toolTip.SetToolTip(this.btnAtualizar, "Atualizar");
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuario.BackgroundImage = global::TrackGames.Properties.Resources.usuario32;
            this.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(815, 28);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(32, 32);
            this.btnUsuario.TabIndex = 22;
            this.toolTip.SetToolTip(this.btnUsuario, "Usuário");
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.BackgroundImage = global::TrackGames.Properties.Resources.editar32;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(119, 27);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(32, 32);
            this.btnEditar.TabIndex = 21;
            this.toolTip.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pbUsuario
            // 
            this.pbUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pbUsuario.Location = new System.Drawing.Point(921, 24);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(39, 39);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 1;
            this.pbUsuario.TabStop = false;
            // 
            // pbJogo
            // 
            this.pbJogo.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.gameBindingSource, "capa_game", true));
            this.pbJogo.Location = new System.Drawing.Point(6, 320);
            this.pbJogo.Name = "pbJogo";
            this.pbJogo.Size = new System.Drawing.Size(158, 215);
            this.pbJogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbJogo.TabIndex = 0;
            this.pbJogo.TabStop = false;
            // 
            // idgameDataGridViewTextBoxColumn
            // 
            this.idgameDataGridViewTextBoxColumn.DataPropertyName = "id_game";
            this.idgameDataGridViewTextBoxColumn.HeaderText = "id_game";
            this.idgameDataGridViewTextBoxColumn.Name = "idgameDataGridViewTextBoxColumn";
            this.idgameDataGridViewTextBoxColumn.ReadOnly = true;
            this.idgameDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomegameDataGridViewTextBoxColumn
            // 
            this.nomegameDataGridViewTextBoxColumn.DataPropertyName = "nome_game";
            this.nomegameDataGridViewTextBoxColumn.FillWeight = 93.44457F;
            this.nomegameDataGridViewTextBoxColumn.HeaderText = "Jogo";
            this.nomegameDataGridViewTextBoxColumn.MinimumWidth = 115;
            this.nomegameDataGridViewTextBoxColumn.Name = "nomegameDataGridViewTextBoxColumn";
            this.nomegameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // anogameDataGridViewTextBoxColumn
            // 
            this.anogameDataGridViewTextBoxColumn.DataPropertyName = "ano_game";
            this.anogameDataGridViewTextBoxColumn.FillWeight = 25F;
            this.anogameDataGridViewTextBoxColumn.HeaderText = "Ano";
            this.anogameDataGridViewTextBoxColumn.Name = "anogameDataGridViewTextBoxColumn";
            this.anogameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mediahorasDataGridViewTextBoxColumn
            // 
            this.mediahorasDataGridViewTextBoxColumn.DataPropertyName = "media_horas";
            this.mediahorasDataGridViewTextBoxColumn.FillWeight = 25F;
            this.mediahorasDataGridViewTextBoxColumn.HeaderText = "Horas";
            this.mediahorasDataGridViewTextBoxColumn.Name = "mediahorasDataGridViewTextBoxColumn";
            this.mediahorasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataforma1gameDataGridViewTextBoxColumn
            // 
            this.plataforma1gameDataGridViewTextBoxColumn.DataPropertyName = "plataforma1_game";
            this.plataforma1gameDataGridViewTextBoxColumn.FillWeight = 93.44457F;
            this.plataforma1gameDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataforma1gameDataGridViewTextBoxColumn.Name = "plataforma1gameDataGridViewTextBoxColumn";
            this.plataforma1gameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataforma2gameDataGridViewTextBoxColumn
            // 
            this.plataforma2gameDataGridViewTextBoxColumn.DataPropertyName = "plataforma2_game";
            this.plataforma2gameDataGridViewTextBoxColumn.FillWeight = 93.44457F;
            this.plataforma2gameDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataforma2gameDataGridViewTextBoxColumn.Name = "plataforma2gameDataGridViewTextBoxColumn";
            this.plataforma2gameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataforma3gameDataGridViewTextBoxColumn
            // 
            this.plataforma3gameDataGridViewTextBoxColumn.DataPropertyName = "plataforma3_game";
            this.plataforma3gameDataGridViewTextBoxColumn.FillWeight = 93.44457F;
            this.plataforma3gameDataGridViewTextBoxColumn.HeaderText = "Plataforma";
            this.plataforma3gameDataGridViewTextBoxColumn.Name = "plataforma3gameDataGridViewTextBoxColumn";
            this.plataforma3gameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plataforma4gameDataGridViewTextBoxColumn
            // 
            this.plataforma4gameDataGridViewTextBoxColumn.DataPropertyName = "plataforma4_game";
            this.plataforma4gameDataGridViewTextBoxColumn.HeaderText = "plataforma4_game";
            this.plataforma4gameDataGridViewTextBoxColumn.Name = "plataforma4gameDataGridViewTextBoxColumn";
            this.plataforma4gameDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataforma4gameDataGridViewTextBoxColumn.Visible = false;
            // 
            // plataforma5gameDataGridViewTextBoxColumn
            // 
            this.plataforma5gameDataGridViewTextBoxColumn.DataPropertyName = "plataforma5_game";
            this.plataforma5gameDataGridViewTextBoxColumn.HeaderText = "plataforma5_game";
            this.plataforma5gameDataGridViewTextBoxColumn.Name = "plataforma5gameDataGridViewTextBoxColumn";
            this.plataforma5gameDataGridViewTextBoxColumn.ReadOnly = true;
            this.plataforma5gameDataGridViewTextBoxColumn.Visible = false;
            // 
            // fkusuarioDataGridViewTextBoxColumn
            // 
            this.fkusuarioDataGridViewTextBoxColumn.DataPropertyName = "fk_usuario";
            this.fkusuarioDataGridViewTextBoxColumn.HeaderText = "fk_usuario";
            this.fkusuarioDataGridViewTextBoxColumn.Name = "fkusuarioDataGridViewTextBoxColumn";
            this.fkusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fkusuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // usuariojogouDataGridViewCheckBoxColumn
            // 
            this.usuariojogouDataGridViewCheckBoxColumn.DataPropertyName = "usuario_jogou";
            this.usuariojogouDataGridViewCheckBoxColumn.FillWeight = 25F;
            this.usuariojogouDataGridViewCheckBoxColumn.HeaderText = "Jogou";
            this.usuariojogouDataGridViewCheckBoxColumn.Name = "usuariojogouDataGridViewCheckBoxColumn";
            this.usuariojogouDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usuariofinalizouDataGridViewCheckBoxColumn
            // 
            this.usuariofinalizouDataGridViewCheckBoxColumn.DataPropertyName = "usuario_finalizou";
            this.usuariofinalizouDataGridViewCheckBoxColumn.FillWeight = 25F;
            this.usuariofinalizouDataGridViewCheckBoxColumn.HeaderText = "Finalizou";
            this.usuariofinalizouDataGridViewCheckBoxColumn.Name = "usuariofinalizouDataGridViewCheckBoxColumn";
            this.usuariofinalizouDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // descricaogameDataGridViewTextBoxColumn
            // 
            this.descricaogameDataGridViewTextBoxColumn.DataPropertyName = "descricao_game";
            this.descricaogameDataGridViewTextBoxColumn.HeaderText = "descricao_game";
            this.descricaogameDataGridViewTextBoxColumn.Name = "descricaogameDataGridViewTextBoxColumn";
            this.descricaogameDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaogameDataGridViewTextBoxColumn.Visible = false;
            // 
            // capagameDataGridViewImageColumn
            // 
            this.capagameDataGridViewImageColumn.DataPropertyName = "capa_game";
            this.capagameDataGridViewImageColumn.HeaderText = "capa_game";
            this.capagameDataGridViewImageColumn.Name = "capagameDataGridViewImageColumn";
            this.capagameDataGridViewImageColumn.ReadOnly = true;
            this.capagameDataGridViewImageColumn.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 544);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.mcbFinalizou);
            this.Controls.Add(this.mcbJogou);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.mlblDuracaoValor);
            this.Controls.Add(this.mlblDuracao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mlblDescricao);
            this.Controls.Add(this.mlblPlataformaValor5);
            this.Controls.Add(this.pbJogo);
            this.Controls.Add(this.mlblPlataformaValor4);
            this.Controls.Add(this.mlblNomeValor);
            this.Controls.Add(this.mlblPlataformaValor3);
            this.Controls.Add(this.mlblAnoValor);
            this.Controls.Add(this.mlblPlataformaValor2);
            this.Controls.Add(this.mlblPlataformaValor1);
            this.Controls.Add(this.mlblPlataformas);
            this.Controls.Add(this.mlblDescricaoValor);
            this.Controls.Add(this.mlblAno);
            this.Controls.Add(this.mlblJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackGames";
            this.Activated += new System.EventHandler(this.btnAtualizar_Click);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameTrackerDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbJogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPrincipal;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Button btnFechar;
        private GameTrackerDataSet gameTrackerDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private GameTrackerDataSetTableAdapters.GameTableAdapter gameTableAdapter;
        private System.Windows.Forms.PictureBox pbJogo;
        private MaterialSkin.Controls.MaterialLabel mlblNomeValor;
        private MaterialSkin.Controls.MaterialLabel mlblAnoValor;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformaValor1;
        private MaterialSkin.Controls.MaterialLabel mlblDescricaoValor;
        private MaterialSkin.Controls.MaterialLabel mlblJogo;
        private MaterialSkin.Controls.MaterialLabel mlblAno;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformas;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformaValor2;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformaValor3;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformaValor4;
        private MaterialSkin.Controls.MaterialLabel mlblPlataformaValor5;
        private MaterialSkin.Controls.MaterialLabel mlblDescricao;
        private MaterialSkin.Controls.MaterialLabel mlblDuracao;
        private MaterialSkin.Controls.MaterialLabel mlblDuracaoValor;
        private MaterialSkin.Controls.MaterialCheckBox mcbJogou;
        private MaterialSkin.Controls.MaterialCheckBox mcbFinalizou;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn idgameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomegameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anogameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediahorasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma1gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma2gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma3gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma4gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plataforma5gameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usuariojogouDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn usuariofinalizouDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaogameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn capagameDataGridViewImageColumn;
    }
}