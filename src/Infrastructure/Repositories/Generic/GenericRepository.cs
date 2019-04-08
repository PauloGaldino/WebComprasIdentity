using Domain.Interfaces.Gemeric;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositories.Generic
{
    public class GenericRepository<T> : GenericInterface<T>, IDisposable where T : class
    {
        private readonly DbContextOptions<AppDbContext> _OptionsBuilder;
        public GenericRepository()
        {
            _OptionsBuilder = new DbContextOptions<AppDbContext>();
        }

        public void Adcionar(T Objeto)
        {
            using (var banco = new AppDbContext(_OptionsBuilder))
            {
                banco.Set<T>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public void Atualizar(T Objeto)
        {
            using (var banco = new AppDbContext(_OptionsBuilder))
            {
                banco.Set<T>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(T Objeto)
        {
            using (var banco = new AppDbContext(_OptionsBuilder))
            {
                banco.Set<T>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<T> Listar()
        {
            using (var banco = new AppDbContext(_OptionsBuilder))
            {
                return banco.Set<T>().AsNoTracking().ToList();

            }
        }

        public T ObterPorId(int Id)
        {
            using (var banco = new AppDbContext(_OptionsBuilder))
            {
                return banco.Set<T>().Find(Id);
            }
        }


        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }

    }
}
