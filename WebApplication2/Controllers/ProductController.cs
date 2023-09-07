using Application.Products.Commands;
using Application.Products.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<int> CreateProduct([FromBody] CreateProductCommand command)
        {
            var productId = await _mediator.Send(command);
            // Gérez la réponse (par exemple, renvoyez un code de statut 201 Created avec l'ID du produit créé)
            return productId;
        }

    }
}
