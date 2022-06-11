using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checker_Source_Code
{
    static class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Console.Title = "Checker'ın Adını Giriniz.";
            Utils.Runner();
            Console.ReadKey();
        }


    }
}
