using System.Collections.Generic;

namespace Domain.Interfaces.Gemeric
{
    public interface GenericInterface<T> where T : class
    {
        void Adcionar(T Objeto);

        void Atualizar(T Objeto);

        void Excluir(T Objeto);

        T ObterPorId(int Id);

        IList<T> Listar();
    }
}
