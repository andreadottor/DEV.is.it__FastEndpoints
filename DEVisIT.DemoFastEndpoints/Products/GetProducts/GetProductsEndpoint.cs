using DEVisIT.DemoFastEndpoints.Models;
using FastEndpoints;

namespace DEVisIT.DemoFastEndpoints.Products.GetProducts
{
    public class GetProductsEndpoint : Endpoint<GetProductsRequest>
    {
        public override void Configure()
        {
            Get("/api/products");
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetProductsRequest req, CancellationToken ct)
        {
            var list = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Product
                {
                    Id = i,
                    Name = $"Prodotto {i}"
                });
            }

            await SendAsync(list);
        }
    }
}
