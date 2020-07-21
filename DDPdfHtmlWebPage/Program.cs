using GrapeCity.Documents.Html;
using GrapeCity.Documents.Pdf;
using System;

namespace DDPdfHtmlWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            //GcPdfDocument.SetLicenseKey("");

            var pdffile = @"HTMLPageToPDF.pdf";
            var jpegfile = @"HTMLPageToPDF.jpeg";
            var pngfile = @"HTMLPageToPDF.png";
            var uri = new Uri(@"https://docs.grapecity.com/help/diodocs/pdf/#overview.html");
            var gcHtmlRenderer = new GcHtmlRenderer(uri);

            gcHtmlRenderer.RenderToPdf(pdffile, new PdfSettings());
            gcHtmlRenderer.RenderToJpeg(jpegfile, new JpegSettings());
            gcHtmlRenderer.RenderToPng(pngfile, new PngSettings());
        }
    }
}
