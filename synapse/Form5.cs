using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{
    public partial class Frm_Desk : Form
    {

        public bool mouseDown;
        private Point lastLocation;

        public bool accountExpand = false;
        public bool sidebarExpand = true;

        public Frm_Desk()
        {
            
            InitializeComponent();

            this.BackColor = Program.Colors.color03;
            pnl_top.BackColor = Program.Colors.color04;
            btn_exit.BackColor = Program.Colors.color04;
            btn_maximize.BackColor = Program.Colors.color04;
            btn_minimize.BackColor = Program.Colors.color04;

            pnl_sidebar.BackColor = Program.Colors.color05;
        }

        private void Frm_Desk_Load(object sender, EventArgs e)
        {


        }

        private void pnl_top_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;               //Marca que o botão do mouse foi pressionado.
            lastLocation = e.Location;      //Guarda a posição do mouse quando o clique ocorre
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)  //verifica se o mouse está precionado
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }
        private void pnl_top_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {

            if(sidebarExpand == true)
            {
                sidebarTransition.Start();
            }
            else 
            { 
            if(accountExpand == false)
            {
                container_account.Height += 10;
                if(container_account.Height >= 175)
                {
                    menuTransition.Stop();
                    accountExpand = true;
                }
            }
            else
            {
                container_account.Height -= 10;
                if(container_account.Height <= 45)
                {
                    menuTransition.Stop();
                    accountExpand = false;
                }
            }
            
            }


        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if(accountExpand == false)
            {
                sidebarTransition.Start();
            }
            else
            {
                menuTransition.Start();
                sidebarTransition.Start();
            }   
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

            if(sidebarExpand)
            {
                pnl_sidebar.Width += 10;

                if(pnl_sidebar.Width >= 200)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
                else 
                {
                    pnl_sidebar.Width -= 10;

                    if (pnl_sidebar.Width <= 50)
                    {
                        sidebarExpand = true;
                        sidebarTransition.Stop();
                    }

                }

        }

        private void btn_account00_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

    }
}
