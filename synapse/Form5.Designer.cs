namespace synapse
{
    partial class Frm_Desk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Desk));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_maximize = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pnl_sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_menu = new System.Windows.Forms.Button();
            this.container_account = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_account00 = new System.Windows.Forms.Panel();
            this.btn_account00 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.ResizeFormDesk = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.pic_logo01 = new System.Windows.Forms.PictureBox();
            this.pnl_top.SuspendLayout();
            this.pnl_sidebar.SuspendLayout();
            this.pnl_Menu.SuspendLayout();
            this.container_account.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pnl_account00.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnl_top.Controls.Add(this.pic_logo01);
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Controls.Add(this.btn_maximize);
            this.pnl_top.Controls.Add(this.btn_exit);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(1, 1);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1295, 30);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pnl_top_MouseDoubleClick);
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
            this.btn_minimize.Location = new System.Drawing.Point(1167, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(50, 30);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "___";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_maximize.FlatAppearance.BorderSize = 0;
            this.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_maximize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_maximize.Location = new System.Drawing.Point(1216, 0);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(50, 30);
            this.btn_maximize.TabIndex = 1;
            this.btn_maximize.Text = "[    ]";
            this.btn_maximize.UseVisualStyleBackColor = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_exit.Location = new System.Drawing.Point(1265, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(30, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pnl_sidebar
            // 
            this.pnl_sidebar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_sidebar.Controls.Add(this.pnl_Menu);
            this.pnl_sidebar.Controls.Add(this.container_account);
            this.pnl_sidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_sidebar.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnl_sidebar.Location = new System.Drawing.Point(1246, 31);
            this.pnl_sidebar.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_sidebar.Name = "pnl_sidebar";
            this.pnl_sidebar.Size = new System.Drawing.Size(50, 738);
            this.pnl_sidebar.TabIndex = 1;
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.Controls.Add(this.btn_menu);
            this.pnl_Menu.Location = new System.Drawing.Point(-150, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Size = new System.Drawing.Size(200, 46);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(200, 46);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "MENU MENU MENU MENU MENU";
            this.btn_menu.UseVisualStyleBackColor = false;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // container_account
            // 
            this.container_account.BackColor = System.Drawing.Color.SlateGray;
            this.container_account.Controls.Add(this.panel12);
            this.container_account.Controls.Add(this.panel9);
            this.container_account.Controls.Add(this.panel3);
            this.container_account.Controls.Add(this.panel2);
            this.container_account.Controls.Add(this.pnl_account00);
            this.container_account.Location = new System.Drawing.Point(-150, 46);
            this.container_account.Margin = new System.Windows.Forms.Padding(0);
            this.container_account.Name = "container_account";
            this.container_account.Size = new System.Drawing.Size(200, 45);
            this.container_account.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SlateBlue;
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Location = new System.Drawing.Point(0, 135);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 46);
            this.panel12.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Location = new System.Drawing.Point(0, 46);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 46);
            this.panel13.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel14.Location = new System.Drawing.Point(0, 38);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(200, 46);
            this.panel14.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Turquoise;
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(0, 90);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 46);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(0, 46);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 46);
            this.panel10.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel11.Location = new System.Drawing.Point(0, 38);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(200, 46);
            this.panel11.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(0, 45);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 46);
            this.panel3.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Location = new System.Drawing.Point(0, 46);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 46);
            this.panel5.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel8.Location = new System.Drawing.Point(0, 38);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 46);
            this.panel8.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 176);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 46);
            this.panel2.TabIndex = 1;
            // 
            // pnl_account00
            // 
            this.pnl_account00.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl_account00.Controls.Add(this.btn_account00);
            this.pnl_account00.Controls.Add(this.panel6);
            this.pnl_account00.Location = new System.Drawing.Point(0, -1);
            this.pnl_account00.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_account00.Name = "pnl_account00";
            this.pnl_account00.Size = new System.Drawing.Size(200, 46);
            this.pnl_account00.TabIndex = 2;
            // 
            // btn_account00
            // 
            this.btn_account00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_account00.FlatAppearance.BorderSize = 0;
            this.btn_account00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account00.Location = new System.Drawing.Point(0, 0);
            this.btn_account00.Margin = new System.Windows.Forms.Padding(0);
            this.btn_account00.Name = "btn_account00";
            this.btn_account00.Size = new System.Drawing.Size(200, 46);
            this.btn_account00.TabIndex = 5;
            this.btn_account00.Text = "ACCOUNT";
            this.btn_account00.UseVisualStyleBackColor = true;
            this.btn_account00.Click += new System.EventHandler(this.btn_account00_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(0, 46);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 46);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Location = new System.Drawing.Point(0, 38);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 46);
            this.panel7.TabIndex = 5;
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 5;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 5;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // ResizeFormDesk
            // 
            this.ResizeFormDesk.TargetForm = this;
            // 
            // pic_logo01
            // 
            this.pic_logo01.BackgroundImage = global::synapse.Properties.Resources.logo_01;
            this.pic_logo01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_logo01.Location = new System.Drawing.Point(4, 3);
            this.pic_logo01.Name = "pic_logo01";
            this.pic_logo01.Size = new System.Drawing.Size(24, 24);
            this.pic_logo01.TabIndex = 26;
            this.pic_logo01.TabStop = false;
            // 
            // Frm_Desk
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1300, 770);
            this.Controls.Add(this.pnl_sidebar);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Desk";
            this.Padding = new System.Windows.Forms.Padding(1, 1, 4, 1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Frm_Desk_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_sidebar.ResumeLayout(false);
            this.pnl_Menu.ResumeLayout(false);
            this.container_account.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pnl_account00.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_maximize;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.FlowLayoutPanel pnl_sidebar;
        private System.Windows.Forms.Panel container_account;
        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnl_account00;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Button btn_account00;
        private Guna.UI2.WinForms.Guna2ResizeForm ResizeFormDesk;
        private System.Windows.Forms.PictureBox pic_logo01;
    }
}