using Application.Products.Commands;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Products.Interfaces
{
    public interface IProductService
    {
        Task<int> CreateProductAsync(Product product);

    }
}
