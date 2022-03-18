using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIWebMercadoLivre.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Preco { get; set; }
        public bool Juros { get; set; }
        public string Frete { get; set; }
        public string Resumo { get; set; }
        public string Nicho { get; set; }
        public string SubNicho { get; set; }
        public string Foto { get; set; }
    }
}
