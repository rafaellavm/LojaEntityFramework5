using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entitades
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        
        //navigation properties: eu consigo navegar pelo relacionamento. Sempre tem que ser VIRTUAL porque o Entity reescrevê-la
        public virtual Categoria Categoria { get; set; }

        //pra fazer a ligação
        public int CategoriaID { get; set; }

        //relacionamento de muitos para muitos, a partir do Entity 6 tem que ser feito dessa maneira
        public virtual IList<ProdutoVenda> ProdutoVenda { get; set; }

    }
}
