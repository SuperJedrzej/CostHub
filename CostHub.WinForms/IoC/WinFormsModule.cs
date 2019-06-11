using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using System.Windows.Forms;
using System.Reflection;

namespace CostHub.WinForms.IoC
{
    public class WinFormsModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assembly = typeof(WinFormsModule)
                    .GetTypeInfo()
                    .Assembly;

            builder.RegisterAssemblyTypes(assembly)
                .Where(x => x.IsAssignableTo<Form>())
                .InstancePerLifetimeScope();
        }
    }
}
