using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Microsoft.AspNetCore.Razor.TagHelpers;
using ZXing.QrCode;

namespace ICFERApp.Models
{
    [HtmlTargetElement("qrcode")]
    public class QRCodeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var content = context.AllAttributes["content"].Value.ToString();
            var width = int.Parse(context.AllAttributes["width"].Value.ToString());
            var height = int.Parse(context.AllAttributes["height"].Value.ToString());
            
            var barcodeWriterPixelData = new ZXing.BarcodeWriterPixelData
            {
                Format = ZXing.BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Height = height,
                    Width = width,
                    Margin = 0
                }
            };

            var pixelData = barcodeWriterPixelData.Write(content);

            using (var bitmap = new Bitmap(pixelData.Width, pixelData.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb))
            {

                using (var memoryStream = new MemoryStream())
                {
                    var bitmapData = bitmap.LockBits(new Rectangle(0, 0, pixelData.Width, pixelData.Height)
                    , System.Drawing.Imaging.ImageLockMode.WriteOnly, 
                    System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                    try
                    {

                        System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels,0,
                            bitmapData.Scan0, pixelData.Pixels.Length);
                    }
                    finally
                    {
                        
                        bitmap.UnlockBits(bitmapData);
                    }
                    
                    bitmap.Save(memoryStream , System.Drawing.Imaging.ImageFormat.Png);
                    output.TagName = "img";
                    output.Attributes.Clear();
                    output.Attributes.Add("width",width);
                    output.Attributes.Add("height",height);
                    output.Attributes.Add("src",String.Format("data:image/png;base64,{0}", 
                        Convert.ToBase64String(memoryStream.ToArray())));
                    
                }
                
            }
        }
    }
}