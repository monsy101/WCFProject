using Grpc.Core;
using GrpcService;

public class ProductServiceImplementation : ProductsService.ProductsServiceBase
{
    public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ProductResponse
        {
            ProductDetails = $"Details for Product ID: {request.ProductId}"
        });
    }
}