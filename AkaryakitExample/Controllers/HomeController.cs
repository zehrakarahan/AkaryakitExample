using AkaryakitExample.Helpers;
using AkaryakitExample.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace AkaryakitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            string[] zipFiles =
                Directory.GetFiles(
                 Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ @"\dosyalar"), "*.zip");
            var zipFileNames = zipFiles.Select(Path.GetFileName).ToArray();
            string extractPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "extract");
            string zipPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\dosyalar");
            foreach (var zipFile in zipFileNames)
            {
                var path3 = extractPath + @"\" + zipFile.Split(".")[0];
                if (!Directory.Exists(extractPath + @"\" + zipFile.Split(".")[0]))
                {
                    Directory.CreateDirectory(extractPath + @"\" + zipFile.Split(".")[0]);
                }
                if (!System.IO.File.Exists(extractPath + @"\" + zipFile.Split(".")[0] + @"\" + zipFile.Split(".")[0] + ".xml"))
                {
                    ZipFile.ExtractToDirectory(zipPath + @"\" + zipFile.Split(".")[0] + ".zip", extractPath+@"\" + zipFile.Split(".")[0]);
                }
                ParseHelpers parseHelpers = new ParseHelpers();
               
                var sonuc = parseHelpers.DeserializeXml<SaleData>(extractPath + @"\" + zipFile.Split(".")[0] + @"\" + zipFile.Split(".")[0] + ".xml");
            }
          
            return Ok();
        }
        [HttpGet("ResimOku")]
        public IActionResult ResimOku()
        {
            return Ok();
        }
    }
}
