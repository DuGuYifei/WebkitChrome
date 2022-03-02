using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebkitChrome
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length == 0)
            {
                //args = new string[] { "dicegame.xyz" };
                args = new string[] { "E:\\Download\\Wallpaper\\html\\example\\ripples\\index.html" };
                //args = new string[] { "E:\\图片\\大圣归来\\1.jpg" };
                //args = new string[] { "E:\\Gdansk University of Technology\\first semester\\Hypertext and Hypermadia\\Project\\Project1\\HTML\\MyHobby.html" };
            }
            Application.Run(new WebkitChromeForm(args[0]));
        }
    }
}
