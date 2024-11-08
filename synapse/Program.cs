using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace synapse
{

    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Desk());
        }

        public static class Colors
        {
            public static Color color00 = Color.FromArgb(255, 173, 92);
            public static Color color01 = Color.FromArgb(255, 186, 117);
            public static Color color02 = Color.FromArgb(245, 149, 56);


            public static Color color03 = Color.FromArgb(13, 13, 13);
            public static Color color04 = Color.FromArgb(25, 25, 25);
            public static Color color05 = Color.FromArgb(68, 70, 77);
        }

    }
}
