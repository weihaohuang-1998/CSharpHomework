using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

       public  static Form1 form1 = new Form1(); 
        static void Main()
        {
           
            Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form1);
        }
        
    }
}
