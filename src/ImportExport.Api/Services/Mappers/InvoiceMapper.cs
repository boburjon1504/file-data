using CsvHelper.Configuration;
using ImportExport.Api.Entities;

namespace ImportExport.Api.Services.Mappers;

public class InvoiceMapper : ClassMap<Invoice>
{
    public InvoiceMapper()
    {
        Map(i => i.Id).Name("Id");
        Map(i => i.IssueDate).Name("IssueDate");
        Map(i => i.DueDate).Name("DueDate");
        Map(i => i.Amount).Name("Amount");
        Map(i => i.Currency).Name("Currency");
        Map(i => i.PaymentStatus).Name("PaymentStatus");
    }
}
