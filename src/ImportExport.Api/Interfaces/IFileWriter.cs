namespace ImportExport.Api.Interfaces;

public interface IFileWriter
{
    Task ExportDataToFileAsync(Stream stream);
}
