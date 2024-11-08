using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class frm_Redefinir : Form
    {

        public bool mouseDown;
        private Point lastLocation;

        public frm_Redefinir()
        {
            InitializeComponent();

            this.BackColor = Program.Colors.color03;
            pnl_top.BackColor = Program.Colors.color04;
            btn_exit.BackColor = Program.Colors.color04;
            btn_minimize.BackColor = Program.Colors.color04;

            txt_usuario.FillColor = Program.Colors.color05;
            txt_redsenha.FillColor = Program.Colors.color05;
            txt_confredsenha.FillColor = Program.Colors.color05;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Atualiza a posição do formulário com base no deslocamento do mouse
                this.Location = new Point
                    (
                    (this.Location.X - lastLocation.X) + e.X, //Deslocamento na direção X
                    (this.Location.Y - lastLocation.Y) + e.Y  //Deslocamento na direção Y
                    );

                this.Update();//Atualiza a tela do formulário (forçando redesenho, se necessário);
            }
        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void link_voltar_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_BemVindo bemvindo = new frm_BemVindo();
            bemvindo.Show();
            Hide();
        }
    }
}
