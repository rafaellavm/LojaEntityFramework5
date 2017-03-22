using lojaComEntity.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    public class ProdutoDAO
    {
        private EntidadesContext contexto;

        public ProdutoDAO(EntidadesContext contexto)
        {
            this.contexto = contexto;
        }

        public IList<Produto> BuscaPorNomePrecoNomeCategoria(string nome, decimal preco, string nomeCategoria)
        {
            var busca = from p in contexto.Produtos select p;

            if (!string.IsNullOrEmpty(nome))
            {
                busca = busca.Where(p => p.Nome == nome);
                        
            }

            if (preco > 0)
            {
                busca = busca.Where(p => p.Preco == preco);
                        
            }

            if (!string.IsNullOrEmpty(nomeCategoria))
            {
                busca = busca.Where(p => p.Categoria.Nome == nomeCategoria);
                        
            }

            return busca.ToList();
        }
    }
}
