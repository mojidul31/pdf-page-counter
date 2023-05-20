// See https://aka.ms/new-console-template for more information
using iTextSharp.text.pdf;
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");

int pageCount = 0;
String[] pdfFiles = Directory.GetFiles(@"C:\Users\Mojidul\Desktop\MT\Test\DotNet\Core\PdfPageCount\", "*.pdf");
Console.WriteLine("{0} PDF Files in directory",pdfFiles.Length.ToString());
for (int i = 0; i < pdfFiles.Length; i++)
{
    pageCount = GetTotalPageNumber(pdfFiles[i]);
    Console.WriteLine("{0} File has {1} pages", pdfFiles[i], pageCount.ToString());
}
Console.ReadLine();

static int GetTotalPageNumber(String filePath)
{
    PdfReader pdfReader = new PdfReader(filePath);
    return pdfReader.NumberOfPages;
}


