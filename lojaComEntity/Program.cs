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

            decimal precoMinimo = 40;
            var busca = from p in contexto.Produtos
                        where p.Categoria.Nome == "Roupas" && p.Preco > precoMinimo
                        orderby p.Preco
                        select p;
            IList<Produto> resultado = busca.ToList();

            foreach (var p in resultado)
            {
                Console.WriteLine(p.Nome + " - " + p.Preco);
            }

            Console.ReadLine(); 

        }
    }
}
