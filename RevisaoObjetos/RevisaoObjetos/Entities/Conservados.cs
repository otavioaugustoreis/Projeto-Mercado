using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace RevisaoObjetos.Entities
{
    public sealed class Conservados : Produto
    {
        public DateTime? DataValidade { get; set; }

        public Conservados(int pk_id, string ds_nome, DateTime DataValidade, User  user) : base(pk_id, ds_nome, user)
        {
            this.DataValidade = DataValidade;
        }
        public Conservados()
        {
           
        }

        public override string ToString()
        {
            return base.ToString() + $"Data de vencimento: {DataValidade}";
        }

    }
}
