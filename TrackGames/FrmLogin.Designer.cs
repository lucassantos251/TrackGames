namespace TrackGames
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.mlblLogin = new MaterialSkin.Controls.MaterialLabel();
            this.mlblSenha = new MaterialSkin.Controls.MaterialLabel();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbSenha = new System.Windows.Forms.TextBox();
            this.mbtnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCriarUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mlblLogin
            // 
            this.mlblLogin.AutoSize = true;
            this.mlblLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlblLogin.Depth = 0;
            this.mlblLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblLogin.Location = new System.Drawing.Point(86, 274);
            this.mlblLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblLogin.Name = "mlblLogin";
            this.mlblLogin.Size = new System.Drawing.Size(50, 19);
            this.mlblLogin.TabIndex = 0;
            this.mlblLogin.Text = "Login:";
            // 
            // mlblSenha
            // 
            this.mlblSenha.AutoSize = true;
            this.mlblSenha.BackColor = System.Drawing.Color.Transparent;
            this.mlblSenha.Depth = 0;
            this.mlblSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblSenha.Location = new System.Drawing.Point(86, 305);
            this.mlblSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblSenha.Name = "mlblSenha";
            this.mlblSenha.Size = new System.Drawing.Size(54, 19);
            this.mlblSenha.TabIndex = 1;
            this.mlblSenha.Text = "Senha:";
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbLogin.Location = new System.Drawing.Point(151, 272);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(158, 25);
            this.tbLogin.TabIndex = 2;
            // 
            // tbSenha
            // 
            this.tbSenha.Font = new System.Drawing.Font("Roboto", 11F);
            this.tbSenha.Location = new System.Drawing.Point(151, 303);
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.Size = new System.Drawing.Size(158, 25);
            this.tbSenha.TabIndex = 3;
            this.tbSenha.UseSystemPasswordChar = true;
            this.tbSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSenha_KeyUp);
            // 
            // mbtnLogin
            // 
            this.mbtnLogin.AutoSize = true;
            this.mbtnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mbtnLogin.Depth = 0;
            this.mbtnLogin.Icon = null;
            this.mbtnLogin.Location = new System.Drawing.Point(170, 345);
            this.mbtnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnLogin.Name = "mbtnLogin";
            this.mbtnLogin.Primary = true;
            this.mbtnLogin.Size = new System.Drawing.Size(61, 36);
            this.mbtnLogin.TabIndex = 5;
            this.mbtnLogin.Text = "LOGIN";
            this.mbtnLogin.UseVisualStyleBackColor = true;
            this.mbtnLogin.Click += new System.EventHandler(this.mbtnLogin_Click);
            // 
            // btnCriarUsuario
            // 
            this.btnCriarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.btnCriarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarUsuario.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarUsuario.Location = new System.Drawing.Point(306, 415);
            this.btnCriarUsuario.Name = "btnCriarUsuario";
            this.btnCriarUsuario.Size = new System.Drawing.Size(82, 23);
            this.btnCriarUsuario.TabIndex = 6;
            this.btnCriarUsuario.Text = "Criar Usuário";
            this.btnCriarUsuario.UseVisualStyleBackColor = false;
            this.btnCriarUsuario.Click += new System.EventHandler(this.btnCriarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrackGames.Properties.Resources.game_console;
            this.pictureBox1.Location = new System.Drawing.Point(118, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnBD
            // 
            this.btnBD.BackColor = System.Drawing.Color.Transparent;
            this.btnBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBD.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBD.Location = new System.Drawing.Point(12, 415);
            this.btnBD.Name = "btnBD";
            this.btnBD.Size = new System.Drawing.Size(82, 23);
            this.btnBD.TabIndex = 8;
            this.btnBD.Text = "BD";
            this.btnBD.UseVisualStyleBackColor = false;
            this.btnBD.Click += new System.EventHandler(this.btnBD_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.btnBD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCriarUsuario);
            this.Controls.Add(this.mbtnLogin);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.mlblSenha);
            this.Controls.Add(this.mlblLogin);
            this.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackGames - Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlblLogin;
        private MaterialSkin.Controls.MaterialLabel mlblSenha;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbSenha;
        private MaterialSkin.Controls.MaterialRaisedButton mbtnLogin;
        private System.Windows.Forms.Button btnCriarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBD;
    }
}