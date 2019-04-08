using System.Collections.Generic;
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Produtos;

namespace Application.Applications
{
    public class AppProduto : InterfaceAppProduto
    {
        InterfaceProduto _InterfaceProduto;
        public AppProduto(InterfaceProduto InterfaceProduto)
        {
            _InterfaceProduto = InterfaceProduto;
        }
      
        public void Adcionar(Produto Objeto)
        {
            _InterfaceProduto.Adcionar(Objeto);
        }

        public void Atualizar(Produto Objeto)
        {
            _InterfaceProduto.Atualizar(Objeto);
        }

        public void Excluir(Produto Objeto)
        {
            _InterfaceProduto.Excluir(Objeto);
        }

        public IList<Produto> Listar()
        {
            return _InterfaceProduto.Listar();
        }

        public Produto ObterPorId(int Id)
        {
            return _InterfaceProduto.ObterPorId(Id);
        }
    }
}
