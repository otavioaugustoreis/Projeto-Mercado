using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Entities
{
    public sealed class Alimento : Produto
    {
        public Alimento() { }

        public Alimento(int id, string nome, User user) : base(id, nome, user) {  
        }
    }
}
