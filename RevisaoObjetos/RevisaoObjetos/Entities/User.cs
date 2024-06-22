using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoObjetos.Services;

namespace RevisaoObjetos.Entities
{
    public sealed class User : IPadrao
    {
        public int idade { get; set; }
        public int Pk_id { get; set; }
        public string Ds_nome { get; set; }

        public List<Produto> list = new List<Produto>();
        public User()
        {

        }
        public User(int id, string ds_nome, int idade)
        {
            this.Pk_id = id;
            this.Ds_nome = ds_nome;
            this.idade = idade;
        }
        public void AdicionarProduto(Produto produto) {
           list.Add(produto);
        }
        
    }
}
