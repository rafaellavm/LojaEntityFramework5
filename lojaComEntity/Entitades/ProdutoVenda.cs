using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity.Entitades
{
    public class ProdutoVenda
    {
        public int VendaID { get; set; }
        public int ProdutoID { get; set; }
        
        //virtual: são um relacionamento
        public virtual Venda Venda { get; set; }
        public virtual Produto Produto { get; set; }

        //a chave primária do ProdutoVenda é a junção dos ids da venda e do produto, chave composta distintas. 
    }
}
