using Autofac;
using CostHub.Infrastructure.Ioc;
using CostHub.WinForms.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostHub.WinForms
{
    static class Program
    {
        private static IContainer Container { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ContainerBuilder();
            builder.RegisterModule(new ContainerModule());
            builder.RegisterModule(new WinFormsModule());
            Container = builder.Build();

            using (var scope = Container.BeginLifetimeScope())
            {
                var form = scope.Resolve<MainForm>();
                Application.Run(form);
            }
        }
    }
}
