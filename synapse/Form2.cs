using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class frm_Login : Form
    {

        public bool mouseDown;
        private Point lastLocation;

        public frm_Login()
        {
            InitializeComponent();

            this.BackColor = Program.Colors.color03;
            pnl_top.BackColor = Program.Colors.color04;
            btn_exit.BackColor = Program.Colors.color04;
            btn_minimize.BackColor = Program.Colors.color04;

            txt_usuario.FillColor = Program.Colors.color05;

            txt_senha.FillColor = Program.Colors.color05;

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
            mouseDown = true;               //Mouse clicando em cima = verdadeiro
            lastLocation = e.Location;      //Armazenando a posição do mouse quando clico
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {

                //Atualizando a posição levando em conta o deslocamento do mouse
                this.Location = new Point
                    (
                    (this.Location.X - lastLocation.X) + e.X,  //indo na direção horizontal
                    (this.Location.Y - lastLocation.Y) + e.Y   //indo na direção vertical
                    );

                    this.Update(); //Atualizando

            }
        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }




        private void lbl_redefinirsenha_Click(object sender, EventArgs e)
        {
            frm_Redefinir redefinir = new frm_Redefinir();
            redefinir.Show();
            Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Frm_Desk desk = new Frm_Desk();
            desk.Show();
            Hide();
        }

        private void link_voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_BemVindo bemvindo = new frm_BemVindo();
            bemvindo.Show();
            Hide();
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            Frm_Desk desk = new Frm_Desk();
            desk.Show();
            Hide();
        }
    }
}
