using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        static string _basePath = Directory.GetCurrentDirectory() + "/wwwroot/";
        static string _folder = "images/";


        public static string Upload(IFormFile file)
        {
            if (!Directory.Exists(_basePath + _folder)) Directory.CreateDirectory(_basePath + _folder);

            string extension = Path.GetExtension(file.FileName);
            CheckImage(extension);

            string imagePath = _folder + Guid.NewGuid().ToString() + extension;

            using (FileStream fileStream = File.Create(_basePath + imagePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
                return imagePath;
            }
        }

        public static string Update(string oldImagePath, IFormFile file)
        {
            Delete(oldImagePath);
            return Upload(file);
        }

        public static void Delete(string imagePath)
        {
            File.Delete(_basePath + imagePath);
        }

        private static void CheckImage(string extension)
        {
            var extensions = new List<string> { ".jpg", ".png", "jpeg" };

            if (!extensions.Contains(extension))
                throw new Exception();
        }
    }
}
