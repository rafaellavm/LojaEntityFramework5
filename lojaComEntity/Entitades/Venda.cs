using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entitades
{
    public class Venda
    {
        public int ID { get; set; }
        public virtual Usuario cliente { get; set; }

        //criando chave estrangeira
        public int ClientID { get; set; }

        //relacionamento de muitos para muitos, a partir do Entity 6 tem que ser feito dessa maneira
        public virtual IList<ProdutoVenda> ProdutoVenda { get; set; }
    }
}
