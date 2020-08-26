using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Shop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        Task<List<ProductViewModel>> GetAll();
    }
}
