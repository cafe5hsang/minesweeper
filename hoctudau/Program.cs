/**
 * author: Trần Minh Thành; MSSV: 15110313
 * start: 12/12/2016
 * complete: 13/12/2016
 * 
 * Data struct and algorithms
 * Project: Game mineweeper 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper_DataStructAndAlgorithms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
