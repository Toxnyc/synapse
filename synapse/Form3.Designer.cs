﻿namespace synapse
{
    partial class frm_Cadastrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastrarse));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pic_logo01 = new System.Windows.Forms.PictureBox();
            this.pic_logo02 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_criarsenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.link_voltar = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confsenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo02)).BeginInit();
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
            this.pnl_top.TabIndex = 16;
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
            // pic_logo01
            // 
            this.pic_logo01.BackgroundImage = global::synapse.Properties.Resources.logo_01;
            this.pic_logo01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo01.Location = new System.Drawing.Point(4, 3);
            this.pic_logo01.Name = "pic_logo01";
            this.pic_logo01.Size = new System.Drawing.Size(24, 24);
            this.pic_logo01.TabIndex = 24;
            this.pic_logo01.TabStop = false;
            // 
            // pic_logo02
            // 
            this.pic_logo02.BackgroundImage = global::synapse.Properties.Resources.logo_04;
            this.pic_logo02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo02.Location = new System.Drawing.Point(133, 30);
            this.pic_logo02.Name = "pic_logo02";
            this.pic_logo02.Size = new System.Drawing.Size(185, 185);
            this.pic_logo02.TabIndex = 25;
            this.pic_logo02.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Criar Senha";
            // 
            // txt_criarsenha
            // 
            this.txt_criarsenha.BorderThickness = 0;
            this.txt_criarsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_criarsenha.DefaultText = "";
            this.txt_criarsenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_criarsenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_criarsenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_criarsenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_criarsenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_criarsenha.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.txt_criarsenha.ForeColor = System.Drawing.Color.White;
            this.txt_criarsenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_criarsenha.Location = new System.Drawing.Point(80, 405);
            this.txt_criarsenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_criarsenha.MaxLength = 10;
            this.txt_criarsenha.Name = "txt_criarsenha";
            this.txt_criarsenha.PasswordChar = '\0';
            this.txt_criarsenha.PlaceholderText = "";
            this.txt_criarsenha.SelectedText = "";
            this.txt_criarsenha.Size = new System.Drawing.Size(290, 44);
            this.txt_criarsenha.TabIndex = 32;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BorderThickness = 0;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.DefaultText = "";
            this.txt_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.txt_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Location = new System.Drawing.Point(80, 284);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_usuario.MaxLength = 10;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.PlaceholderText = "";
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.Size = new System.Drawing.Size(290, 44);
            this.txt_usuario.TabIndex = 31;
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.White;
            this.lbl_nome.Location = new System.Drawing.Point(77, 253);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(54, 29);
            this.lbl_nome.TabIndex = 30;
            this.lbl_nome.Text = "Nome";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = global::synapse.Properties.Resources.btn_cadastrar01;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(290, 47);
            this.guna2ImageButton1.Image = global::synapse.Properties.Resources.btn_cadastrar00;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(290, 47);
            this.guna2ImageButton1.Location = new System.Drawing.Point(80, 674);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.Image = global::synapse.Properties.Resources.btn_cadastrar02;
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(290, 47);
            this.guna2ImageButton1.Size = new System.Drawing.Size(290, 47);
            this.guna2ImageButton1.TabIndex = 35;
            // 
            // link_voltar
            // 
            this.link_voltar.ActiveLinkColor = System.Drawing.Color.White;
            this.link_voltar.AutoSize = true;
            this.link_voltar.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_voltar.LinkColor = System.Drawing.Color.White;
            this.link_voltar.Location = new System.Drawing.Point(196, 731);
            this.link_voltar.Name = "link_voltar";
            this.link_voltar.Size = new System.Drawing.Size(59, 23);
            this.link_voltar.TabIndex = 34;
            this.link_voltar.TabStop = true;
            this.link_voltar.Text = "voltar";
            this.link_voltar.VisitedLinkColor = System.Drawing.Color.White;
            this.link_voltar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_voltar_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 37;
            this.label2.Text = "Confirmar Senha";
            // 
            // txt_confsenha
            // 
            this.txt_confsenha.BorderThickness = 0;
            this.txt_confsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confsenha.DefaultText = "";
            this.txt_confsenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confsenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confsenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confsenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confsenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confsenha.Font = new System.Drawing.Font("Corbel", 15.75F);
            this.txt_confsenha.ForeColor = System.Drawing.Color.White;
            this.txt_confsenha.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confsenha.Location = new System.Drawing.Point(80, 506);
            this.txt_confsenha.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_confsenha.MaxLength = 10;
            this.txt_confsenha.Name = "txt_confsenha";
            this.txt_confsenha.PasswordChar = '\0';
            this.txt_confsenha.PlaceholderText = "";
            this.txt_confsenha.SelectedText = "";
            this.txt_confsenha.Size = new System.Drawing.Size(290, 44);
            this.txt_confsenha.TabIndex = 36;
            // 
            // frm_Cadastrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 770);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_confsenha);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.link_voltar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_criarsenha);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.pnl_top);
            this.Controls.Add(this.pic_logo02);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Cadastrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrarse";
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pic_logo01;
        private System.Windows.Forms.PictureBox pic_logo02;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_criarsenha;
        private Guna.UI2.WinForms.Guna2TextBox txt_usuario;
        private System.Windows.Forms.Label lbl_nome;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.LinkLabel link_voltar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_confsenha;
    }
}