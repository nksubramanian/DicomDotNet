// See https://aka.ms/new-console-template for more information

using FellowOakDicom;
using FellowOakDicom.Imaging;
using FellowOakDicom.Imaging.Render;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Drawing;

var templatesFolder = @"C:\Users\subra\source\repos\DicomDotNet\DicomFiles\";


using (var image = Aspose.Imaging.Image.Load(Path.Combine(templatesFolder, @"000003.dcm")))
{
    // Create an instance of JpegOptions
    var exportOptions = new Aspose.Imaging.ImageOptions.JpegOptions();

    // Save dicom to jpeg
    image.Save(Path.Combine(templatesFolder, "output.jpeg"), exportOptions);

    File.Delete(Path.Combine(templatesFolder, "output.jpeg"));
}




