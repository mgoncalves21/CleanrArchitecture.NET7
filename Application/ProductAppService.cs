using Application.Products.Commands;
using Application.Products.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ProductAppService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<int> CreateProductAsync(Product product)
        {
            // Ajoutez ici la logique pour créer le produit
            await _productRepository.AddAsync(product);
            return product.Id;
        }

        // Implémentez d'autres méthodes de service ici
    }

}
