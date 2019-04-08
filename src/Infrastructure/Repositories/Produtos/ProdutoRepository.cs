using Domain.Entities;
using Domain.Interfaces.Produtos;
using Infrastructure.Repositories.Generic;

namespace Infrastructure.Repositories.Produtos
{
    public class ProdutoRepository : GenericRepository<Produto>, InterfaceProduto
    {
    }
}
