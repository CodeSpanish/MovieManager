using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace MovieManagerForms
{
    static class Program
    {
        private static Castle.Windsor.IWindsorContainer container;

        static Program()
        {
            container = new WindsorContainer();

        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(container));
        }
    }
}
