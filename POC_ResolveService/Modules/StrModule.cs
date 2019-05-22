using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using POC_ResolveService.Servicos;

namespace POC_ResolveService.Modules
{
    public class StrModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProcessaStr0007>()
                .As<IProcessaStr>();


        }
    }
}
