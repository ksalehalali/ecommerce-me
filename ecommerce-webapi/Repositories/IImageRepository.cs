using ecommerce_webapi.Models.Domain;

namespace ecommerce_webapi.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
