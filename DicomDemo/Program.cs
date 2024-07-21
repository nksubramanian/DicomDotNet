// See https://aka.ms/new-console-template for more information

using FellowOakDicom;
using FellowOakDicom.Imaging;
using FellowOakDicom.Imaging.Codec;
using FellowOakDicom.Imaging.Render;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.Drawing;

var templatesFolder = @"C:\Users\subra\source\repos\DicomDotNet\DicomFiles\";

var x = Path.Combine(templatesFolder, @"output5.dcm");
/*
using (var image = Aspose.Imaging.Image.Load(Path.Combine(templatesFolder, @"000003.dcm")))
{
    // Create an instance of JpegOptions
    var exportOptions = new Aspose.Imaging.ImageOptions.JpegOptions();

    // Save dicom to jpeg
    image.Save(Path.Combine(templatesFolder, "output.jpeg"), exportOptions);

    File.Delete(Path.Combine(templatesFolder, "output.jpeg"));
}
*/





//var file = DicomFile.Open(x);             // Alt 1
                                          

var file = await DicomFile.OpenAsync(x);  // Alt 2

var patientid = file.Dataset.GetString(DicomTag.PatientName);

file.Dataset.AddOrUpdate(DicomTag.PatientName, "DOEJOHN");

var g = file.Dataset.GetString(DicomTag.PatientName);
file.Save(@"C:\Users\subra\source\repos\DicomDotNet\DicomFiles\output5.dcm");             // Alt 1
await file.SaveAsync(@"output.dcm");