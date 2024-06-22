using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoObjetos.Services
{
    public interface ICRUD<T>
    {
        T inserir(T t);
        void excluir(T t);
        T alterar(T t);
    }
}
