using System;
using System.Collections.Generic;

namespace Store.Domain.Entities
{
    public class Produto
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int IdProdutoPai { get; set; }

        public IEnumerable<Image> Images { get; set; }

    }
}
