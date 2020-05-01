using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_again
{
    class Default
    {
        public static Boolean Defu (int x )
        {
            int[] white = { 0, 2, 4, 6, 9, 11, 13, 15, 16, 18, 20, 22, 25, 27, 29, 31, 32, 34, 36, 38, 41, 43, 45, 47, 48, 50, 52, 54, 57, 59, 61, 63 };
            for (int i = 0; i <= white.Length - 1; i++)
            {
                if (x == white[i])
                {
                    return true;
                }
               
            
            }
                return false; 
        }
    }
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
