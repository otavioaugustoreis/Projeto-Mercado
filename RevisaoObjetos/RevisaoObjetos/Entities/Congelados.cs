using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Entities
{
    public sealed class Congelados : Produto
    {
        public Congelados()
        {

        }
        public Congelados(int pk_id, string ds_nome, User user) : base(pk_id, ds_nome, user) 
        {
            
        }
    }
}
