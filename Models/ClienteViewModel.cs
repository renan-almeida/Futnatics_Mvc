using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FutnaticsMvc.Models
{
    public class ClienteViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Cpf { get; set; }
        public int Rg { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }
}