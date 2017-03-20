using lojaComEntity.Entitades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lojaComEntity
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioDao usuarioDao = new UsuarioDao();

            /*Usuario usuario = new Usuario()
            {
                Nome = "Giovanni",
                Senha = "345"
            };
            
             *  manipulador.Salva(usuario);
             */

            Usuario usuario = usuarioDao.BuscaPorId(2);
            usuarioDao.Remove(usuario);
            
            Console.Write("Removeu o usuário ");
            Console.ReadLine();

        }
    }
}
