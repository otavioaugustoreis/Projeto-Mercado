using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Entities
{
    public sealed class Bebidas : Produto  
    {
        public Bebidas() { }

        public Bebidas(int id, string nome, User user) : base(id, nome, user)
        {
                
        }
    }
}
