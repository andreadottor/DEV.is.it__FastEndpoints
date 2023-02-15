using FastEndpoints;
using Microsoft.AspNetCore.Mvc;

namespace DEVisIT.DemoFastEndpoints.Products.GetProduct
{
    public class GetProductRequest
    {
        [FromRoute]
        public int Id { get; set; }
    }
}
