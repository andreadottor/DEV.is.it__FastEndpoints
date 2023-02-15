using DEVisIT.DemoFastEndpoints.Models;
using FastEndpoints;

namespace DEVisIT.DemoFastEndpoints.Products.InsertProduct
{
    public class InsertProductEndpoint : Endpoint<InsertProductRequest>
    {
        public override void Configure()
        {
            Post("/api/products");
            AllowAnonymous();
        }

        public override async Task HandleAsync(InsertProductRequest req, CancellationToken ct)
        {
            var product = new Product
            {
                Id = 42,
                Name = req.Name
            };

            await SendAsync(product);
        }
    }
}
