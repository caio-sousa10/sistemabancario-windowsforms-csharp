using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario01
{
    public class Endereco
    {
        // propriedades e encapsulamento de propriedades (não permitir acesso não autorizado)

        private string Rua { get; set; }
        private string Numero { get; set; }
        private string Cidade { get; set; }
        private string Estado { get; set; }
    }
}
