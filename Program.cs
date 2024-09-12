using System;
using System.IO;
using  System.Text;
using System.Globalization;

class zmiana
{
    static void Main(string[] args)
    {
        string filePath = @"sciezka";
        string content = File.ReadAllText(filePath);
        string newContent = content.Replace("praca", "job");

        string directory = Path.GetDirectoryName(filePath);
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filePath);
        string extension = Path.GetExtension(filePath);
        string date = DateTime.Now.ToString("yyyyMMdd");
        string newFileName = $"{fileNameWithoutExtension}_changed-{date}{extension}";
        string newFilePath = Path.Combine(directory, newFileName);

        File.WriteAllText(filePath, newContent);
        Console.WriteLine($"Zmieniony plik zostal zapisany jako: {newFilePath}");
    }
}