using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entitades
{
    public class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }

        //uma categoria tem vários produtos
        public IList<Produto> produtos { get; set; }
    }
}
