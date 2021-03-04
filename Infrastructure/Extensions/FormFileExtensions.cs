using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace PROJECT.Infrastructure.Extensions
{
    public static class FormFileExtensions
    {
        public static async Task<byte[]> GetBytes(this IFormFile formFile)
        {
            using MemoryStream memoryStream = new();
            await formFile.CopyToAsync(memoryStream);
            return memoryStream.ToArray();
        }
    }
}
