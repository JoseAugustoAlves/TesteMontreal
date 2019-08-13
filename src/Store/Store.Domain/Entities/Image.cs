using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public virtual int ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
