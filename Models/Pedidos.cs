using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade03.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Lanche { get; set; }
        public string Bebida { get; set; }
        public string Pag { get; set; }
         public string Valor { get; set; }
    }
}