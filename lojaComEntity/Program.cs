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
            EntidadesContext contexto = new EntidadesContext();

            Usuario usuario = new Usuario()
            {
                Nome = "Rafaela",
                Senha = "123"
            };

            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            contexto.Dispose();
        }
    }
}
