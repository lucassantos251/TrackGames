namespace TrackGames
{
    partial class FrmBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBD));
            this.mlblString = new MaterialSkin.Controls.MaterialLabel();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnPadrao = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // mlblString
            // 
            this.mlblString.AutoSize = true;
            this.mlblString.Depth = 0;
            this.mlblString.Font = new System.Drawing.Font("Roboto", 11F);
            this.mlblString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mlblString.Location = new System.Drawing.Point(12, 80);
            this.mlblString.MouseState = MaterialSkin.MouseState.HOVER;
            this.mlblString.Name = "mlblString";
            this.mlblString.Size = new System.Drawing.Size(265, 19);
            this.mlblString.TabIndex = 0;
            this.mlblString.Text = "String de Conexão do Banco de Dados";
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(48, 102);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(708, 20);
            this.tbDB.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmar.Depth = 0;
            this.btnConfirmar.Icon = null;
            this.btnConfirmar.Location = new System.Drawing.Point(689, 140);
            this.btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Primary = true;
            this.btnConfirmar.Size = new System.Drawing.Size(99, 36);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPadrao
            // 
            this.btnPadrao.AutoSize = true;
            this.btnPadrao.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPadrao.Depth = 0;
            this.btnPadrao.Icon = null;
            this.btnPadrao.Location = new System.Drawing.Point(608, 140);
            this.btnPadrao.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Primary = true;
            this.btnPadrao.Size = new System.Drawing.Size(75, 36);
            this.btnPadrao.TabIndex = 3;
            this.btnPadrao.Text = "Padrão";
            this.btnPadrao.UseVisualStyleBackColor = true;
            this.btnPadrao.Click += new System.EventHandler(this.btnPadrao_Click);
            // 
            // FrmBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 189);
            this.Controls.Add(this.btnPadrao);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.mlblString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackGames - Banco de Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel mlblString;
        private System.Windows.Forms.TextBox tbDB;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmar;
        private MaterialSkin.Controls.MaterialRaisedButton btnPadrao;
    }
}