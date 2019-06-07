using System.Collections.Generic;

namespace ExemploSCM.Dao
{
    interface IRepository<T>
    {
        T Recuperar(int id);
        List<T> Listar();
        void Salvar(T obj);
        void Editar(T obj);
        void Remover(T obj);
    }
}
