using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Rechner
{
    static class Program
    {
        /// <summary>
        /// Programmname: BMI-Rechner
        /// Autor: Tabea Pieper
        /// 
        /// Dieses Programm dient der Berechnung und Auswertung des BMI-Werts.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
