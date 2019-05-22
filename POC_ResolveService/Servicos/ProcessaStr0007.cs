using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac.Core;
using POC_ResolveService.Modelos;

namespace POC_ResolveService.Servicos
{
    public class ProcessaStr0007 : IProcessaStr
    {
        public SisMsg Arquivo { get; set; }
        public void ProcessarArquivo()
        {
            Console.WriteLine($"Processando arquivo {nameof(ProcessaStr0007)} { Arquivo.STR0007}");
        }
    }
}
