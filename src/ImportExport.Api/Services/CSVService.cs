using CsvHelper;
using CsvHelper.TypeConversion;
using ImportExport.Api.Interfaces;
using ImportExport.Api.Services.Mappers;
using System.Globalization;

namespace ImportExport.Api.Services;

public class CSVService(IInvoiceService invoiceService) : ICSVService
{
    public Task ImportDataFromFile(IFormFile file)
    {
        throw new NotImplementedException();
    }

    public async Task ExportDataToFileAsync(Stream stream)
    {
        var invoices =await invoiceService.GetAsync();
        var writer = new StreamWriter(stream, leaveOpen:true);
        var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        var options = new TypeConverterOptions { Formats = new[] { "yyyy-MM-dd" } };
        csv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
        csv.Context.RegisterClassMap<InvoiceMapper>();
        await csv.WriteRecordsAsync(invoices);
        await writer.FlushAsync();
    }
}
