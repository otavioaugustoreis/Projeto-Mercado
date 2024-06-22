using RevisaoObjetos.Entities;
using RevisaoObjetos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Domain
{
    public sealed class UserService : ICRUD<User>
    {
        public User alterar(User entidade)
        {
            return new User();
        }

        public void excluir(User entidade)
        {
           
        }

        public User inserir(User entidade)
        {
            return new User(); 
        }
    }
}
