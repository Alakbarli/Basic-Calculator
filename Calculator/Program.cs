using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
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
            Application.Run(new Calculator());
            
            
            
        }
    }
    public class VerCal
    {
        public int Ver1=0;
        public int Ver2 = 0;
        public string VerOp = " ";
        
        
        public int Operate()
        {
            if (VerOp == "/")
            {
                int result = Ver1 / Ver2;
                return result;
            }
            else if (VerOp == "-")
            {
                int result = Ver1 - Ver2;
                return result;
            }
            else if (VerOp == "*")
            {
                int result = Ver1 * Ver2;
                return result;
            }
            else 
            {
                int result = Ver1 + Ver2;
                return result;
            }
        }
        
    }
}
