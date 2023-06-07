using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QRCodeScan.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ZXing.QrCode;
using ZXing.Rendering;
using ZXing;

namespace QRCodeScan.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GenerateCode()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateCode(string qrText)
        {
            byte[] byteArray;

            var pixelData = ConvertTextToPixelData(qrText);

            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            {
                using var ms = new MemoryStream();
                var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                try
                {
                    System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                }
                finally
                {
                    bitmap.UnlockBits(bitmapData);
                }
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byteArray = ms.ToArray();
            }

            return View(byteArray);
        }

        public IActionResult GenerateFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GenerateFile(string qrText)
        {
            byte[] byteArray;

            var pixelData = ConvertTextToPixelData(qrText);

            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppRgb))
            {
                using (var ms = new MemoryStream())
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                    try
                    {
                        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        bitmap.UnlockBits(bitmapData);
                    }

                    string fileGuid = Guid.NewGuid().ToString().Substring(0, 4);
                    bitmap.Save("wwwroot/qrr/file-" + fileGuid + ".png", System.Drawing.Imaging.ImageFormat.Png);

                    bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byteArray = ms.ToArray();
                }
            }

            return View(byteArray);
        }

        public IActionResult ViewFile()
        {
            var fileData = new List<KeyValuePair<string, string>>();
            KeyValuePair<string, string> data;
            var files = Directory.GetFiles("wwwroot/qrr");

            foreach (var file in files)
            {
                var reader = new BarcodeReader();
                var barcodeBitmap = (Bitmap)Image.FromFile("wwwroot/qrr/" + Path.GetFileName(file));
                var result = reader.Decode(barcodeBitmap);
                data = new KeyValuePair<string, string>(result.ToString(), "/qrr/" + Path.GetFileName(file));
                fileData.Add(data);
            }
            return View(fileData);
        }

        private PixelData ConvertTextToPixelData(string qrText)
        {
            var width = 250;
            var height = 250;
            var margin = 0;
            var qrCodeWriter = new BarcodeWriterPixelData
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = margin
                }
            };
            var pixelData = qrCodeWriter.Write(qrText);

            return pixelData;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
