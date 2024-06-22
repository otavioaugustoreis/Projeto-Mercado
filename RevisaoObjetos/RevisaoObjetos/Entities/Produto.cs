using RevisaoObjetos.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Entities
{
    public abstract class Produto : IPadrao
    {
        public int Pk_id { get; set ; }
        public string Ds_nome {  get ; set; }

        public User _User { get; set; }
        public Produto()
        {
                
        }

        public Produto(int Pk_id, string Ds_nome, User user)
        {
            this.Pk_id = Pk_id;
            this.Ds_nome = Ds_nome;
            this._User = user;
        }

        public override string ToString()
        {
            return $"Produto: [id: {Pk_id},  nome: {Ds_nome}";        
        }
    }
}
