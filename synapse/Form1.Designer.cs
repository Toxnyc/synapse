namespace synapse
{
    partial class frm_BemVindo
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BemVindo));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cadastrarse = new Guna.UI2.WinForms.Guna2Button();
            this.pic_logo02 = new System.Windows.Forms.PictureBox();
            this.pic_logo01 = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.pic_logo01);
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(450, 30);
            this.pnl_top.TabIndex = 4;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_minimize.Location = new System.Drawing.Point(371, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(50, 30);
            this.btn_minimize.TabIndex = 5;
            this.btn_minimize.Text = "___";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(420, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BorderColor = System.Drawing.Color.Transparent;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.Black;
            this.btn_login.Location = new System.Drawing.Point(100, 395);
            this.btn_login.Name = "btn_login";
            this.btn_login.PressedColor = System.Drawing.Color.Empty;
            this.btn_login.PressedDepth = 0;
            this.btn_login.ShadowDecoration.BorderRadius = 0;
            this.btn_login.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.btn_login.ShadowDecoration.Depth = 0;
            this.btn_login.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btn_login.Size = new System.Drawing.Size(250, 50);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "Entrar";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_login_MouseDown);
            this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
            this.btn_login.MouseHover += new System.EventHandler(this.btn_login_MouseHover);
            this.btn_login.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_login_MouseUp);
            // 
            // btn_cadastrarse
            // 
            this.btn_cadastrarse.BorderColor = System.Drawing.Color.Transparent;
            this.btn_cadastrarse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrarse.ForeColor = System.Drawing.Color.Black;
            this.btn_cadastrarse.Location = new System.Drawing.Point(100, 481);
            this.btn_cadastrarse.Name = "btn_cadastrarse";
            this.btn_cadastrarse.PressedColor = System.Drawing.Color.Empty;
            this.btn_cadastrarse.PressedDepth = 0;
            this.btn_cadastrarse.ShadowDecoration.BorderRadius = 0;
            this.btn_cadastrarse.ShadowDecoration.Color = System.Drawing.Color.Empty;
            this.btn_cadastrarse.ShadowDecoration.CustomizableEdges.BottomLeft = false;
            this.btn_cadastrarse.ShadowDecoration.CustomizableEdges.BottomRight = false;
            this.btn_cadastrarse.ShadowDecoration.CustomizableEdges.TopLeft = false;
            this.btn_cadastrarse.ShadowDecoration.CustomizableEdges.TopRight = false;
            this.btn_cadastrarse.ShadowDecoration.Depth = 0;
            this.btn_cadastrarse.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btn_cadastrarse.Size = new System.Drawing.Size(250, 50);
            this.btn_cadastrarse.TabIndex = 23;
            this.btn_cadastrarse.Text = "Cadastrar-se";
            this.btn_cadastrarse.Click += new System.EventHandler(this.btn_cadastrarse_Click);
            this.btn_cadastrarse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cadastrarse_MouseDown);
            this.btn_cadastrarse.MouseLeave += new System.EventHandler(this.btn_cadastrarse_MouseLeave);
            this.btn_cadastrarse.MouseHover += new System.EventHandler(this.btn_cadastrarse_MouseHover);
            // 
            // pic_logo02
            // 
            this.pic_logo02.BackgroundImage = global::synapse.Properties.Resources.logo_04;
            this.pic_logo02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo02.Location = new System.Drawing.Point(133, 30);
            this.pic_logo02.Name = "pic_logo02";
            this.pic_logo02.Size = new System.Drawing.Size(185, 185);
            this.pic_logo02.TabIndex = 21;
            this.pic_logo02.TabStop = false;
            // 
            // pic_logo01
            // 
            this.pic_logo01.BackgroundImage = global::synapse.Properties.Resources.logo_01;
            this.pic_logo01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo01.Location = new System.Drawing.Point(6, 3);
            this.pic_logo01.Name = "pic_logo01";
            this.pic_logo01.Size = new System.Drawing.Size(24, 24);
            this.pic_logo01.TabIndex = 6;
            this.pic_logo01.TabStop = false;
            // 
            // frm_BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 770);
            this.Controls.Add(this.btn_cadastrarse);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pic_logo02);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_BemVindo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BemVindo";
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pic_logo02;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2Button btn_cadastrarse;
        private System.Windows.Forms.PictureBox pic_logo01;
    }
}

