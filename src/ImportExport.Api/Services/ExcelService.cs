using ImportExport.Api.Interfaces;
using ImportExport.Api.Models;

namespace ImportExport.Api.Services;

public class ExcelService : ICSVService
{
    public Task ImportDataFromFile(IFormFile file)
    {
        throw new NotImplementedException();
    }

    public Task ExportDataToFileAsync(Stream stream)
    {
        throw new NotImplementedException();
    }
}
