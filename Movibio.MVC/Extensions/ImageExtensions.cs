using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Movibio.SharedLayer.Utilities.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Movibio.MVC.Extensions
{
    public static class ImageExtensions
    {

        public static async Task<string> ImageUpload(
            string name,
            string folderName,
            IFormFile picFile,
            IWebHostEnvironment env)
        {

            string wwwroot = env.WebRootPath;
            string fileExtension = Path.GetExtension(picFile.FileName);
            DateTime dateTime = DateTime.Now;
            string fileName = $"{name}_" +
                $"{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            var path = Path.Combine($"{wwwroot}/images/{folderName}", fileName);

            await using (var stream = new FileStream(path, FileMode.Create))
            {
                await picFile.CopyToAsync(stream);
            }

            return fileName;
        }

        public static bool ImageDelete(string pictureName, string folderName, IWebHostEnvironment env)
        {
            string wwwroot = env.WebRootPath;
            var fileToDelete = Path.Combine($"{wwwroot}/images/{folderName}", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                System.IO.File.Delete(fileToDelete);
                return true;
            }
            return false;
        }
    }
}
