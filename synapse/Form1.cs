using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static synapse.Program;

namespace synapse
{
    public partial class frm_BemVindo : Form
    {
        public bool mouseDown;
        private Point lastLocation; 

        public frm_BemVindo()
        {
            InitializeComponent();

            this.BackColor = Program.Colors.color03;
            pnl_top.BackColor = Program.Colors.color04;

            btn_minimize.BackColor = Program.Colors.color04;
            btn_exit.BackColor = Program.Colors.color04;

            btn_cadastrarse.FillColor = Program.Colors.color00;
            btn_login.FillColor = Program.Colors.color00;

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
            mouseDown = true;           //Bool "mouse clicado" = verdadeira;
            lastLocation = e.Location;  //marcando a posição assim que mouse foi clicado
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)  //se "mouse clicado" = verdeira
            {
                //Atualizando posição do Form tendo em vista a movimentação do mouse
                this.Location = new Point
                    (
                    (this.Location.X - lastLocation.X) + e.X, //movendo até direção X
                    (this.Location.Y - lastLocation.Y) + e.Y  //movendo até direção Y
                    );

                this.Update(); //Atualizando a posição do Form
            }

        }

        private void pnl_top_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        // Trocando as cores dos botões


        private void btn_login_MouseHover(object sender, EventArgs e)
        {
            btn_login.FillColor = Colors.color01;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            frm_Login login = new frm_Login();
            login.Show();
            Hide();

            btn_login.FillColor = Colors.color02;
        }
        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.FillColor = Colors.color00;
        }

        private void btn_login_MouseUp(object sender, MouseEventArgs e)
        {
            btn_login.FillColor = Colors.color00;
        }
        private void btn_login_MouseDown(object sender, MouseEventArgs e)
        {
            btn_login.FillColor = Colors.color02;
        }

        private void btn_cadastrarse_MouseHover(object sender, EventArgs e)
        {
            btn_cadastrarse.FillColor = Colors.color01;
        }

        private void btn_cadastrarse_Click(object sender, EventArgs e)
        {
            frm_Cadastrarse cadastrarse = new frm_Cadastrarse();
            cadastrarse.Show();
            Hide();

            btn_cadastrarse.FillColor = Colors.color02;
        }

        private void btn_cadastrarse_MouseLeave(object sender, EventArgs e)
        {
            btn_cadastrarse.FillColor = Colors.color00;
        }

        private void btn_cadastrarse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cadastrarse.FillColor = Colors.color02;
        }

    }
}
