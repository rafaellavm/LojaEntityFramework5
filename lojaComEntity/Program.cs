using lojaComEntity.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            #region antigo

            //UsuarioDao usuarioDao = new UsuarioDao();

            /*Usuario usuario = new Usuario()
            {
                Nome = "Giovanni",
                Senha = "345"
            };
            
             *  manipulador.Salva(usuario);
             */

            //Usuario usuario = usuarioDao.BuscaPorId(2);
            //usuarioDao.Remove(usuario);

            #endregion

            EntidadesContext contexto = new EntidadesContext();

            /*//Categoria c = new Categoria()
            //{
             //   Nome =  "Informática"
            //};

            //contexto.Categorias.Add(c);
            //contexto.SaveChanges();

            Produto p = new Produto()
            {
                Nome = "Teclado",
                Preco = 10,
                CategoriaID = 1
            };

            contexto.Produtos.Add(p);
            contexto.SaveChanges(); */

            /*Produto p = contexto.Produtos.Include(produto => produto.Categoria).FirstOrDefault();


            //Console.Write("produto = ", p.Nome.ToString());
            Console.Write(p.Categoria.Nome);
            Console.ReadLine(); */

            //Include : inclui os produtos
            /*var categoria = contexto.Categorias.Include(c => c.produtos).FirstOrDefault(c => c.ID == 1);

            foreach (var p in categoria.produtos)
            {
                Console.WriteLine(p.Nome);
            } */

            /*decimal precoMinimo = 40;
            var busca = from p in contexto.Produtos
                        where p.Categoria.Nome == "Roupas" && p.Preco > precoMinimo
                        orderby p.Preco
                        select p;
            IList<Produto> resultado = busca.ToList();

            foreach (var p in resultado)
            {
                Console.WriteLine(p.Nome + " - " + p.Preco);
            } */

            /*ProdutoDAO produtodao = new ProdutoDAO(contexto);

            var resultado = produtodao.BuscaPorNomePrecoNomeCategoria(null,0, "Roupas");


            foreach (var p in resultado)
            {
                Console.WriteLine(p.Nome);
            }*/

            /*UsuarioDao usuariodao = new UsuarioDao();
            Usuario rafaela = usuariodao.BuscaPorId(1);

            Venda v = new Venda()
            {
                cliente = rafaela
            };
            
            Produto produto = contexto.Produtos.FirstOrDefault(p => p.ID == 1);
            Produto produto2 = contexto.Produtos.FirstOrDefault(p => p.ID == 2);

            ProdutoVenda pv = new ProdutoVenda()
            {
                Venda = v,
                Produto = produto
            };

            ProdutoVenda pv2 = new ProdutoVenda()
            {
                Venda = v,
                Produto = produto2
            };

            contexto.Vendas.Add(v);
            contexto.ProdutoVenda.Add(pv);
            contexto.ProdutoVenda.Add(pv2);

            contexto.SaveChanges(); */

            Venda v = contexto.Vendas.Include(vp => vp.ProdutoVenda).FirstOrDefault(v2 => v2.ID == 1);

            foreach (var pv in v.ProdutoVenda)
            {
                Console.WriteLine(pv.Produto.Nome);
            }

            Console.ReadLine(); 

        }
    }
}
