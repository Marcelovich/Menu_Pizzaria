using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static string cliente;

        public static double pizza;
        public static string pizzaSelecionada;

        public static double borda;
        public static string bordaSelecionada;

        public static double bebida;
        public static string bebidaSelecionada;

        public static double suco;
        public static string sucoSelecionado;

        public static double totalFatura;

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new f());
        }
    }
}
