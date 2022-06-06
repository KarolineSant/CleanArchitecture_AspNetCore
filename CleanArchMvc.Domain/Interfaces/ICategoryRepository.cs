using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    interface ICategoryRepository
    {
        // Não tem implementação, são apenas assinatura dos métodos, que serão implementados na classe concreta.
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsyc(int? id);
        Task<Product> GetProductCategoryAsync(int? id);
        Task<Product> Create(Product product);
        Task<Product> Update(Product product);
        Task<Product> Remove(Product product);
    }
}
