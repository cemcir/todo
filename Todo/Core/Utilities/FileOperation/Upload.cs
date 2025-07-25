using Core.Entities.Concrete;
using Core.Utilities.Business;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Core.Utilities.FileOperation
{
    public class Upload
    {
        public static string ImageUpload(IFormFile? image,string entity)
        {
            if (image != null && image.Length > 0) { // resim varsa ve boyutu sıfırdan büyük ise

                var fileName=Path.GetFileName(image.FileName);
                var uploadPath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images/"+entity);

                if (!Directory.Exists(uploadPath)) { // klasör yoksa oluştur
                    Directory.CreateDirectory(uploadPath);
                }
                
                fileName = $"{Guid.NewGuid()}-{fileName}";

                var filePath=Path.Combine(uploadPath,fileName); // dosya adını path e kopyala

                using(var stream=new FileStream(filePath,FileMode.Create))
                {
                    image.CopyTo(stream); 
                }

                return $"images/{entity}/{fileName}";
            }
            return null;
        }

        public static void ImageDelete(IWebHostEnvironment env,string? fileName)
        {
            if (fileName != null) {
                var filePath = Path.Combine(env.WebRootPath, fileName); // resim yol değerini root kısmına kopyala
                if (File.Exists(filePath)) { // dosya path değeri varsa
                    File.Delete(filePath); // dosyayı sil
                }
            }
        }
    }
}
