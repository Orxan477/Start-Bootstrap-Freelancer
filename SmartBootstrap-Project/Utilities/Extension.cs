using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace SmartBootstrap_Project.Utilities
{
    public static class Extension
    {
        public static bool CheckSize(this IFormFile file,int size)
        {
            return file.Length / 1024 > size;
        }
        public static bool CheckType(this IFormFile file,string type)
        {
            return file.ContentType.Contains(type);
        }
        public async static Task<string> SaveFileAsync(this IFormFile photo,string root,string folder)
        {
            string fileName = Guid.NewGuid().ToString() + "img" + photo.FileName;
            string rootPath = Path.Combine(root, folder, fileName);
            using (FileStream fileStream = new FileStream(rootPath, FileMode.Create))
            {
                await photo.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
