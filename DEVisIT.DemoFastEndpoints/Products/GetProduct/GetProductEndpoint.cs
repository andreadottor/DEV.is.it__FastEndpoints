using DEVisIT.DemoFastEndpoints.Models;
using FastEndpoints;

namespace DEVisIT.DemoFastEndpoints.Products.GetProduct
{
    public class GetProductEndpoint : Endpoint<GetProductRequest>
    {
        public override void Configure()
        {
            Get("/api/products/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetProductRequest req, CancellationToken ct)
        {
            var product = new Product
            {
                Id = req.Id,
                Name = $"Prodotto {req.Id}"
            };

            await SendAsync(product);
        }
    }
}
