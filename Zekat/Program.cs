using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zekat
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmbeddedAssembly.Load("Zekat.HtmlAgilityPack.dll", "HtmlAgilityPack.dll");
            EmbeddedAssembly.Load("Zekat.Newtonsoft.Json.dll", "Newtonsoft.Json.dll");
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(CurrentDomain_AssemblyResolve);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Zekat());
        }
        static System.Reflection.Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            return EmbeddedAssembly.Get(args.Name);
        }
    }
}
