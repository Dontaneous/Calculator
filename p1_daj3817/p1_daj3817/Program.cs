/*
 * Author:      Dante Jones
 * CLID:        daj3817
 * Class:       CMPS 358
 * Assignment:  Project 1
 * Due Date:    11:55pm / 20 March 2017
 * Description: I am using a windows form in this project to create a calculator.
 * I cerifty that this program was done by myself.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p1_daj3817
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormCalculator());
        }

    }
}
