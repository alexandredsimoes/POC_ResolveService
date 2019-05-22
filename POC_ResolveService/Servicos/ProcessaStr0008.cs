using POC_ResolveService.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC_ResolveService.Servicos
{
    public class ProcessaStr0008 : IProcessaStr
    {
        public SisMsg Arquivo { get; set; }
        public void ProcessarArquivo()
        {
            Console.WriteLine($"Processando arquivo {nameof(ProcessaStr0008)} { Arquivo.STR0008}");
        }
    }
}
