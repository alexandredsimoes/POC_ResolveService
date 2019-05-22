using System;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Autofac;
using Autofac.Core;
using POC_ResolveService.Modelos;
using POC_ResolveService.Servicos;

namespace POC_ResolveService
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Registrar();

            XmlSerializer serializer = new XmlSerializer(typeof(SisMsg));

            foreach (var fileName in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.xml"))
            {
                using var file =
                    File.OpenRead(fileName);
                using var reader = new StreamReader(file);
                SisMsg objeto = serializer.Deserialize(reader) as SisMsg;

                string serviceName = null;
                if (objeto.STR0007 != null) serviceName = "Str0007";
                if (objeto.STR0008 != null) serviceName = "Str0008";
                var service = container
                    .ResolveNamed<IProcessaStr>(serviceName, new NamedPropertyParameter("Arquivo", objeto));
                service.ProcessarArquivo();

            }
            Console.ReadLine();
        }

        private static IContainer Registrar()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ProcessaStr0007>()
                .Named<IProcessaStr>("Str0007")
                .PropertiesAutowired();
            builder.RegisterType<ProcessaStr0008>()
                .Named<IProcessaStr>("Str0008")
                .PropertiesAutowired();

            var container = builder.Build();
            return container;
        }
    }
}
