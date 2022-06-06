using CleanArchMvc.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        // Não tem implementação, são apenas assinatura dos métodos, que serão implementados na classe concreta.
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> GetById(int? id);
        Task<Category> Create(Category category);
        Task<Category> Update(Category category);
        Task<Category> Remove(Category category);

    }
}
