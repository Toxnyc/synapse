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
    public partial class frm_Cadastrarse : Form
    {

        public bool mouseDown;
        private Point lastLocation;

        public frm_Cadastrarse()
        {
            InitializeComponent();

            this.BackColor = Program.Colors.color03;
            pnl_top.BackColor = Program.Colors.color04;
            btn_exit.BackColor = Program.Colors.color04;
            btn_minimize.BackColor = Program.Colors.color04;

            txt_usuario.FillColor = Program.Colors.color05;
            txt_criarsenha.FillColor = Program.Colors.color05;
            txt_confsenha.FillColor = Program.Colors.color05;
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
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown) //se clicou no panel
            {
                //atualizando a posição do formulário no eixo X e Y com base na movimentação do Mouse
                this.Location = new Point
                (
                (this.Location.X - lastLocation.X) + e.X,  //a diferença da nova localização com a ultima localização   adiciona ao X do aplicativo
                (this.Location.Y - lastLocation.Y) + e.Y   //a diferença da nova localização e antiga localização Y adiciona ao Y do aplicatiovo
                );

                this.Update(); //atualizando
            }
        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void link_voltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_BemVindo bemvindo = new frm_BemVindo();
            bemvindo.Show();
            Hide();
        }
    }
}
