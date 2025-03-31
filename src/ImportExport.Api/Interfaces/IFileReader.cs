namespace ImportExport.Api.Interfaces;

public interface IFileReader
{
    Task ImportDataFromFile(IFormFile file);
}
