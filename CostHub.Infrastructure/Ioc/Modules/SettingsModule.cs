using Autofac;
using CostHub.Persistence.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostHub.Infrastructure.Ioc.Modules
{
    public class SettingsModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var sqlSettings = new SqlSettings("CostHub01", "(localdb)\\MSSQLLocalDB");
            builder.RegisterInstance(sqlSettings).SingleInstance();

        }
    }
}
