using System;

abstract class DocumentMiningTemplate
{
    public void MineDocument(string filePath)
    {
        OpenDocument(filePath);
        ExtractInf();
        CloseDocument();
    }

    protected abstract void OpenDocument(string filePath);
    protected abstract void ExtractInf();
    protected abstract void CloseDocument();
}
class PdfDocumentMining : DocumentMiningTemplate //pdf
{
    protected override void OpenDocument(string filePath)
    {
        Console.WriteLine($"Открытие PDF-файла: {filePath}");
    }

    protected override void ExtractInf()
    {
        Console.WriteLine("Извлечение полезной информации из PDF-файла");
    }

    protected override void CloseDocument()
    {
        Console.WriteLine("Закрытие PDF-файла");
    }
}
class DocDocumentMining : DocumentMiningTemplate //doc
{
    protected override void OpenDocument(string filePath)
    {
        Console.WriteLine($"Открытие DOC-файла: {filePath}");
    }
    protected override void ExtractInf()
    {
        Console.WriteLine("Извлечение полезной информации из DOC-файла");
    }

    protected override void CloseDocument()
    {
        Console.WriteLine("Закрытие DOC-файла");
    }
}
class CsvDocumentMining : DocumentMiningTemplate //csv
{
    protected override void OpenDocument(string filePath)
    {
        Console.WriteLine($"Открытие CSV-файла: {filePath}");
    }

    protected override void ExtractInf()
    {
        Console.WriteLine("Извлечение полезной информации из CSV-файла");
    }

    protected override void CloseDocument()
    {
        Console.WriteLine("Закрытие CSV-файла");
    }
}
class Program
{
    static void Main(string[] args)
    {
        DocumentMiningTemplate pdfMining = new PdfDocumentMining();
        pdfMining.MineDocument("example.pdf");

        DocumentMiningTemplate docMining = new DocDocumentMining();
        docMining.MineDocument("example.doc");

        DocumentMiningTemplate csvMining = new CsvDocumentMining();
        csvMining.MineDocument("example.csv");
    }
}
